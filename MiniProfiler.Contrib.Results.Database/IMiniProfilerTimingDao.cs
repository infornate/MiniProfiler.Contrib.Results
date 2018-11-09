using System.Collections.Generic;

namespace MiniProfiler.Contrib.Results.Database
{
    internal interface IMiniProfilerTimingDao
    {
        IEnumerable<MiniProfilerTimingDto> ReadAll();
    }
}