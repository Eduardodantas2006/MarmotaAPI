Script para criação do banco de dados para utilização do API

# MarmotaAPI

1 - Criar banco de dados chamado Movies:
2- Executar os comando abaixo:

Use use Movies

Create Table Agendamento
(
IdAgen Int Primary key Identity(1,1),
Cidade Varchar (20),
Cinema Varchar(50),
Sala Int,
Sessão int,
Filme Varchar(50)
);

go

Insert Agendamento

(Cidade,Cinema,Sala,Sessão,Filme)
Values
('Rio de Janeiro','Norte Shopping',1,001,'Os Vingadores'),
('Espirito Santo','Potigua Shopping', 1,052,'Os Vingadores'),
('Minas Gerais' , 'Shopping BH',1,024,'Os Vingadores'),
('Sao Paulo','Morumbi Shopping',1,025,'Os Vingadores');
