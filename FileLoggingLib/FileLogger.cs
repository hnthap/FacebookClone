using Microsoft.Extensions.Logging;
using NLog;
using NLog.Config;
using NLog.Targets;
using System.Security.AccessControl;

namespace FileLoggingLib
{
	public static class FileLogger
	{
		public static Logger Logger { get; private set; } = LogManager.GetCurrentClassLogger();
	}
}