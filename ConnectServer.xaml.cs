using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DSVN
{
    /// <summary>
    /// Логика взаимодействия для ConnectServer.xaml
    /// </summary>
    public partial class ConnectServer : Window
    {
        public string IP_address;
        public int Port;
        public string Login;
        public string Password;
        public bool OK = false;
        public string Path;
        public ConnectServer()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            IP_address = textBoxIP.Text;
            int.TryParse(textBoxPort.Text, out Port);
            Login = textBoxLogin.Text;
            Password = passwordBox.Password;
            OK = true;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            OK=false;
            this.Close();
        }

        private void ButtonSelectPath_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //System.Windows.MessageBox.Show(FBD.SelectedPath);
                textBoxPathDirectory.Text = FBD.SelectedPath;
                Path = textBoxPathDirectory.Text;
            }
        }
    }
}
