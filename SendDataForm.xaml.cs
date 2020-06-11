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
using SVN;

namespace DSVN
{

   

    /// <summary>
    /// Логика взаимодействия для SendDataForm.xaml
    /// </summary>
    public partial class SendDataForm : Window
    {
        private string Path;
        public List<Item> lf;
        public bool OK = false;
        
        public SendDataForm(string path)
        {
            InitializeComponent();
            Path = path;
            
            var ListFiles = GetItems(Path);
            lf = new List<Item>(ListFiles);
            DataContext = ListFiles;
            
        }
               
        public List<Item> GetItems(string path)
        {
            var items = new List<Item>();

            var dirInfo = new DirectoryInfo(path);

            foreach (var directory in dirInfo.GetDirectories())
            {
                var item = new DirectoryItem
                {
                    Name = directory.Name,
                    Path = directory.FullName,
                    Type = "Directory",
                    Items = GetItems(directory.FullName)
                };

                items.Add(item);
            }

            foreach (var file in dirInfo.GetFiles())
            {
                var item = new FileItem
                {
                    Name = file.Name,
                    Type = "File",
                    Path = file.FullName
                };

                items.Add(item);
            }

            return items;
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            lf = (List<Item>)treeViewLocal.Items.SourceCollection;
            OK = true;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            OK = false;
            this.Close();
        }
    }
}
