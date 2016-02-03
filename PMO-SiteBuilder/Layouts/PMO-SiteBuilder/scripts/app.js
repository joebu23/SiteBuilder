function sendData() {
    

    $.ajax({
        url: "/_vti_bin/PMOSiteBuilder/PMOSiteBuilderService.svc/GetTest",
        //data: newModel,
        contentType: "application/json",
        method: "GET",
    })
    .done(function (data) {
        alert(data);
    }).fail(function (errorData) {
        console.log(errorData);
    });

}