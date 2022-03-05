"use strict";
var GridInstituciones;
(function (GridInstituciones) {
    /*Muestra modal de mensaje*/
    if (MensajeApp != "") {
        Toast.fire({ icon: "success", title: MensajeApp });
    }
    /*Mostrar el modal de confirmación*/
    function OnclickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Instituciones/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    GridInstituciones.OnclickEliminar = OnclickEliminar;
    /*Datable*/
    $("#GridView").DataTable();
})(GridInstituciones || (GridInstituciones = {}));
//# sourceMappingURL=Grid.js.map