using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StoryNavigationHelper
{
	public class DelegateCommand : ICommand
	{
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}


		private Action<object> executeMethod;
		private Predicate<object> canExecuteMethod;

		public DelegateCommand(Action<object> executeMethod) : this(executeMethod, null) { }

		public DelegateCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
		{
			this.executeMethod = executeMethod;
			this.canExecuteMethod = canExecuteMethod;
		}

		public bool CanExecute(object parameter)
		{
			return canExecuteMethod != null ? canExecuteMethod(parameter) : true;
		}

		public void Execute(object parameter)
		{
			executeMethod(parameter);
		}
	}
}
