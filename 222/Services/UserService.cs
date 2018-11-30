using _222.EF;
using _222.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _222.Services
{
    public class UserService
{
        private readonly IConfiguration Configuration;
        readonly Context _context;

        public UserService(Context ctx, IConfiguration config)
        {
            Configuration = config;
            _context = ctx;
        }

        public async Task<User> FindOnLoginAsync(string email, string passwordString)
        {
            var user = await _context.Users.Where(u => u.Email == email).SingleOrDefaultAsync();
            if (user != null)
            {
                bool wrongPassword = !VerifyPasswordHash(passwordString, user.PasswordHash, user.PasswordSalt);
                if (wrongPassword)
                    return null;
                return user;
            }
            return null;
        }


        public async Task CreateAsync(RegisterViewModel model)
        {
            User user = new User()
            {
                Email = model.Email,
                Name = model.Name,
                Surname = model.Surname
            };

            byte[] passwordSalt, passwordHash;
            CreatePasswordHash(model.PasswordString, out passwordSalt, out passwordHash);

            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsEmailExistAsync(string email)
        {
            bool result = await _context.Users.AnyAsync(u => u.Email == email);
            return result;
        }

        private void CreatePasswordHash(string passwordString, out byte[] passwordSalt, out byte[] passwordHash)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
            }
        }

        private bool VerifyPasswordHash(string passwordString, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                        return false;
                }
                return true;
            }
        }
    }
}
