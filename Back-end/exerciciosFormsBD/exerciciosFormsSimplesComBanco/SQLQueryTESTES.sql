/* Cria a base */
--create database ATOSUFN;

/* Abre a base para trabalhar diretamente nela */
--use ATOSUFN;

/* Cria a tabela */
--create table pessoa(
--	id_pessoa INTEGER NOT NULL identity,
--	nome VARCHAR(45) NOT NULL,
--	idade INTEGER NOT NULL,
--	cpf VARCHAR(11) NOT NULL,
--	endereco VARCHAR(100) NOT NULL,
--	bairro VARCHAR(45) NOT NULL,
--	cep VARCHAR(8) NOT NULL,
--	cidade VARCHAR(45) NOT NULL,

--	PRIMARY KEY (id_pessoa)
--);

/* Inserir valores na tabela pessoa */
--insert into pessoa values ('Leonardo Cardoso Bertinatti', 25, '11111111111', 'Rua das ruas', 'Bairro dos bairros', '11111111', 'Cidade maravilhosa');
--insert into pessoa values ('Leonardo Cardoso Bertinatti', 25, '11111111111', 'Rua das ruas', 'Bairro dos bairros', '11111111', 'Cidade maravilhosa');
--insert into pessoa values ('Leonardo Cardoso Bertinatti', 25, '11111111111', 'Rua das ruas', 'Bairro dos bairros', '11111111', 'Cidade maravilhosa');
--insert into pessoa values ('Leonardo Cardoso Bertinatti', 25, '11111111111', 'Rua das ruas', 'Bairro dos bairros', '11111111', 'Cidade maravilhosa');
--insert into pessoa values ('Leonardo Cardoso Bertinatti', 25, '11111111111', 'Rua das ruas', 'Bairro dos bairros', '11111111', 'Cidade maravilhosa');

/* Seleciona tudo da tabela pessoa */
--select *
--from pessoa;

/* Seleciona todas as tabelas da base de dados */
--select * from INFORMATION_SCHEMA.TABLES;

/* Seleciona todas as colunas da base de dados */
--select * from INFORMATION_SCHEMA.COLUMNS;

/* Seleciona o nome e o CPF de todas as pessoas */
--select nome, cpf from pessoa;

/* Cria um login e usuário para acessar essa base */
--create login usuario with password='senha';
--create user usuario from login usuario;
--exec sp_addrolemember 'DB_DATAREADER', 'usuario';
--exec sp_addrolemember 'DB_DATAWRITER', 'usuario';