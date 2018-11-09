namespace MiniProfiler.Contrib.Results.Database
{
    internal class MiniProfilerTimingDto
    {
        public int RowId { get; set; }
        public string Id { get; set; }
        public string MiniProfilerId { get; set; }
        public string ParentTimingId { get; set; }
        public string Name { get; set; }
        public decimal DurationMilliseconds { get; set; }
        public decimal StartMilliseconds { get; set; }
        public bool IsRoot { get; set; }
        public int Depth { get; set; }
        public string CustomTimingsJson { get; set; }
    }
}
