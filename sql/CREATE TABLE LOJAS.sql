CREATE TABLE PMENOS_DESAFIO.dbo.PMENOS_LOJAS(
	ID_LOJA INT NOT NULL IDENTITY(1, 1),
	UF VARCHAR(2) NOT NULL,
	CIDADE VARCHAR (50) NOT NULL,
	LOGRADOURO VARCHAR (MAX) NOT NULL,
	CONSTRAINT PM_ID_LOJA_PK PRIMARY KEY (ID_LOJA)
)
