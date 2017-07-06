using Fazendas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Fazendas.Persistencia
{
    public class DBUsuario : DBBroker.Engine.DBBroker<Usuario>
    {
        public static Usuario ValidaLogin(string login, string senha)
        {
            var paramentros = new List<DbParameter>()
            {
                new SqlParameter("@Login", login),
                new SqlParameter("@Senha", senha)
            };

            return ExecCmdSQL("SELECT * FROM Usuario WHERE Login = @Login AND Senha = @Senha ", parameters: paramentros).FirstOrDefault();

        }
    }
}