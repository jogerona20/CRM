INSERT INTO Producto VALUES ('SKU1', 'Producto1', 123, 'Producto numero uno en venta') 
INSERT INTO Producto VALUES ('SKU2', 'Producto2', 142, 'Producto numero dos en venta') 
INSERT INTO Producto VALUES ('SKU3', 'Producto3', 532, 'Producto numero tres en venta') 
INSERT INTO Producto VALUES ('SKU4', 'Producto4', 9281, 'Producto numero cuatro en venta') 
INSERT INTO Producto VALUES ('SKU5', 'Producto5', 8373, 'Producto numero cinco en venta') 
INSERT INTO Producto VALUES ('SKU6', 'Producto6', 99, 'Producto numero seis en venta') 
INSERT INTO Producto VALUES ('SKU7', 'Producto7', 431, 'Producto numero siete en venta') 

INSERT INTO Venta VALUES('510419da-02fe-4e43-8034-503f952558e5', GETDATE(), 'En espera', 806)

INSERT INTO CarritoProducto VALUES(1,null,'510419da-02fe-4e43-8034-503f952558e5', 123)
INSERT INTO CarritoProducto VALUES(2,null,'510419da-02fe-4e43-8034-503f952558e5', 142)
INSERT INTO CarritoProducto VALUES(3,null,'510419da-02fe-4e43-8034-503f952558e5', 532)
INSERT INTO CarritoProducto VALUES(4,1,'510419da-02fe-4e43-8034-503f952558e5', 9281)
INSERT INTO CarritoProducto VALUES(5,1,'510419da-02fe-4e43-8034-503f952558e5', 8373)
INSERT INTO CarritoProducto VALUES(6,1,'510419da-02fe-4e43-8034-503f952558e5', 99)
INSERT INTO CarritoProducto VALUES(7,null,'510419da-02fe-4e43-8034-503f952558e5', 231)
