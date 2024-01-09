using FacebookClone.DAL;
using FileLoggingLib;
using Microsoft.Extensions.Logging;

namespace FacebookCloneWinForms
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (AskForReset())
			{
				if (!DataProvider.TryReset())
				{
					FileLogger.Logger.Error("Cannot reset");
					return;
				}
				FileLogger.Logger.Info("Done reseting");
			}

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			FileLogger.Logger.Info("Begining to run application");
			Application.Run(new LoginForm_());
			FileLogger.Logger.Info("Stopped application");
			FileLogger.Logger.Info("");
		}

		private static bool AskForReset()
		{
			var result = MessageBox.Show(
				"Do you want to reset the database? (This dialog is kept for development only.)", "Reset?",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button1);
			return result == DialogResult.Yes;
		}
	}
}