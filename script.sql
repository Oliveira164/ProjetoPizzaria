-- CRIANDO O BANCO DE DADOS
CREATE DATABASE BDPizzaria1;

-- USANDO BANCO DE DADOS
USE BDPizzaria1;

-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE table tbPedido (
  codPedido int primary key auto_increment,
  tipoPizza varchar(50),
  valorPizza varchar(50),
  valorOpcao varchar(50),
  valorTotal varchar(50)
  );

-- CONSULTANDO A TBELA DO BANCO DE DADOS

SELECT * FROM tbPedido;