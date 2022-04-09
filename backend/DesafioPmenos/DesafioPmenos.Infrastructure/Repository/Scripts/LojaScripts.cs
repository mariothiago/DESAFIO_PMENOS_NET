using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPmenos.Infrastructure.Repository.Scripts
{
    public class LojaScripts
    {
        internal static string Table = $@"PMENOS_LOJAS";

        internal static string GetLojaById = $@"SELECT ID_LOJA AS IdLoja,
                                                            CIDADE AS Cidade,
                                                            UF AS UF,
                                                            LOGRADOURO AS Logradouro,
                                                            XXXX_DH_ALT AS DataAlteracao
                                                    FROM {Table} WHERE ID_LOJA = @IdLoja";

        internal static string GetAllLojas = $@"SELECT ID_LOJA AS IdLoja,
                                                            CIDADE AS Cidade,
                                                            UF AS UF,
                                                            LOGRADOURO AS Logradouro,
                                                            XXXX_DH_ALT AS DataAlteracao
                                                       FROM {Table}";

        internal static string CreateLoja = $@"INSERT INTO {Table} (
	                                                        UF,
	                                                        CIDADE,
	                                                        LOGRADOURO,
                                                            XXXX_DH_ALT
                                                        ) VALUES (
	                                                        @UF,
	                                                        @Cidade,
                                                            @Logradouro,
	                                                        GETDATE()
                                                        )";

        internal static string UpdateLoja = $@"UPDATE {Table} SET
                                                    UF = @UF,
                                                    CIDADE = @Cidade,
                                                    LOGRADOURO = @Logradouro,
                                                    XXXX_DH_ALT = GETDATE()
                                                    WHERE ID_LOJA = @IdLoja";

        internal static string DeleteLoja = $@"DELETE FROM {Table} 
                                                  WHERE ID_LOJA = @IdLoja";
    }
}
