
<h1 align="center">Squad Sarah Gilbert</h1>
➡Os dados aqui inseridos são fictícios 


SELECT * FROM dbclientes;
SELECT * FROM  produtos;
SELECT * FROM  dbpedidos;
SELECT * FROM  pedidoitem;




---------------------- Listagem de clientes
INSERT INTO dbclientes (ID,Nome,email,endereco,telefone,CPF)
VALUES
(1,'Ana','anamr23@gmail.com','ruadosgoytacazes','959673885','93811958038'),
(2,'Andre','andreercb@hotmail.com','ruaitabaina','927742198','50590755080'),
(3,'Luiz','luizrp@gmail.com','ruaminasgerais','926751564','11095964054'),
(4,'Maria','mariafeliciaxy@outlook.com','ruajoseconradodearaujo','991262033','24329645009');




---------------------Listagem de pedidos
INSERT INTO dbpedidos(ID,clienteID,valortotal,numeropedido,dataentrega,datacompra)
VALUES
(0,2 ,199,1,'2022/05/21','2022/05/05'),
(1,1,299,2,'2022/06/21','2022/06/10'),
(2,3,500,3,'2022/06/30','2022/06/20'),
(3,4,190,4,'2022/07/10','2022/07/20');


---------------------Listagem de pedidositem
INSERT INTO pedidoitem(ID,pedidoID,produtoID,qtditens,subtotal)
VALUES
(0, 1 ,1,1, 199),
(1,2,2,1, 299),
(2,2,3,1,500),
(3,3,4,1,190);          

-----------------------Listagem de Produtos

INSERT INTO produtos (ID,nome,precounitario,datafabricacao,garantia,descricao)
VALUES
(1,'ssd Kingston',199.00, '2021-12-27', 2 , 'o ssd kingston  de alta velocidade de leitura '),
(2,'placa mae amd', 299,'2021-12-5', 3,'placa mae modelo amd'),
(3,'placa de video', 500,'2021-12-5', 3,'placa de video'),
(4,'hd externo', 190,'2021-12-5', 3,'hd externo ');

