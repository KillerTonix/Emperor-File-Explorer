using Emperor_File_Explorer.ViewModels;
using System.Windows.Controls;

namespace EmperorFileExplorer.Views
{
    public partial class TabView : UserControl
    {
        public TabView()
        {
            InitializeComponent();
            DataContext = new TabViewModel();
        }
    }
}
