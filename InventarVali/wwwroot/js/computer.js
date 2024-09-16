﻿var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/computer/getall'
        },
        "columns": [
            { data: 'type', "width": "15%" },
            { data: 'model', "width": "15%" },
            { data: 'description', "width": "15%" },
            { data: 'serialNumber', "width": "15%" },
            { data: 'imageUrl', "width": "15%" },
            { data: 'employees.fullName', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                      <a href = "/admin/computer/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit </a>
                      <a onClick = Delete('/admin/computer/delete/${data}') class="btn btn-danger mx-2">  <i class="bi bi-trash3"></i>Delete </a>
                           </div>`
                },
                "width": "25%"
            }
        ],
        dom: 'Bfrtip',
        "buttons": [
            'excel', 'pdf', 'print'
        ]
    })

}

function Delete(url)
{
    Swal.fire({
        title: "Are you sure you want to delete this?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    });
}

