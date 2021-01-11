$(document).ready(function () {
    $.ajax({
        url: '/Home/BuildToDoTable',
        success: function (result) {
            $('#table').html(result);
        }
    })
})