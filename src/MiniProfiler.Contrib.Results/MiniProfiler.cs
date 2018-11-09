using System;

namespace MiniProfiler.Contrib.Results
{
    public class MiniProfiler
    {
        public int RowId { get; set; }
        public Guid Id { get; set; }
        public Guid RootTimingId { get; set; }
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
