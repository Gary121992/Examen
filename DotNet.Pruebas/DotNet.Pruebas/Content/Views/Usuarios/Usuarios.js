var modelo = {};

$(document).ready(function () {
    ConsultarUsuarios();
});

function AbrirModal(show) {
    if (show) {
        $("#myModal").modal("show");
    }
    else
        $("#myModal").modal("hide");
}

$(btnGuardar).click(function () {
    modelo.Nombre = $(nombre).val();
    modelo.ApellidoPaterno = $(apellido_paterno).val();
    modelo.ApellidoMaterno = $(apellido_materno).val();
    modelo.Direccion = $(direccion).val();
    modelo.Telefono = $(telefono).val();

    $.ajax({
        url: '/api/apiusuarios/CrearUsuario',
        type: 'POST',
        data: modelo,
        dataType: 'json',

        beforeSend: function (data) {
            
        },

        success: function (data) {
            AbrirModal(false);
            alert('Usuario creado con exito');
            ConsultarUsuarios();
        },

        error: function (xhr, status) {

        },

        complete: function (xhr, status) {
            
        }
    });
});

function ConsultarUsuarios() {
    $.ajax({
        url: '/api/apiusuarios/consultarusuarios',
        type: 'GET',
        dataType: 'json',

        beforeSend: function (data) {

        },

        success: function (data) {
            $("#tblUsuarios tbody tr").remove();
            var table = document.getElementById("tblUsuarios");
            var tBody = table.tBodies[0];

            $.each(data, function (index, item) {
                var row = tBody.insertRow(index);

                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);

                cell1.innerHTML = item.Nombre;
                cell2.innerHTML = item.ApellidoPaterno + ' ' + item.ApellidoMaterno;
                cell3.innerHTML = item.Telefono;
                cell4.innerHTML = item.Direccion;

            });
        },

        error: function (xhr, status) {

        },

        complete: function (xhr, status) {

        }
    });
}