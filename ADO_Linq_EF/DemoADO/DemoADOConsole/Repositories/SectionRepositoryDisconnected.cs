using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADO.Repositories
{
    public class SectionRepositoryDisconnected
    {
        private DbConnection _connection;

        public DataTable Section { get; set; } = new DataTable();
        public DateTime? lastReception { get; private set; }

        //private DataAdapter _adapter = new DataAdapter();

        public SectionRepositoryDisconnected(DbConnection connection)
        {
            //Liaison de la connection
            _connection = connection;

            //Définition de la commande de récupération
            DbCommand selectCommand = _connection.CreateCommand();
            selectCommand.CommandText = "SELECT * FROM [Section]";

            //Définition de la commande de mise à jour
            DbCommand updateCommand = _connection.CreateCommand();
            updateCommand.CommandText = "UPDATE [Section] "
                + "SET [SectionName] = @sectionName "
                + "WHERE [Id] = @id";
            updateCommand.Parameters.Add(new SqlParameter("sectionName", SqlDbType.VarChar, 50, "SectionName"));
            updateCommand.Parameters.Add(new SqlParameter("id", SqlDbType.Int, 0, "Id"));

            DbCommand insertCommand = _connection.CreateCommand();
            updateCommand.CommandText = "INSERT INTO [Section] "
                + "[Id] = @id"
                + "[SectionName] = @sectionName";
            insertCommand.Parameters.Add(new SqlParameter("id", SqlDbType.Int, 0, "Id"));
            insertCommand.Parameters.Add(new SqlParameter("sectionName", SqlDbType.VarChar, 50, "SectionName"));

            DbCommand deleteCommand = _connection.CreateCommand();
            deleteCommand.CommandText = "DELETE FROM [Section] "
                + "WHERE [Id] = @id";
            deleteCommand.Parameters.Add(new SqlParameter("id", SqlDbType.Int, 0, "Id"));

            //Affectation des commandes à notre adapteur
            //_adapter.SelectCommand = selectCommand;
            //_adapter.UpdateCommand = updateCommand;
            //_adapter.InsertCommand = insertCommand;
            //_adapter.DeleteCommand = deleteCommand;
        }

        public void Get()
        {
            //_adapter.Fill(Section);
            lastReception = DateTime.Now;
        }

        public void Update()
        {
            //_adapter.Update(Section);
        }

        public void Insert()
        {
            //_adapter.Update(Section);
        }

        public void Delete()
        {
            //_adapter.Update(Section);
        }
    }
}