function TeacherDelConfirm(id) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: "/Teacher/DelTeacher/" + id,
                type: "post",
                success: function (data) {
                    location.reload();
                },
                error: function (error) {
                    location.reload();
                }
            });
        }
    })
}


$(document).ready(function () {
    $("#Subject").select2({
        multiple: true
    });

    $('#DOB').datepicker({
        dateFormat: 'yy-mm-dd'
    });

    $("#Country").change(function () {
        var countryId = $(this).val();
        $.ajax({
            type: "post",
            url: "/Teacher/GetStateList?CountryId=" + countryId,
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
            url: "/Teacher/GetCityList?StateId=" + stateId,
            contentType: "html",
            success: function (response) {
                console.log(response)
                $("#City").empty();
                $("#City").append(response);
            }
        })
    })
})
