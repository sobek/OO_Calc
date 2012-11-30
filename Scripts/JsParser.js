$(document).ready(function () {
    $("body").submit(function (e) {
        //e.preventDefault();
 /*       $("#variable_area").text("");

        var _expr = $("#expression").val().split(" ");
        var _error_msg;
        var _valid_token;
        var _valid_operands = /[0-9a-j]+/i;
        var _valid_digits = /\d/;
        var _valid_variables = /[a-j]/i;
        var _valid_operators = /[\+|\-|\*|\/|\%]/i;
        var _invalid_char_list = /[^0-9a-j\+/%\/\*-]/i;

        for (var i = 0; i < _expr.length; i++) {
            var _invalid_entry = _invalid_char_list.test(_expr[i]);
            //1: check for invalid tokens
            //2: check for correct spacing
            //3: check for proper number of variables when multiplying without operator and valid order
            if (_invalid_entry) {
                $("#variable_area").text("Invalid Character");
                break;
            } else if (_valid_operands.test(_expr[i]) && _valid_operators.test(_expr[i])) {
                $("#variable_area").text("Invalid Format (possible missing space)");
                break;
            } else if (_valid_digits.test(_expr[i]).length > 1 && _valid_variables.test(_expr[i])) {
                $("#variable_area").text("Improper format.  Separate variables and constants.");
            }
        }
        //_expr = _expr.join(" ");
*/
        //      $.post("../Default.cshtml", { expression: _expr }, "text");
        $.post("..Default.cshtml");
    });
});