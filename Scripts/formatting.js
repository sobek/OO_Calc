$(document).ready(function(){
    $("#expression").click(function () {
        $("#expression").val("");
    });
    $("#expression").keypress(function (e) {
        if (e.which == 13) {
            $("form").submit();
        }
    });
});

function GetVariables(variable_string) {
    var _var_list = variable_string.Split("");
    for (var i = 0 ; i < _var_list.length; i++) {
        var _var_html = '<div class = "variable">' + _var_list[i] + ':' + '<input type = "text" id = ' + _var_list[i] + '>';
        $("#valid_var_area").text("Please enter variables: ");
        $("#valid_var_area").html(_var_html);
    }
    $("#valid_var_area").html('<button id = "submit_vars">Submit Variables</button');
}