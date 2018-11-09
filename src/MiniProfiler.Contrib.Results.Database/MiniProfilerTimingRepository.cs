using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProfiler.Contrib.Results.Database
{
    internal class MiniProfilerTimingRepository : IMiniProfilerTimingRepository
    {
        private readonly IMiniProfilerTimingDao _timingDao;

        public MiniProfilerTimingRepository(IMiniProfilerTimingDao timingDao)
        {
            _timingDao = timingDao;
        }

        public IReadOnlyCollection<MiniProfilerTiming> FindAll()
        {
            return _timingDao.ReadAll().Select(MapDtoToModel).ToList();
        }

        private static MiniProfilerTiming MapDtoToModel(MiniProfilerTimingDto dto)
        {
            return new MiniProfilerTiming
            {
                RowId = dto.RowId,
                Id = Guid.Parse(dto.Id),
                MiniProfilerId = Guid.Parse(dto.MiniProfilerId),
                ParentTimingId = !string.IsNullOrWhiteSpace(dto.ParentTimingId) ? Guid.Parse(dto.ParentTimingId) : (Guid?)null,
                Name = dto.Name,
                DurationMilliseconds = dto.DurationMilliseconds,
                StartMilliseconds = dto.StartMilliseconds,
                IsRoot = dto.IsRoot,
                Depth = dto.Depth,
                CustomTimingsJson = dto.CustomTimingsJson
            };
        }
    }
}