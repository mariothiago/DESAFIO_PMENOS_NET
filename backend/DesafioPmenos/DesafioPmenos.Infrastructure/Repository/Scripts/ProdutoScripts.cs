namespace DesafioPmenos.Infrastructure.Repository.Scripts
{
    public class ProdutoScripts
    {
        internal static string Table = $@"PMENOS_PRODUTOS";

        internal static string GetProductById = $@"SELECT ID_PRODUTO AS IdProduto,
                                                            PRODUTO_DESCRICAO AS DescricaoProduto,
                                                            PRECO_PRODUTO AS PrecoProduto,
                                                            XXXX_DH_ALT AS DataAlteracao
                                                    FROM {Table} WHERE ID_PRODUTO = @IdProduto";

        internal static string CreateProduct = $@"INSERT INTO {Table} (
	                                                        PRODUTO_DESCRICAO,
	                                                        PRECO_PRODUTO,
	                                                        XXXX_DH_ALT
                                                        ) VALUES (
	                                                        @DescricaoProduto,
	                                                        @PrecoProduto,
	                                                        GETDATE()
                                                        )";

        internal static string UpdateProduct = $@"UPDATE {Table} SET
                                                    PRODUTO_DESCRICAO = @DescricaoProduto,
                                                    PRECO_PRODUTO = @PrecoProduto,
                                                    XXXX_DH_ALT = GETDATE()
                                                    WHERE ID_PRODUTO = @IdProduto";

        internal static string DeleteProduct = $@"DELETE FROM {Table} 
                                                  WHERE ID_PRODUTO = @IdProduto";
    }
}
