using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository.Scripts
{
    public class ClienteScripts
    {
        internal static string Table = "PMENOS_CLIENTE";

        internal static string GetById = $@"SELECT CLI.NOME_CLIENTE AS Nome,
		                                            CLI.ID_CLIENTE AS IdCliente,
		                                            CLI.XXXX_DH_ALT AS DataAlteracao,
                                                    CLI.ID_DESCONTO AS IdDesconto,
                                            (SELECT DS.TIPO_DESCONTO AS TipoDesconto FROM PMENOS_DESCONTO DS
                                            WHERE DS.ID_DESCONTO = CLI.ID_DESCONTO)
                                            FROM PMENOS_CLIENTE AS CLI WHERE CLI.ID_CLIENTE = @IdCliente";

        internal static string Create = $@"INSERT INTO {Table} (
                                                NOME_CLIENTE,
                                                XXXX_DH_ALT,
                                                ID_DESCONTO
                                           ) VALUES (
                                                @Nome,
                                                GETDATE(),
                                                @IdDesconto)";

        internal static string Update = $@"UPDATE {Table} SET
                                                    NOME_CLIENTE = @Nome,
                                                    XXXX_DH_ALT = GETDATE(),
                                                    ID_DESCONTO = @IdDesconto
                                                    WHERE ID_CLIENTE = @IdCliente";

        internal static string Delete = $@"DELETE FROM {Table} WHERE ID_CLIENTE = @IdCliente";
    }
}
