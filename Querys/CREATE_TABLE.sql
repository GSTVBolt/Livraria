use db_Livraria
go

--Table pagamento
CREATE TABLE tbl_Pagamento (
	cd_Pgto INT PRIMARY KEY IDENTITY,
	ds_Pgto VARCHAR(20) NOT NULL
);

--Table Categoria
CREATE TABLE tbl_Categoria(
	cd_Categoria INT PRIMARY KEY IDENTITY,
	nm_Categoria VARCHAR(20) NOT NULL
);

--Table Editora
CREATE TABLE tbl_Editora(
	cd_Editora INT PRIMARY KEY IDENTITY,
	nm_Editora VARCHAR(20)
);

--Table Livro
CREATE TABLE tbl_Livro(
	cd_Livro INT PRIMARY KEY IDENTITY,
	nm_Livro VARCHAR(60) NOT NULL,
	no_Paginas VARCHAR(4) NOT NULL,
	vl_Livro DECIMAL(10,2) NOT NULL,
	qt_Estoque INT NOT NULL,
	no_Isbn CHAR(17) NOT NULL,
	dt_AnoPublica CHAR(4) NOT NULL,
	cd_Categoria INT,
	cd_Editora INT
	FOREIGN KEY (cd_Categoria) REFERENCES tbl_Categoria(cd_Categoria),
	FOREIGN KEY (cd_Editora) REFERENCES tbl_Editora(cd_Editora),
);

--TABLE pedido
CREATE TABLE tbl_Pedido(
	cd_Pedido INT PRIMARY KEY,
	dt_Pedido DATE NOT NULL,
	vl_TotalPedido DECIMAL(10,2),
	cd_Atendente INT,
	cd_Cliente INT,
	cd_Pgto INT,
	FOREIGN KEY (cd_Atendente) REFERENCES tbl_Atendente(cd_Atendente),
	FOREIGN KEY (cd_Cliente) REFERENCES tbl_Cliente(cd_Cliente),
	FOREIGN KEY (cd_Pgto) REFERENCES tbl_Pagamento(cd_Pgto)
);

--TABLE ITENSPEDIDO
CREATE TABLE tbl_ItensPedido(
	cd_Livro INT,
	cd_Pedido INT
	PRIMARY KEY(cd_Livro, cd_Pedido)
	FOREIGN KEY(cd_Livro) REFERENCES tbl_Livro(cd_Livro),
	FOREIGN KEY(cd_Pedido) REFERENCES tbl_Pedido(cd_Pedido)
)

--TABELA AUTOR
CREATE TABLE tbl_Autor(
	cd_Autor INT PRIMARY KEY IDENTITY,
	nm_Autor VARCHAR(60)
);

--TABLE AUTORLIVRO
CREATE TABLE tbl_AutorLivro(
	cd_Autor INT,
	cd_Livro INT
	PRIMARY KEY (cd_Autor, cd_Livro)
	FOREIGN KEY (cd_Autor) REFERENCES tbl_Autor(cd_Autor),
	FOREIGN KEY (cd_Livro) REFERENCES tbl_Livro(cd_Livro)
)