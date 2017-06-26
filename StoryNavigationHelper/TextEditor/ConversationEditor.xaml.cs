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
using System.Windows.Shapes;
using System.Xml;

namespace StoryNavigationHelper
{
	/// <summary>
	/// Interaction logic for ConversationEditor.xaml
	/// </summary>
	public partial class ConversationEditor : Window
	{
		private ConversationEditorViewModel viewModel;

		public ConversationEditor(ConversationEditorViewModel viewModel)
		{
			InitializeComponent();
			this.viewModel = viewModel;
			this.DataContext = viewModel;
			this.TextEditor.Text = viewModel.Text;
			viewModel.Closed += (sender, args) => this.Close();


			using (XmlTextReader xshd_reader = new XmlTextReader(new MemoryStream(Properties.Resources.highlighting)))
			{
				TextEditor.SyntaxHighlighting = ICSharpCode.AvalonEdit.Highlighting.Xshd.HighlightingLoader
					.Load(xshd_reader, ICSharpCode.AvalonEdit.Highlighting.HighlightingManager.Instance);
			}

			TextEditor.Focus();
		}

		private void TextEditor_TextChanged(object sender, System.EventArgs e)
		{
			this.viewModel.Text = TextEditor.Text;
		}
	}
}
