using NLog;
using NLog.Config;
using NLog.Targets;

namespace FileLoggingLib
{
	public static class FileLogger
	{
		public static string? FilePath = null;
		public static Logger? Logger = null;
		public static bool IsInitialized { get { return Logger is not null; } }

		public static void Initialize(string filePath)
		{
			var config = new LoggingConfiguration();
			var logFile = new FileTarget(filePath);
			config.AddRule(LogLevel.Info, LogLevel.Fatal, logFile);
			LogManager.Configuration = config;
			
			Logger = LogManager.GetCurrentClassLogger();
			FilePath = filePath;
		}
	}
}