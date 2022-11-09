const { actualizar } = require("../Controlles/HotelesController");

module.exports = {
    obtener: function (conexion,funcion){
        conexion.query("select * from hotel", funcion);
    },
    insertar: function (conexion,datos,archivos,funcion){
        conexion.query("INSERT INTO hotel (Nombre_Hotel, imagen, Precio) VALUES (?,?,?)",[datos.nombre, archivos.filename, datos.precio] , funcion);
    },
    retornarDatosID:function(conexion,id,funcion){
        conexion.query("select * from hotel where Id_Hotel=?",[id] ,funcion);
    },
    borrar:function(conexion,id,funcion){
        conexion.query("DELETE FROM hotel where Id_Hotel=?",[id] ,funcion);
    },
    actualizar:function(conexion,datos,funcion){
        conexion.query("UPDATE hotel SET Nombre_Hotel=?, Precio=? WHERE Id_Hotel=? ",[datos.nombre, datos.precio, datos.Id_Hotel], funcion);
    },
    actualizarArchivo:function(conexion,datos,archivos,funcion){
        conexion.query("UPDATE hotel SET imagen=? WHERE Id_Hotel=? ",[archivos.filename, datos.Id_Hotel], funcion);
    }
}