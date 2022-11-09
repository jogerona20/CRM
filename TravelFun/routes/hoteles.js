var express = require('express');
var router = express.Router();
const HotelesController = require("../Controlles/HotelesController");

var multer = require('multer');
var fecha = Date.now();

var rutaAlmacen = multer.diskStorage(
    {
    destination:function(request,file,callback){
        callback(null,'./public/images')
    },
    filename:function (request,file,callback) {
        console.log(file);
        callback(null,fecha+"_"+file.originalname);
    }
});

var cargar = multer({storage:rutaAlmacen});

/* GET home page. */
router.get('/',HotelesController.index);
router.get('/crear',HotelesController.crear);
router.post("/",cargar.single("archivo"),HotelesController.guardar);

router.post('/eliminar/:Id_Hotel',HotelesController.eliminar);

router.get('/editar/:Id_Hotel',HotelesController.editar);

router.post("/actualizar",cargar.single("archivo"),HotelesController.actualizar);


router.get('/correo',HotelesController.correo);


module.exports = router;
