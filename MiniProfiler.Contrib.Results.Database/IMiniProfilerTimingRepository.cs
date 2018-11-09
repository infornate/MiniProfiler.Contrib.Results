using System.Collections.Generic;

namespace MiniProfiler.Contrib.Results.Database
{
    internal interface IMiniProfilerTimingRepository
    {
        IReadOnlyCollection<MiniProfilerTiming> FindAll();
    }
}
