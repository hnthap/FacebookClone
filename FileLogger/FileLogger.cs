using Microsoft.Extensions.Logging;

namespace FileLogger
{
	public class FileLogger : ILogger
	{
		private string _filepath;

		public FileLogger(string filepath)
		{
			_filepath = filepath;
		}

		public IDisposable? BeginScope<TState>(TState state)
		{
			return null;
		}

		public bool IsEnable(LogLevel logLevel)
		{
			return true;
		}

		public void Log<TState>(
			LogLevel logLevel, EventId eventId, TState state,
			Exception? exception, Func<TState, Exception?, string> formatter)
		{
			string message = formatter(state, exception);
			File.AppendAllText(_filepath, message + Environment.NewLine);
		}
	}
}