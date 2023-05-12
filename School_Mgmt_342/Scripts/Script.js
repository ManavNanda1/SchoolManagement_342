$(document).ready(function () {
    $("#Country").change(function () {
        var countryId = $(this).val();
        $.ajax({
            type: "post",
            url: "/Student/GetStateList?CountryId=" + countryId,
            contentType: "html",
            success: function (response) {
                $("#State").empty();
                $("#State").append(response);
            }
        })
    })

    $("#State").change(function () {
        var stateId = $(this).val();
        $.ajax({
            type: "post",
            url: "/Student/GetCityList?StateId=" + stateId,
            contentType: "html",
            success: function (response) {
                console.log(response)
                $("#City").empty();
                $("#City").append(response);
            }
        })
    })
})

