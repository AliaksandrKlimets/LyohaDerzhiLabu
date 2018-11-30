// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('.btn-warning').on('click', function (e) {
    var bookId = $(this).data('bookid');
    $.ajax({
        url: 'Home/GetInfo/' + bookId,
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            //var x = new Date(data.releaseDate);
            //var y = x.getFullYear().toString();
            //var m = (x.getMonth() + 1).toString();
            //var d = x.getDate().toString();
            //(d.length == 1) && (d = '0' + d);
            //(m.length == 1) && (m = '0' + m);
            //var yyyymmdd = y + m + d;
            $('#editName').val(data.name);
            $('#editSurname').val(data.surname);
            $('#editAbout').val(data.about);
            
            $('#editId').val(data.id);
        }
    });
});

$('.btn-danger').click(function (event) {
    event.preventDefault();
    if (confirm('Are you sure?')) {
        //var bookId = $(this).data('bookid');
        window.location = $(this).attr('href');
    }
});