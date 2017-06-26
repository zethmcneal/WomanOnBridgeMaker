using System;

namespace StoryNavigationHelper
{
	public class ConversationEditorViewModel : ObservableObject
	{
		private StoryManager storyManager;
		private string text;

		public String Text
		{
			get { return this.text; }
			set
			{
				if (CompareValues(this.text, value)) return;

				this.text = value;
				RaisePropertyChanged(nameof(Text));
			}
		}

		public ConversationEditorViewModel(StoryManager storyManager, string initialText = "")
		{
			this.storyManager = storyManager;
			this.Text = initialText;
		}

		public void Close()
		{
			this.storyManager.SaveAllDocuments();

			RaiseClosed();
		}

		protected void RaiseClosed()
		{
			Closed?.Invoke(this, EventArgs.Empty);
		}

		public event EventHandler Closed;
	}
}
