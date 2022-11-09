var conexion=require('../config/conexion');
var hotel = require("../model/hotel"); 
var borrar= require("fs");
module.exports={

    index:function(req,res){

        hotel.obtener(conexion,function (err,datos){
            
            //console.log(datos)

            res.render('hoteles/index', { title: 'Aplicacion', hoteles:datos });
        })

        
    },
    crear:function(req,res){
        res.render('hoteles/crear');
    },
    correo:function(req,res){
        res.render('hoteles/correo');
    },
    guardar:function(req,res){
       console.log(req.body);
       console.log(req.file.filename);
       hotel.insertar(conexion,req.body,req.file,function (err){
        res.redirect('/hoteles');
        })
    },
    eliminar:function(req,res) {

        hotel.retornarDatosID(conexion,req.params.Id_Hotel,function(err,registros){
            var nombreImagen="public/images/"+(registros[0].imagen);

            if(borrar.existsSync(nombreImagen)){
                borrar.unlinkSync(nombreImagen);
            }
            hotel.borrar(conexion,req.params.Id_Hotel,function(err){
                res.redirect('/hoteles')
            });
        });
    },
    editar:function(req,res) {
        hotel.retornarDatosID(conexion,req.params.Id_Hotel,function(err,registros){
            console.log(registros[0]);
            res.render('hoteles/editar',{hotel:registros[0]});
        });
    },
    actualizar:function name(req,res){
        console.log(req.body.nombre)
        console.log(req.body.precio)
        if (req.body.nombre) {
            hotel.actualizar(conexion,req.body, function(err){});
        }
        if (req.file) {
            if (req.file.filename) {

                hotel.retornarDatosID(conexion,req.body.Id_Hotel,function(err,registros){
                    var nombreImagen="public/images/"+(registros[0].imagen);
                    if(borrar.existsSync(nombreImagen)){
                        borrar.unlinkSync(nombreImagen);
                    }

                    hotel.actualizarArchivo(conexion,req.body,req.file,function(err){})

                });

            }
        }

        res.redirect('/hoteles');
        
    }
}