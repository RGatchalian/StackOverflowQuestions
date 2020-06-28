$(document).ready(function () {
    $.ajax({
        type: "GET"
        , url: 'http://localhost/TestCors/api/test'
        , xhrFields: {
            withCredentials: true
        }
    }).done(function (data) {
        console.log(JSON.stringify(data));
    }).fail(function (jqXHR, textStatus, errorThrown) {
        console.log(jqXHR.responseText || textStatus);
    });

});
