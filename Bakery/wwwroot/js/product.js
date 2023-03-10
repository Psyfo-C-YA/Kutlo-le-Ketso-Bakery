var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {

    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Products/GetAll"
        },
        "columns": [
            { "data": "name", "width": "10%" },
            { "data": "flavor", "width": "10%" },
            { "data": "size", "width": "10%" },
            { "data": "price", "width": "10%" },
            { "data": "availability", "width": "10%" },
            /*{ "data": "imageUrl", "width": "15%" },*/
            { "data": "category.name", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                         <a href="/Admin/Products/Upsert?id=${data}" class="btn btn-outline-primary">
                            <i class="bi bi-pencil"></i></a> 
                        <a onClick=Delete('/Admin/Products/Delete/${data}') class="btn btn-outline-danger"><i class="bi bi-trash"></i></a>    
                    `
                },
                "width": "10%"
            },
        ]
    }); 
}

function Delete(url)
{
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
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message)
                    }
                }
            })
        }
    })
}
