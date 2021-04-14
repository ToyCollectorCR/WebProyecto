var ClickNew = function () {
    window.location.href = "Informacion/NuevaInformacionPersonal";
}


Loading.fire("Cargando Datos..");

$(document).ready(function () {

    $("#GridInformacionPersonal").DataTable();
    setTimeout(function () {
        Loading.close();
    }, 500)
});