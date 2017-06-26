using System.Windows;

namespace StoryNavigationHelper
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
    {
		private StoryManager storyManager;
		private MainWindow mainWindow;

		public App()
		{
			this.storyManager = new StoryManager(new JavaScriptFileBuilder());
		}

		private void Application_Startup(object sender, StartupEventArgs e)
		{
			mainWindow = new MainWindow(new MainWindowViewModel(this.storyManager));
			Application.Current.MainWindow = mainWindow;

			mainWindow.Show();
		}

		private void Application_Exit(object sender, ExitEventArgs e)
		{
			this.storyManager.Close();
			this.mainWindow.Close();
		}
	}
}
