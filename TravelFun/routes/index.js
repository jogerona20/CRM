var express = require('express');
var router = express.Router();
const HotelesController = require("../Controlles/HotelesController");


/* GET home page. */
router.get('/',function (req,res,next){
  res.send("Bievenido");
});

module.exports = router;
