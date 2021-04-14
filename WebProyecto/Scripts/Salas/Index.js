var ClickNew = function () {
    window.location.href = "Salas/Edit";
}

var ClickUpdate = function (id) {
    window.location.href = "Salas/Edit/" + id;
}

var ClickEliminar = function (id) {


    Swal.fire({
        title: 'Esta Seguro que desea eliminar este registro?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Borrar Registro!'
    }).then((result) => {
        if (result.isConfirmed) {

            window.location.href = "Salas/Delete/" + id;
        }
    });



}

if (IsLoading) Loading.fire("Cargando Datos..");
$(document).ready(function () {

    $("#GridSalas").DataTable();
    setTimeout(function () {
        if (IsLoading) Loading.close();
    }, 500)
});