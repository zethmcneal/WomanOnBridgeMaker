using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace StoryNavigationHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		private MainWindowViewModel vm;

        public MainWindow(MainWindowViewModel viewModel)
        {
			if (viewModel == null) throw new ArgumentNullException(nameof(viewModel));

            InitializeComponent();

			vm = viewModel;
			DataContext = vm;
		}
    }
}
