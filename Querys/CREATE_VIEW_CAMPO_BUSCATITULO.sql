use db_Livraria
go

CREATE VIEW vw_PorTitulo
AS
select	
	tbl_Livro.cd_Livro,
	tbl_Livro.nm_Livro,
	tbl_Livro.no_Paginas,
	tbl_Livro.vl_Livro,
	tbl_Livro.qt_Estoque,
	tbl_Livro.no_Isbn,
	tbl_Livro.dt_AnoPublica,
	tbl_Livro.cd_Categoria,
	tbl_Livro.cd_Editora,
	tbl_Categoria.nm_Categoria,
	tbl_Editora.nm_Editora
from tbl_Livro  
inner join tbl_Categoria on tbl_Categoria.cd_Categoria = tbl_Livro.cd_Categoria
inner join tbl_Editora  on tbl_Editora.cd_Editora = tbl_Livro.cd_Editora

