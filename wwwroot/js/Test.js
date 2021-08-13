$(document).ready(function () {

    $("#btnAddOption").click(function () {
        AddOptionInToList();
    })
});

function AddOptionInToList() {
    if ($("#txtOptionName").val() === "") {
        $("txtOptionName").focus();
        $("txtOptionName").val("");
        alert("Options cannot be empty");
        return false;
    }
    if ($("#tblOption tr").length == 4) {
        alert("Options should be atleast 4");
        return false;
    }
    var isSuccess = false;
    $.each($("tblOption tr"), function () {
        var listedvalue = $(this).find("td:eq(0) input[type=radio]").val();

        if (listedvalue === $("txtOptionName").val()) {
            alert("Option Already Exists");
            isSuccess = true;
        }
    });
    if (IsSuccess === true) {
        return false;
    }
    var optionName = $("txtOptionName").val();
    var rowAdded = "<tr><td><input type='radio' value=" + optionName + "name='optionName'/>" + optionName + "</td></tr>";
    $("$tblOption").append(rowAdded);
    $("txtOptionName").focus();
    $("txtOptionName").val();
}