using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryNavigationHelper
{
	public abstract class ObservableObject : INotifyPropertyChanged
	{
		public bool CompareValues(object original, object newValue)
		{
			return Equals(original, newValue);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void RaisePropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
