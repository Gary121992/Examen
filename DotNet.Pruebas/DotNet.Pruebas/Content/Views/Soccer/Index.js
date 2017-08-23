$(document).ready(function () {
    $.ajax({
        url: '/api/ApiSuccer/ConsultarTorneos',
        type: 'GET',
        dataType: 'json',

        beforeSend: function (data) {

        },

        success: function (data) {
            $.each(data, function (index, item) {
                $(torneos).append('<option value=' + item.Id + '>' + item.Name + '</option>');
            });
        },

        error: function (xhr, status) {

        },

        complete: function (xhr, status) {

        }
    });
});

function consultarPartidos() {
    $.ajax({
        url: '/api/ApiSuccer/ConsultarPartidos?id=' + encodeURI($(torneos).val()),
        type: 'GET',
        dataType: 'json',

        beforeSend: function (data) {

        },

        success: function (data) {
            $("#tblPartidos tbody tr").remove();
            var table = document.getElementById("tblPartidos");
            var tBody = table.tBodies[0];

            $.each(data, function (index, item) {
                var row = tBody.insertRow(index);

                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);
                var cell5 = row.insertCell(4);
                var cell6 = row.insertCell(5);

                cell1.innerHTML = item.Equipo_Local;
                cell2.innerHTML = item.Equipo_Visitante;
                cell3.innerHTML = item.Fecha;
                cell4.innerHTML = item.Status;
                cell5.innerHTML = item.Goles_Local;
                cell6.innerHTML = item.Goles_Visitante;

            });
        },

        error: function (xhr, status) {

        },

        complete: function (xhr, status) {

        }
    });
}