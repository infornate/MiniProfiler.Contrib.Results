using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace MiniProfiler.Contrib.Results.Database
{
    internal class MiniProfilerTimingDao : IMiniProfilerTimingDao
    {
        private readonly Func<IDbConnection> _getConnection;

        public MiniProfilerTimingDao(Func<IDbConnection> getConnection)
        {
            _getConnection = getConnection;
        }

        public IEnumerable<MiniProfilerTimingDto> ReadAll()
        {
            using (var connection = _getConnection())
            {
                return connection.Query<MiniProfilerTimingDto>("select * from MiniProfilerTimings");
            }   
        }
    }
}
