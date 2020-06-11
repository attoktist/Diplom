using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Security;
using SVN;

namespace DSVN
{
   


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Server> servers;
        private List<Client> clients;
        private Server server;
        private Client client;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_NewDirectory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateNewDirectory CND = new CreateNewDirectory();
                CND.ShowDialog();
                string path = CND.Path;
                int port = int.Parse(CND.textBoxPort.Text);
                server = new Server(path, port,0);
            }
            catch(Exception er)
            {
                System.Windows.MessageBox.Show(er.Message);
            }
            
        }

        private void MenuItem_ConnectServer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectServer CS = new ConnectServer();
                CS.ShowDialog();
                string message = CS.Login + "@" + CS.Password;
                client = new Client(CS.IP_address,CS.Port,CS.Login,CS.Password, CS.Path);
            }
            catch (Exception er)
            {
                System.Windows.MessageBox.Show(er.Message);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            UserSettingsForm CS = new UserSettingsForm();            
            CS.ShowDialog();
        }

        private void MenuItem_UserSettings_Click(object sender, RoutedEventArgs e)
        {
            client.SetCommand("UserSettingsGet");
            string us = File.read_file("US.txt");
            //Расшифровываем userlist
            AES aes = new AES("key.txt");
            us = aes.EncodeCFB(us, "IV.txt", 16, true);
            UserSettingsForm CS = new UserSettingsForm();
            string[] s = us.Split(new char[2] { '\r', '\n' });
            Regex regex = new Regex(@"[0-9]+|[a-z]+");
            for (int j = 0; j < s.Length; j++)
            {
                s[j] = s[j].TrimEnd();
                if (s[j] != "")
                {
                    MatchCollection matches = regex.Matches(s[j]);
                   // for (int i = 0; i < matches.Count; i += 4)
                    //{
                        CS.dataGridViewUserList.Rows.Add(matches[0], matches[1], matches[2], matches[3].ToString());
                  //  }
                }
            }
            CS.ShowDialog();
            if(CS.settings==true)
            {
                client.SetCommand("UserSettingsSet");
                CS.settings = false;
            }
        }

        private void MenuItem_AddNewVersion_Click(object sender, RoutedEventArgs e)
        {
            SendDataForm SDF = new SendDataForm(client.Path+"/LocalDirectory");
            SDF.ShowDialog();           

            if(SDF.OK)
            {
                client.SetCommand("SendVersion");
                SendRecIsChecked(SDF.lf);
            }
        }

        public void SendRecIsChecked(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Type == "Directory")
                {
                    if(item.IsChecked) client.SetCommand("SendFile", item.Type + "|" + item.Path);
                    SendRecIsChecked((List<Item>)item.Items);
                }
                else if (item.IsChecked) client.SetCommand("SendFile", item.Type + "|" + item.Path);
            }
        }

        private void MenuItem_GetFiles_Click(object sender, RoutedEventArgs e)
        {
            RecvDataForm RDF = new RecvDataForm(server.Path);
            RDF.ShowDialog();

            if (RDF.OK)
            {
                //client.SetCommand("SendVersion");
                RecvRecIsChecked(RDF.lf);
            }
        }

        public void RecvRecIsChecked(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Type == "Directory")
                {
                  //  if (item.IsChecked) server.Handler("RecvFile", item.Type + "|" + item.Path);
                    RecvRecIsChecked((List<Item>)item.Items);
                }
               // else if (item.IsChecked) server.Handler("RecvFile", item.Type + "|" + item.Path);
            }
        }
    }
}
