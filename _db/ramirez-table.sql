CREATE TABLE Funcionario
(
	FuncionarioId int IDENTITY(1,1) primary key,
	Nome VARCHAR(100) NOT NULL,
	Cpf VARCHAR(11) NOT NULL,
	Cargo VARCHAR(50) NOT NULL,
	Telefone VARCHAR(15) NULL,
)
GO

CREATE TABLE Cliente
(
	ClienteId int IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(100) NOT NULL,
	Cpf VARCHAR(11) NOT NULL,
	Endereco VARCHAR(150) NULL,
	Telefone varchar(15) NULL,
	Email VARCHAR(100) NULL,
)
GO

CREATE TABLE Categoria
(
	CategoriaId int IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE Carro
(
	Carro_id int IDENTITY(1,1) PRIMARY KEY,
	CategoriaId int NOT NULL FOREIGN KEY REFERENCES Categoria(CategoriaId),
	Placa VARCHAR(7) NOT NULL,
	Modelo VARCHAR(50) NOT NULL,
	Fabricante VARCHAR(50) NOT NULL,
	Ano INT NOT NULL,
)
go

CREATE TABLE Reserva
(
	ReservaId int IDENTITY(1,1) PRIMARY KEY,
	ClienteId int NOT NULL FOREIGN KEY REFERENCES Cliente(ClienteId),
	Carro_id int NOT NULL FOREIGN KEY REFERENCES Carro(Carro_id),
	Data_inicio DATETIME NOT NULL,
	Data_fim DATETIME NOT NULL,
	Status VARCHAR(20) NOT NULL,
)
go

CREATE TABLE Locacao
(
	Locacaoid INT IDENTITY(1,1) PRIMARY KEY,
	ReservaId int NOT NULL FOREIGN KEY REFERENCES Reserva(ReservaId),
	ClienteId int NOT NULL FOREIGN KEY REFERENCES Cliente(ClienteId),
	Carro_id int NOT NULL FOREIGN KEY REFERENCES Carro(Carro_id),
	FuncionarioId int NOT NULL FOREIGN KEY REFERENCES Funcionario(FuncionarioId),
	DataRetirada DATETIME NOT NULL,
	DataDevolucao DATETIME NOT NULL,
	ValorTotal DECIMAL(10,2) NOT NULL,
	Status VARCHAR(20) NOT NULL,
)
GO

CREATE TABLE Pagamento
(
	PagamentoId INT IDENTITY(1,1) PRIMARY KEY,
	LocacaoId int NOT NULL FOREIGN KEY REFERENCES Locacao(LocacaoId),
	[Data] DATETIME NOT NULL,
	Valor DECIMAL(10, 2),
	Metodo VARCHAR(20),
	Status VARCHAR(20)
)
GO