using Dapper;
using QuantumLeap.Modals;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace QuantumLeap.Data
{
    public class LeapersRepository
    {
        const string ConnectionString = "Server = localhost; Database = QuantumLeap; Trusted_Connection = True;";

        public List<Leapers> GetAllLeapers()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                List<Leapers> leapers = db.Query<Leapers>("select * from Leapers").ToList();

                return leapers;
            }
        }
    }
}
