$(document).ready(function () {
    $("body").submit(function () {
        var _expr = $("#expression").val();
        var _regex = /[0-9a-j \+|\-|\*|\/|\%]+/i;
        var _parsed_expr = _regex.exec($("#expression").val());
        var _invalid_entries = /[^0-9a-j \+|\-||\*|\/|\%]+/i;
        var _valid_vars_check = /[a-j]/i;

        if(_invalid_entries.exec($("#expression").val()))
        {
            _expr = "Please recheck your entry for invalid elements: " + $("#expression").val();
        }
        if(_valid_vars_check.test(_parsed_expr)){
            GetVarValues(_valid_vars_check.exec(_parsed_expr));
        }
        $.post("../Default.cshtml", { expression: _expr }, "text");
    });
});