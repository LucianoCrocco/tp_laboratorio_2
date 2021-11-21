using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PilotoBDD
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private List<Piloto> pilotosBDD;
        private string servidor;
        private string connectionStr;

        public PilotoBDD(string servidor)
        {
            this.servidor = servidor;
            this.connectionStr = $"Data Source={servidor};Initial Catalog=PilotosDataBase;Integrated Security=True";
            this.sqlConnection = new SqlConnection(this.connectionStr);
            this.sqlCommand = new SqlCommand();
            this.sqlCommand.CommandType = System.Data.CommandType.Text;
            this.sqlCommand.Connection = this.sqlConnection;
        }


        public void GuardarListaPilotos(List<Piloto> pilotos) {
            if(pilotos is not null)
            {

            }
        }
    }
}
