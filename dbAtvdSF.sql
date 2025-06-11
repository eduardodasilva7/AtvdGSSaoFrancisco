drop database dbAtvGFS;
create database dbAtvGFS;

use dbAtvGFS;

create table tbEstoque (
    codProduto int not null auto_increment,
    nomeProd varchar(30) not null,
    peso char(5) not null,
    quantidadeProd char(5) not null,
    validade dateTime not null,
    dataEntrada dateTime not null,
    dataSaida char(10),
    categoriaProd varchar(30) not null,
    localizacaoProd varchar(30) not null,
    primary key(codProduto)
);

desc tbEstoque;


-- update tbEstoque set nomeProd = 'teste', peso = '10', quantidadeProd = 4, validade = '2027-12-09', dataEntrada = '2025-05-10', dataSaida = '10/12/2025', categoriaProd = 'Diverso', localizacaoProd = 'Drive Thru' where codProduto = 2;


