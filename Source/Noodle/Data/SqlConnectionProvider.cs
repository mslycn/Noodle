﻿using System.Data.SqlClient;

namespace Noodle.Data
{
    /// <summary>
    /// A sql server connection provider
    /// </summary>
    /// <remarks></remarks>
    public class SqlConnectionProvider : IConnectionProvider
    {
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlConnectionProvider"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <remarks></remarks>
        public SqlConnectionProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Gets the db connection.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public System.Data.IDbConnection GetDbConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public System.Data.IDbConnection GetDbConnection(string name, bool throwErrorIfMissing = false)
        {
            return GetDbConnection();
        }

        /// <summary>
        /// Gets a value indicating whether this instance can open close.
        /// </summary>
        /// <remarks></remarks>
        public bool CanOpenClose
        {
            get
            {
                return true;
            }
        }
    }
}
