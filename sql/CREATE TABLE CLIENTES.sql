CREATE TABLE PMENOS_CLIENTE(
	ID_CLIENTE INT NOT NULL IDENTITY(1,1),
	NOME_CLIENTE VARCHAR(MAX) NOT NULL,
	XXXX_DH_ALT DATETIME DEFAULT GETDATE() NOT NULL,
	CONSTRAINT CLI_ID_CLIENTE_PK PRIMARY KEY (ID_CLIENTE)
);