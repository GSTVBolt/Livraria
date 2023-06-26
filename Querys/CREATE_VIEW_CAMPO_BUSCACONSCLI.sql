use db_Livraria
go

CREATE VIEW vw_ConsCli
AS
select 
	tbl_Cliente.cd_Cliente, 
	tbl_Cliente.nm_Cliente,
	tbl_Cliente.ds_Email,
	tbl_Cliente.no_CPF,
	tbl_Cliente.no_CNPJ,
	tbl_Cliente.nm_Logradouro,
	tbl_Cliente.no_Logradouro,
	tbl_Cliente.ds_Complemento,
	tbl_Cliente.nm_Bairro,
	tbl_Cliente.nm_Cidade,
	tbl_Cliente.sg_UF,
	tbl_Cliente.no_CEP,
	tbl_Cliente.ds_Status,
	tbl_Cliente.ds_Pessoa,
	tbl_Telefone.no_Telefone
from tbl_Cliente inner join tbl_Telefone
on tbl_Cliente.cd_Cliente = tbl_Telefone.cd_Cliente