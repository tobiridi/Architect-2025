using ExoMVC.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace ExoMVC.Repositories
{
    public class PatientRepository
    {
        private SqlConnection _connection;

        public PatientRepository()
        {
            try
            {
                const string connectionString = "Data Source=GOS-VDI507\\TFTIC;Initial Catalog=ExoMVC;Integrated Security=True;Trust Server Certificate=True";
                this._connection = new SqlConnection(connectionString);
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public Patient Create(string regNat, string lastname, string firstname, string phone, DateOnly birthDate)
        {
            Patient newPatient;
            this._connection.Open();
            using (SqlCommand command = this._connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO [Patients] VALUES " +
                    "(@regNat, @lastname, @firstname, @phone, @birthDate)";

                command.Parameters.Add(new SqlParameter("@regNat", regNat));
                command.Parameters.Add(new SqlParameter("@lastname", lastname));
                command.Parameters.Add(new SqlParameter("@firstname", firstname));
                command.Parameters.Add(new SqlParameter("@phone", phone));
                command.Parameters.Add(new SqlParameter("@birthDate", birthDate));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    newPatient = new Patient("", "", "", "", DateOnly.FromDateTime(DateTime.Now));
                }

            }
            this._connection.Close();

            return newPatient;
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public Patient Retrieve()
        {
            throw new NotImplementedException();
        }

        public List<Patient> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
