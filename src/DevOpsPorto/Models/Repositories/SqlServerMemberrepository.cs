using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsPorto.Models.Repositories
{
    public class SqlServerMemberRepository : IMemberRepository
    {
        readonly string _connectionString;

        public SqlServerMemberRepository(IOptions<DbConfiguration> dbOptions)
        {
            if (dbOptions == null)
                throw new ArgumentException(nameof(dbOptions));
            if (string.IsNullOrWhiteSpace(dbOptions.Value.ConnectionString))
                throw new ArgumentException("connectionsString");

            _connectionString = dbOptions.Value.ConnectionString;

        }


        public IEnumerable<Member> GetListOfMembers()
        {
            List<Member> results = new List<Member>();
            var queryText = "Select * From Member";

            using (var connection = new SqlConnection(_connectionString))
            using (var query = new SqlCommand(queryText, connection))
            {
                connection.Open();

                using (var reader = query.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Member mb = new Member(
                                Int32.Parse(reader["MemberId"].ToString()),
                                reader["MemberFirstName"].ToString(),
                                reader["MemberLastName"].ToString()
                            );

                            results.Add(mb);
                        }
                    }
                }

            }

            return results;
        }

    }
}
