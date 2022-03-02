const uri = "api/profile";
$(document).ready(function () {
    debugger;   //breakpoint diyebilirz
    $.ajax(
        {
            type: "GET",
            url: "https://localhost:44304/api/profile",
            contentType: "application/json;charset-utf-8",
            dataType: "json",
            success: function (res) {
                console.log("data2", res);
                $.each(res, function (i, item) {
                    var rows = "<tr>" +
                        "<td id ='phone'>" + item.phone + "</td>" +
                        "<td id ='about'>" + item.about + "</td>" +
                        "</tr>"
                    $('#Table').append(rows);

                })
            }
        });

});