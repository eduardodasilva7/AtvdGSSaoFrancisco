create database dbAtvGFS;

use dbAtvGFS;

create table tbEstoque (
    codProduto int not null auto_increment,
    nomeProd varchar(30) not null,
    peso char(5) not null,
    validade char(10) not null,
    dataEntrada char(10) not null,
    dataSaida char(10),
    categoriaProd varchar(30) not null,
    primary key(codProduto)
);

desc tbEstoque;