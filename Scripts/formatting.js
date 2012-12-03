$(document).ready(function () {
    $("#expression").click(function () {
        $("#expression").val("");
    });
    $("#expression").keypress(function (e) {
        if (e.which == 13) {
            $("form").submit();
        }
    });
});
