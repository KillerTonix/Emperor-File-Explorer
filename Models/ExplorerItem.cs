using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emperor_File_Explorer.Models
{
    public class ExplorerItem
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; } // "File" or "Folder"
        public long? Size { get; set; } // Size in bytes, null for folders
    }

}
