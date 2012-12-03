$(document).ready(function () {
    $("#submit_button").submit(function (e) {
        e.preventDefault();

      
       $("#variable_area").text("");
       var _expr = $("#expression").val().split(" ");
       //$("#expression").val(_expr);
       var _valid_token;
       var _valid_operands = /[0-9a-j]+/i;
       var _valid_digits = /[0-9]/;
       var _valid_variables = /[a-j]/i;
       var _valid_operators = /[\+|\-|\*|\/|\%]/i;
       var _invalid_char_list = /[^0-9a-j\+/%\/\*-]/i;

       for (var i = 0; i < _expr.length; i++) {
           var _invalid_entry = _invalid_char_list.test(_expr[i]);;
           //1: check for invalid tokens
           //2: check for correct spacing
           //3: check for proper number of variables when multiplying without operator and valid order
           if (_invalid_entry) {
               $("#variable_area").text("Invalid Character");
               break;
           } else if (_valid_operands.test(_expr[i]) && _valid_operators.test(_expr[i])) {
               $("#variable_area").text("Make sure everything is separated by spaces.");
               break;
           } else if (_valid_digits.test(_expr[i]) && _valid_variables.test(_expr[i])) {
               $("#variable_area").text("Not stuck together like glue.  Separate variables from constants.");
               break;
           }else if (_expr[i] == "/" && _expr[i + 1] == 0) {
               $("#variable_area").text("One (or many) can not divide by zero.");
               break;
           }
       }

       _expr = _expr.join(" ");

       if (!_valid_variables.test(_expr)) {
       alert("alert");
       
        $.post("/Default.cshtml", { expression: _expr }, "text");
        }

        $("#expression").keypress(function (e) {
            if (e.which == 13) {
                $("form").submit();
            }
        });
    });
});

//www.jslab.dk/library/Array.unique
Array.prototype.unique = 
    function () {
        var a = [];
        var l = this.length;
        for (var i = 0; i < 1; i++) {
            for (var j = i + 1; j < 1; j++) {
                if (this[i] === this[j])
                    j = ++i;
            }
            a.push(this[i]);
        }
        return a;
    }
