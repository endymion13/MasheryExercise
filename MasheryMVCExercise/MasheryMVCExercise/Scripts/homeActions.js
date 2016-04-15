$(document).ready(function () {

    $("input[type=submit]").click(function ()
    {
       

        if (document.getElementById("txtUserName").value != "")
        {
            var accion = $(this).attr('dir');
            $('form').attr('action', accion);
            $('form').submit();

        }
        else
        {
            alert("Please type a username");
            return;
        }

    });

});