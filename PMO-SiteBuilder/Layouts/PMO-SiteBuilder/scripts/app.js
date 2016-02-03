function sendData() {

    var dataModel = {
        ProjectName: $("#projectName").val(),
        StartDate: $("#startDate").val(),
        ClientList: $("#clients").val(),
        CdhList: $("#cdhMembers").val()
    };

    var newModel = JSON.stringify({ projectDetails: dataModel });

    $.ajax({
        url: "/_vti_bin/PMOSiteBuilder/PMOSiteBuilderService.svc/GenerateProject",
        data: newModel,
        contentType: "application/json",
        method: "POST",
    })
    .done(function (data) {
        alert(data);
    }).fail(function (errorData) {
        console.log(errorData);
    });

}