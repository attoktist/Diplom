using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Forms;
using System.IO;
using Security;

namespace DSVN
{
    /// <summary>
    /// Логика взаимодействия для CreateNewDirectory.xaml
    /// </summary>
    public partial class CreateNewDirectory : Window
    {
        public string Path;
        public CreateNewDirectory()
        {
            InitializeComponent();
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

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            string login="", password="";
            if ((textBoxLogin.Text == "") || (textBoxLogin.Text == null) || (textBoxLogin.Text == string.Empty) ||
                (textBoxPassword.Text == "") || (textBoxPassword.Text == null) || (textBoxPassword.Text == string.Empty))
            {
                System.Windows.MessageBox.Show("Ошибка. Логин или пароль отсутствуют.");
            }
            else
            {
                login = textBoxLogin.Text.ToString();
                password = textBoxPassword.Text.ToString();
            }

            if((textBoxPathDirectory.Text== null)|| (textBoxPathDirectory.Text == "")|| (textBoxPathDirectory.Text == string.Empty))
            {
                System.Windows.MessageBox.Show("Ошибка. Не выбран путь к директории.");
            }

            string UsersList = "1@" + login + "@" + password + "@" + "admin\r\n";
            AES aes = new AES("key.txt");
            UsersList = aes.EncodeCFB(UsersList, "IV.txt", 16);
            SVN.File.save_file(textBoxPathDirectory.Text,"UserList.txt", UsersList);

            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
