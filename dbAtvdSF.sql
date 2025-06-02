drop database dbAtvGFS;
create database dbAtvGFS;

use dbAtvGFS;

create table tbEstoque (
    codProduto int not null auto_increment,
    nomeProd varchar(30) not null,
    peso char(5) not null,
    validade char(10) not null,
    dataEntrada date not null,
    dataSaida char(10),
    categoriaProd varchar(30) not null,
    localizacaoProd varchar(30) not null,
    primary key(codProduto)
);

desc tbEstoque;

insert into tbEstoque(nomeProd, peso, validade, dataEntrada, dataSaida, categoriaProd, localizacaoProd) values("teste", '15kg', '20/11/2019', '20/11/2021', '25/12/2022', 'Necessario', 'Drive-Thru');