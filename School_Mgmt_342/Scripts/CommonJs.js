function DeleteConfirmation(id) {
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
                url: "/Country/Delete/" + id,
                type: "POST",
                success: function (data) {
                    location.reload();
                },
                error: function (xhr, status, error) {
                    location.reload();
                }
            });
        }
    })
}

function StateDeleteConfirm(id) {
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
                url: "/State/DelState/" + id,
                type: "POST",
                success: function (data) {
                    location.reload();
                },
                error: function (xhr, status, error) {
                    location.reload();
                }
            });
        }
    })

}

function CityDeleteConfirm(id) {
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
                url: "/City/DelCity/" + id,
                type: "POST",
                success: function (data) {
                    location.reload();
                },
                error: function (xhr, status, error) {
                    location.reload();
                }
            });
        }
    })
}

function SubjectDelConfirm(id) {
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
                url: "/Subject/DelSubject/" + id,
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



