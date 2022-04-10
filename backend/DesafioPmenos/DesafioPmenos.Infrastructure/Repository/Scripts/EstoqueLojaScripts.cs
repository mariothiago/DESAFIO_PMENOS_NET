using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository.Scripts
{
    public class EstoqueLojaScripts
    {
        internal static string GetProductsByStore = $@"SELECT DISTINCT 
                                                            LJ.LOGRADOURO AS Logradouro, 
                                                            LJ.ID_LOJA AS IdLoja, 
                                                            LJ.CIDADE AS CidadeLoja, 
                                                            LJ.UF AS UFLoja,
                                                            PR.ID_PRODUTO AS IdProduto,
                                                            PR.PRODUTO_DESCRICAO AS DescricaoProduto,
                                                            PR.PRECO_PRODUTO AS PrecoProduto,
                                                            PL.XXXX_DH_ALT AS DataAlteracao
                                                            FROM PRODUTO_LOJA AS PL
                                                            JOIN PMENOS_LOJAS AS LJ ON PL.ID_LOJA = LJ.ID_LOJA
                                                            JOIN PMENOS_PRODUTOS AS PR ON PL.ID_PRODUTO = PR.ID_PRODUTO
                                                            WHERE LJ.ID_LOJA = @IdLoja";

        internal static string GetProductsInStores = $@"SELECT DISTINCT 
                                                            LJ.LOGRADOURO AS Logradouro, 
                                                            LJ.ID_LOJA AS IdLoja, 
                                                            LJ.CIDADE AS CidadeLoja, 
                                                            LJ.UF AS UFLoja,
                                                            PR.ID_PRODUTO AS IdProduto,
                                                            PR.PRODUTO_DESCRICAO AS DescricaoProduto,
                                                            PR.PRECO_PRODUTO AS PrecoProduto,
                                                            PL.XXXX_DH_ALT AS DataAlteracao
                                                            FROM PRODUTO_LOJA AS PL
                                                            JOIN PMENOS_LOJAS AS LJ ON PL.ID_LOJA = LJ.ID_LOJA
                                                            JOIN PMENOS_PRODUTOS AS PR ON PL.ID_PRODUTO = PR.ID_PRODUTO
                                                            WHERE PR.ID_PRODUTO = @IdProduto";

        internal static string InsertProductInStore = $@"INSERT INTO PRODUTO_LOJA(
	                                                                    ID_LOJA,
	                                                                    ID_PRODUTO
                                                                    ) VALUES (
	                                                                    @IdLoja,
	                                                                    @IdProduto
                                                                    )";


        internal static string DeleteProductInStore = $@"DELETE FROM PRODUTO_LOJA
                                                            WHERE ID_LOJA = @IdLoja
                                                        AND ID_PRODUTO = @IdProduto";
    }
}
