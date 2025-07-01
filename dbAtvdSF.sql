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
    codigoBarras int not null,
    lote varchar(10) not null,
    imagemProduto longBlob not null,
    primary key(codProduto)
);

desc tbEstoque;

create table tbUsuario(
    codUsu int not null auto_increment,
    usuario varchar(30) not null, 
    senha varchar(12) not null,
    primary key(codUsu)
);

create table tbFotos(
    codFotos int not null primary key,
    imagem 
)


-- update tbEstoque set nomeProd = 'teste', peso = '10', quantidadeProd = 4, validade = '2027-12-09', dataEntrada = '2025-05-10', dataSaida = '10/12/2025', categoriaProd = 'Diverso', localizacaoProd = 'Drive Thru' where codProduto = 2;

-- insert into tbUsuario(usuario, senha) values('eduardo', 'adm');

-- select usuario, senha from tbUsuario where usuario='eduardo' and senha='adm';



