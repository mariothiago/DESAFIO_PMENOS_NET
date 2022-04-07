namespace DesafioPmenos.Infrastructure.Repository.Scripts
{
    public class ProdutoScripts
    {
        internal static string GetProductById = $@"SELECT ID_PRODUTO AS IdProduto,
                                                            PRODUTO_DESCRICAO AS DescricaoProduto,
                                                            PRECO AS PrecoProduto,
                                                            XXXX_DH_ALT AS DataAlteracao 
                                                    FROM PMENOS_PRODUTOS WHERE ID_PRODUTO = @Id";
    }
}
