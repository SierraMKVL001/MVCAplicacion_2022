function CalcularIMSS() {
    var id = $("#Id").text();
    var urlWS = "/Alumnos/_AportacionesIMSS/" + id;
    LlamaAjaxGet(urlWS, MuestraAportacionesIMSS);
}
function LlamaAjaxGet(url, funcionExito) {
    $.ajax({
        type: 'GET',
        url: url,
        data: {},
        contentType: "application/json; charset = utf - 8",
        dataType: "html",
        success: funcionExito,
        error: errorGenerico
    });
}

function MuestraAportacionesIMSS(data) {
    try {
        if (data != null) {
            $("#modalBody").html(data);
            $("#IMSSModClient").modal();
        } else {
            alert('La pagina Web no puede responder a tu peticion')
        }
    } catch (ex) {
        alumno = [];
        alert('No se pudo guardar los datos');
    }
}
function funcExito(resultado, estatus, jqXHR) {
    var oRespuesta;
    try {
        oRespuesta = JSON.parse(resultado.d);
        if (oRespuesta != null) {
            if (oRespuesta.Mensaje == "Exito") {
                alert('Transacción efectuada con éxito');
                /*window.location.href = "Default.aspx";*/
            }
            else {
                alert(oRespuesta.Mensaje);
            }
        }
        else {
            alert('La respuesta recibida del Web Service es incorrecta ' + resultado.d);
        }
    }
    catch (ex) {
        alert('Error al recibir los datos');
    }
}

function CalcularISR() {
    var id = $("#Id").text();
    var urlWS = "/Alumnos/_TablaISR/" + id;
    LlamaAjaxGet(urlWS, MuestraTablaISR);
}
function LlamaAjaxGet(url, funcionExito) {
    $.ajax({
        type: 'GET',
        url: url,
        data: {},
        contentType: "application/json; charset = utf - 8",
        dataType: "html",
        success: funcionExito,
        error: errorGenerico
    });
}

function MuestraTablaISR(data) {
    try {
        if (data != null) {
            $("#modalBody").html(data);
            $("#IMSSModClient").modal();
        } else {
            alert('La pagina Web no puede responder a tu peticion')
        }
    } catch (ex) {
        alumno = [];
        alert('No se pudo guardar los datos');
    }
}
function funcExito(resultado, estatus, jqXHR) {
    var oRespuesta;
    try {
        oRespuesta = JSON.parse(resultado.d);
        if (oRespuesta != null) {
            if (oRespuesta.Mensaje == "Exito") {
                alert('Transacción efectuada con éxito');
                /*window.location.href = "Default.aspx";*/
            }
            else {
                alert(oRespuesta.Mensaje);
            }
        }
        else {
            alert('La respuesta recibida del Web Service es incorrecta ' + resultado.d);
        }
    }
    catch (ex) {
        alert('Error al recibir los datos');
    }
}

function errorGenerico(jqXHR, estatus, error) {
    var msg = '';
    if (jqXHR.status === 0) {
        msg = 'No está conectado, favor de verificar su conexión.';
    }
    else if (jqXHR.status === 404) {
        msg = 'Página no encontrada [404]';
    }
    else if (jqXHR.status === 500) {
        msg = 'Error no hay conexión al servidor [500]';
    }
    else if (jqXHR.status === 'parseerror') {
        msg = 'El parseo del JSON es erróneo.';
    }
    else if (jqXHR.status === 'timeout') {
        $('body').addClass('loaded');
    }
    else if (jqXHR.status === 'abort') {
        msg = 'La petición Ajax fue abortada.';
    }
    else {
        msg = 'Error no conocido. ';
        console.log(exception);
    }
    alert(msg);
}