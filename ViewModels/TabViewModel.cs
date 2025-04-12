using Emperor_File_Explorer.Models;
using System.Collections.ObjectModel;
using System.IO;

namespace Emperor_File_Explorer.ViewModels
{
    public class TabViewModel
    {
        public ObservableCollection<ExplorerItem> Items { get; set; } = new ObservableCollection<ExplorerItem>();

        private string _currentPath;
        public string CurrentPath
        {
            get => _currentPath;
            set
            {
                _currentPath = value;
                LoadItems(_currentPath);
            }
        }

        public TabViewModel()
        {
            CurrentPath = "C:\\"; // Starting path
        }

        private void LoadItems(string path)
        {
            Items.Clear();

            // Folders
            foreach (var dir in Directory.GetDirectories(path))
            {
                var dirInfo = new DirectoryInfo(dir);
                Items.Add(new ExplorerItem
                {
                    Name = dirInfo.Name,
                    Path = dirInfo.FullName,
                    Type = "Folder"
                });
            }

            // Files
            foreach (var file in Directory.GetFiles(path))
            {
                var fileInfo = new FileInfo(file);
                Items.Add(new ExplorerItem
                {
                    Name = fileInfo.Name,
                    Path = fileInfo.FullName,
                    Type = "File",
                    Size = fileInfo.Length
                });
            }
        }
    }
}
