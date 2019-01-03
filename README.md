# MarmotaAPI

1 - Criar banco de dados chamado Movies:
2- Executar os comando abaixo:

Use use Movies

CREATE TABLE Agendamento
(
IdAgen INT PRIMARY KEY IDENTITY(1,1),
Cidade VARCHAR (20),
Cinema VARCHAR(50),
Sala Int,
Sessão int,
Filme VARCHAR(50)
);

go

INSERT Agendamento

(Cidade,Cinema,Sala,Sessão,Filme)
VALUES
('Rio de Janeiro','Norte Shopping',1,001,'Os Vingadores'),
('Espirito Santo','Potigua Shopping', 1,052,'Os Vingadores'),
('Minas Gerais' , 'Shopping BH',1,024,'Os Vingadores'),
('Sao Paulo','Morumbi Shopping',1,025,'Os Vingadores');
