using System;

namespace MiniProfiler.Contrib.Results
{
    public class MiniProfilerTiming
    {
        public int RowId { get; set; }
        public Guid Id { get; set; }
        public Guid MiniProfilerId { get; set; }
        public Guid? ParentTimingId { get; set; }
        public string Name { get; set; }
        public decimal DurationMilliseconds { get; set; }
        public decimal StartMilliseconds { get; set; }
        public bool IsRoot { get; set; }
        public int Depth { get; set; }
        public string CustomTimingsJson { get; set; }
    }
}
