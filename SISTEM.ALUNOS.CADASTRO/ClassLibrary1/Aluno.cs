﻿using FirebirdSql.Data.FirebirdClient;

namespace CORE
{
    public class Aluno 
    {
        private const string Sql = "select * from aluno";
        #region "Atributos"
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }
        #endregion

        public FbDataReader Open(FbConnection _conn)
        {
            var cmd = new FbCommand
            {
                Connection = _conn,
                CommandText = Sql
            };
            return cmd.ExecuteReader();
        }
    }
}
