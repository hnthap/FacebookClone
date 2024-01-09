using Microsoft.Extensions.Logging;

namespace FileLogger
{
	public class FileLogger : ILogger
	{
		private string _filePath;
		private static object _lock = new();
		
		public FileLogger(string filePath)
		{
			_filePath = filePath;
		}

		public IDisposable BeginScope<TState>(TState state)
		{
			return null;
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			return true;
		}
	}
}