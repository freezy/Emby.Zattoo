using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Controller.Drawing;
using MediaBrowser.Controller.LiveTv;
using MediaBrowser.Model.Dto;
using MediaBrowser.Model.Logging;

namespace Emby.Zattoo
{
	public class ZattooService: ILiveTvService
	{
		public string Name { get; } = "Zattoo Live TV Service";
		public string HomePageUrl { get; } = "https://zattoo.com";

		public event EventHandler DataSourceChanged;
		public event EventHandler<RecordingStatusChangedEventArgs> RecordingStatusChanged;

		private readonly ILogger _logger;

		public ZattooService(ILogger logger)
		{
			_logger = logger;
			_logger.Info("[Zattoo] ZattooService()");
		}

		public Task<LiveTvServiceStatusInfo> GetStatusInfoAsync(CancellationToken cancellationToken)
		{
			_logger.Info("[Zattoo] ZattooService()");
			return null;
		}

		public Task<IEnumerable<ChannelInfo>> GetChannelsAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task CancelTimerAsync(string timerId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task CancelSeriesTimerAsync(string timerId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task DeleteRecordingAsync(string recordingId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task CreateTimerAsync(TimerInfo info, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task CreateSeriesTimerAsync(SeriesTimerInfo info, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task UpdateTimerAsync(TimerInfo info, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task UpdateSeriesTimerAsync(SeriesTimerInfo info, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<ImageStream> GetChannelImageAsync(string channelId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<ImageStream> GetRecordingImageAsync(string recordingId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<ImageStream> GetProgramImageAsync(string programId, string channelId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<RecordingInfo>> GetRecordingsAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<TimerInfo>> GetTimersAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<SeriesTimerInfo> GetNewTimerDefaultsAsync(CancellationToken cancellationToken, ProgramInfo program = null)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<SeriesTimerInfo>> GetSeriesTimersAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ProgramInfo>> GetProgramsAsync(string channelId, DateTime startDateUtc, DateTime endDateUtc, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<MediaSourceInfo> GetRecordingStream(string recordingId, string streamId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<MediaSourceInfo> GetChannelStream(string channelId, string streamId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<List<MediaSourceInfo>> GetChannelStreamMediaSources(string channelId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<List<MediaSourceInfo>> GetRecordingStreamMediaSources(string recordingId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task CloseLiveStream(string id, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task RecordLiveStream(string id, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task ResetTuner(string id, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
