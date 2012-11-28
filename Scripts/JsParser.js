$(document).ready(function () {
    $("body").submit(function () {
        var _expr = $("#expression").val().split("\\s+");
        var _error_msg;
        var _valid_token;
        var _valid_operands = /[0-9a-j]+/i;
        var _match_char_end = /[a-j]$/i;
        var _valid_letters = /[a-j]/i;
        var _valid_operators = /[\+|\-|\*|\/|\%]/i;
        var _invalid_char_list = /[^0-9a-j\+\/\*/%-]/i;
        var _token_list = _expr.split(" ");

        for (var i = 0; i < _token_list.length; i++) {
            var _invalid_entry = _invalid_char_list.test(_token_list[i]);
            var _letter_list = 3;

            //1: check for invalid tokens
            //2: check for correct spacing
            //3: check for proper number of variables when multiplying without operator and valid order
            if (_invalid_entry) {
                _expr = "Error";
                _error_msg = "Invalid Character";
                break;
            } else if (_valid_operands.test(_token_list[i]) && _valid_operators.test(_token_list[i])) {
                _expr = "Error";
                _error_msg = "Invalid Format (possible missing space)";
                break;
            } else if (_valid_letters.match(_token_list[i]).length > 1 || !_valid_char_end.test(_token_list[i]) {
                _expr = "Error";
                _error_msg = "Too many variables without operator or improper order.";
            }
            if (_valid_char_end.test(_token_list[i]){
                _valid_token = _valid_letters.exec(_token_list[i]);
                _token_list.replace(_valid_token, " * " + _valid_token);
            }
        }

        $.post("../Default.cshtml", { expression: _expr, error_message: _error_msg }, "text");
    });
});