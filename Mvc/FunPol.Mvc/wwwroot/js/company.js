$(document).ready(function () {
    $.get('@Url.Action("CompanyDetails","Company", new { area = "company" })', function (data) {
        $("#tblCompany").html(data);
    });
});
