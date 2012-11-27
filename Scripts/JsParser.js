$(document).ready(function () {
    $("body").submit(function () {
        var _expr = $("#expression").val().split("\\s+");
        var _valid_operands = /[0-9a-j]+/i;
        var _valid_operators = /[\+|\-|\*|\/|\%]/i;
        var _invalid_char_list = /[^0-9a-j\+\/\*/%-]/i;
        var _token_list = _expr.split(" ");
        for (var i = 0; i < _token_list.length; i++) {
            //var _temp_list = "something";
            var _invalid_entry = _invalid_char_list.test(_token_list[i]);
            if (_invalid_entry) {
                _expr = "Invalid Character";
                break;
            } else if (_valid_operands.test(_token_list[i]) && _valid_operators.test(_token_list[i])) {
                _expr = "Invalid Format (missing space)";
                break;
            } else if(){
            } 
        }
        $.post("../Default.cshtml", { expression: _expr }, "text");
    });
});