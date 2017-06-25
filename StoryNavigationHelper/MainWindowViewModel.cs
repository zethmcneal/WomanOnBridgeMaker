using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StoryNavigationHelper
{
	public class MainWindowViewModel
	{

		#region Commands

		private ICommand saveAllCommand;
		private ICommand buildProjectCommand;
		private ICommand newConversationCommand;
		private ICommand exitCommand;

		public ICommand SaveAll
		{
			get
			{
				if (saveAllCommand == null)
				{
					saveAllCommand = new DelegateCommand(o => { });
				}

				return saveAllCommand;
			}
		}

		public ICommand BuildProject
		{
			get
			{
				if (buildProjectCommand == null)
				{
					buildProjectCommand = new DelegateCommand(o => { });
				}

				return buildProjectCommand;
			}
		}

		public ICommand NewConversation
		{
			get
			{
				if (newConversationCommand == null)
				{
					newConversationCommand = new DelegateCommand(o =>
					{
						Window w = new Window();
						w.Owner = Application.Current.MainWindow;
						w.WindowStartupLocation = WindowStartupLocation.CenterOwner;
						w.Content = new ConversationEditor();

						w.Show();
					});
				}

				return newConversationCommand;
			}
		}

		public ICommand ExitCommand
		{
			get
			{
				if (exitCommand == null)
				{
					exitCommand = new DelegateCommand(o => { });
				}

				return exitCommand;
			}
		}

		#endregion Commands

	}
}
