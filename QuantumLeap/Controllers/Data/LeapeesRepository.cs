using Dapper;
using QuantumLeap.Modals;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace QuantumLeap.Data
{
    public class LeapeesRepository
    {
        const string ConnectionString = "Server = localhost; Database = QuantumLeap; Trusted_Connection = True;";

        public List<Leapees> GetAllLeapees()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                List<Leapees> leapees = db.Query<Leapees>("select * from leapees").ToList();

                return leapees;
            }
        }
    }
}
