using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSVN
{
    public class Item
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public bool IsChecked { get; set; }
        public IEnumerable<object> Items { get; internal set; } = null;
    }

    public class FileItem : Item
    {

    }

    public class DirectoryItem : Item
    {
       // public List<Item> Items { get; set; }

        public DirectoryItem()
        {
            Items = new List<Item>();
        }
    }
}
