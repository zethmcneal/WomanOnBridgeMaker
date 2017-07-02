using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace StoryNavigationHelper
{
    /// <summary>
    /// Interaction logic for ChoiceEditor.xaml
    /// </summary>
    public partial class ChoiceEditor : Window
    {
        private ChoiceEditorViewModel viewModel;

        public ChoiceEditor(ChoiceEditorViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
