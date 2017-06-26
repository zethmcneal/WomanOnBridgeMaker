using System;
using System.Collections.ObjectModel;

namespace StoryNavigationHelper
{
	public class StoryManager
	{
		private JavaScriptFileBuilder javaScriptFileBuilder;
		private ObservableCollection<ConversationEditorViewModel> openDocuments;

		public ReadOnlyObservableCollection<ConversationEditorViewModel> OpenDocuments { get; }

		public StoryManager(JavaScriptFileBuilder javaScriptFileBuilder)
		{
			this.javaScriptFileBuilder = javaScriptFileBuilder;

			this.openDocuments = new ObservableCollection<ConversationEditorViewModel>();
			this.OpenDocuments = new ReadOnlyObservableCollection<ConversationEditorViewModel>(this.openDocuments);
		}

		public void SaveAllDocuments()
		{
			//TODO: Save all the documentss
		}

		public void Close()
		{
			foreach (ConversationEditorViewModel vm in openDocuments)
			{
				vm.Close();
			}
		}
	}
}
