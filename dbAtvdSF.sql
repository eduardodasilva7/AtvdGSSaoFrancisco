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
    
    primary key(codProduto)
);

desc tbEstoque;

create table tbUsuario(
    codUsu int not null auto_increment,
    usuario varchar(30) not null unique, 
    senha varchar(12) not null,
    primary key(codUsu)
);


create table tbFuncoes(
    codFunc int not null,
    descricao varchar(50) not null,
    primary key(codFunc)
);

create table tbVoluntarios(
    codVol int not null,
    nome varchar(100) not null,
    email varchar(50) not null,
    telCel char(15) not null,
    endereco varchar(100) not null,
    numero char(5) not null,
    cep char(9) not null,
    complemento varchar(50),
    bairro varchar(30),
    cidade varchar(50),
    estado char(2),
    codFunc int not null,
    data datetime,
    hora dateTime,
    status int(11),
    fotos longblob, 
    primary key(codVol),
    foreign key(codFunc) references tbFuncoes(codFunc),
    
);

insert into tbVoluntarios(nome,email,telCel,endereco,numero,cep,complemento,bairro,cidade,estado,codFUnc,data,hora,status,codFotos)values(@nome,@email,@telCel,@endereco,@numero,@cep,@complemento,@bairro,@cidade,@estado,@codFUnc,@data,@hora,@status,@codFotos);


-- update tbEstoque set nomeProd = 'teste', peso = '10', quantidadeProd = 4, validade = '2027-12-09', dataEntrada = '2025-05-10', dataSaida = '10/12/2025', categoriaProd = 'Diverso', localizacaoProd = 'Drive Thru' where codProduto = 2;

-- insert into tbUsuario(usuario, senha) values('eduardo', 'adm');

-- select usuario, senha from tbUsuario where usuario='eduardo' and senha='adm';



