using System;

namespace MiniProfiler.Contrib.Results.Database
{
    internal class MiniProfilerDto
    {
        public int RowId { get; set; }
        public string Id { get; set; }
        public string RootTimingId { get; set; }
        public string Name { get; set; }
        public DateTime Started { get; set; }
        public decimal DurationMilliseconds { get; set; }
        public string User { get; set; }
        public bool HasUserViewed { get; set; }
        public string MachineName { get; set; }
        public string CustomLinksJson { get; set; }
        public int? ClientTimingsRedirectCount { get; set; }
    }
}
