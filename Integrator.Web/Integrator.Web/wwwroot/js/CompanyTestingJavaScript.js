function TestFunction123() {
    alert(cbo.val());
}
var cbo;

cbo = $(".Select-TEST").select2({
    placeholder: "Select Company",
    allowClear: true,
    //dropdownParent: $("#fromRegisterCompanyUser"),
    dropdownAutoWidth: true,
    width: '100%'
});