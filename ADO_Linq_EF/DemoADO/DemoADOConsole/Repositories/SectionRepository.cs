using DemoADOConsole.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace DemoADOConsole.Repositories
{
    public class SectionRepository
    {
        private readonly DbConnection _Connection;

        public SectionRepository(DbConnection sqlConnection)
        {
            this._Connection = sqlConnection;
        }

        public List<Section> GetAllSections()
        {
            string query = "SELECT Id, SectionName FROM section;";
            List<Section> sections = new List<Section>();

            //using(DbCommand command = new SqlCommand(query, _Connection))
            //{
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            Section s = new Section((int)reader["Id"], (string)reader["SectionName"]);
            //            sections.Add(s);
            //        }
            //    }
            //}

            return sections;
        }

        public Section? GetSectionById(int id)
        {
            Section section = null;
            string query = "SELECT Id, SectionName FROM section WHERE Id = @id;";

            //using (SqlCommand command = new SqlCommand(query, this._Connection))
            //{
            //    SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int);
            //    paramId.Value = id;
            //    command.Parameters.Add(paramId);

            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            section = new Section((int)reader["Id"], (string)reader["SectionName"]);
            //        }
            //    }
            //}

            return section;
        }
    }
}
