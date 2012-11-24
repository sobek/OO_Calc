$(document).ready(function () {
    $("body").submit(function (e) {
        //e.preventDefault();
        alert("submitted");
        var _expr = $("#expression").val();
        var _regex = /[0-9a-j \+|\-|\*|\/|\%]+/i;
        var _parsed_expr = _regex.exec($("#expression").val());
        if (_parsed_expr != _expr.replace(/\s/, "")
        {
            _expr = "error"
        }
        else
        {
            //incomplete
        }
        $.post("../Default.cshtml", { expression: _expr }, "text");
    });
});