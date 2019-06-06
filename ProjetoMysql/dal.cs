using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoMysql
{
    class dal
    {

        private MySqlConnection conexao;

        public void cadastro(modelo mo)
        {
            string caminho = "SERVER=localhost;DATABASE=dbexemplo;UID=root;PASSWORD=;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = "INSERT INTO tbexemplo(nome,email)values('" + mo.Nome + "','" + mo.Email + "')";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);

                comandos.ExecuteNonQuery();

                conexao.Close();
            }

            catch(Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

    }
}
