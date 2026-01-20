using DemoADO.Repositories;
using DemoADOConsole.Models;
using DemoADOConsole.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace DemoADOConsole
{
    public class Program
    {

        static void Main(string[] args)
        {
            //établir un connexion
            const string connectionString = "Data Source=GOS-VDI507\\TFTIC;Initial Catalog=ADO;Integrated Security=True;Trust Server Certificate=True";
            const string providerName = "System.Data.SqlClient";
            DbProviderFactory providerFactory = DbProviderFactories.GetFactory(providerName);
            DbConnection sqlConnection;

            try
            {
                using(sqlConnection = providerFactory.CreateConnection())
                {
                    sqlConnection.ConnectionString = connectionString;

                    sqlConnection.Open();
                    Console.WriteLine("Connection establish");

                    SectionRepository sectionRepository = new SectionRepository(sqlConnection);

                    List<Section> sections = sectionRepository.GetAllSections();
                    sections.ForEach(Console.WriteLine);

                    Section? section = sectionRepository.GetSectionById(1010);
                    if (section is not null)
                    {
                        Console.WriteLine(section);
                    }
                    sqlConnection.Close();
                }

                SectionRepositoryDisconnected repositoryDisconnected = new SectionRepositoryDisconnected(sqlConnection);
                repositoryDisconnected.Get();

                foreach (DataRow row in repositoryDisconnected.Section.Rows)
                {
                    Console.WriteLine($"{row["Id"]} - {row["SectionName"]} - {row["ReceptionDate"]}");
                    if ((int)row["Id"] == 1010)
                    {
                        row.BeginEdit();
                        row["SectionName"] = "ADO .net";
                        row.EndEdit();
                    }
                }
                repositoryDisconnected.Update();

            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

        }
    }
}
