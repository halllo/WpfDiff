using CommandContext;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WpfDiff
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.CommandContext(DataContext = new MainWindowModel());
		}

		private void ScrollChanged(object sender, ScrollChangedEventArgs e)
		{
			var scrollViewerToUpdate = sender == this.beforeDiff ? new TextBoxBase[] { this.afterDiff, this.after, this.before } :
										sender == this.afterDiff ? new TextBoxBase[] { this.beforeDiff, this.after, this.before } :
										sender == this.before ? new TextBoxBase[] { this.beforeDiff, this.after, this.afterDiff } :
										sender == this.after ? new TextBoxBase[] { this.beforeDiff, this.afterDiff, this.before } : new TextBoxBase[0];

			scrollViewerToUpdate.ToList().ForEach(textToSync =>
			{
				textToSync.ScrollToVerticalOffset(e.VerticalOffset);
				textToSync.ScrollToHorizontalOffset(e.HorizontalOffset);
			});
		}
	}
}
