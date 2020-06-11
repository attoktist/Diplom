using Security;
using SVN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSVN
{
    public partial class UserSettingsForm : Form
    {
        public bool settings = false;
        public UserSettingsForm()
        {
            InitializeComponent();
        }

        private void ButtonSaveUserSettings_Click(object sender, EventArgs e)
        {
            string us = "";
            for(int i=0;i<dataGridViewUserList.Rows.Count-1;i++)
            {
                us += dataGridViewUserList.Rows[i].Cells[0].Value + "@" + dataGridViewUserList.Rows[i].Cells[1].Value + 
                    "@" + dataGridViewUserList.Rows[i].Cells[2].Value + "@" + dataGridViewUserList.Rows[i].Cells[3].Value+"\r\n";
            }

           
            AES aes = new AES("key.txt");
            us = aes.EncodeCFB(us, "IV.txt", 16);
            File.save_file(Environment.CurrentDirectory, "US.txt", us);
            settings = true;
            this.Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUserList.CurrentRow != null)
            {
                dataGridViewUserList.Rows.Remove(dataGridViewUserList.CurrentRow);
            }
        }

        private void ButtonRowsLeft_Click(object sender, EventArgs e)
        {
            int index = dataGridViewUserList.CurrentRow.Index;
            if (index == 0)
            {
                //dataGridViewUserList.Rows[index].Selected = true;
                //dataGridViewUserList.CurrentCell = dataGridViewUserList[0, index + 1];
            }
            else
            {
                dataGridViewUserList.Rows[index].Selected = true;
                dataGridViewUserList.CurrentCell = dataGridViewUserList[0, index - 1];
                int k = dataGridViewUserList.CurrentRow.Index + 1;
                textBoxNumberRows.Text = k.ToString();
            }
        }

        private void ButtonRowsRight_Click(object sender, EventArgs e)
        {
            int index = dataGridViewUserList.CurrentRow.Index;
            if (index == dataGridViewUserList.RowCount-1)
            {
                //dataGridViewUserList.Rows[index].Selected = true;
               // dataGridViewUserList.CurrentCell = dataGridViewUserList[0, index - 1];
            }
            else
            {
                dataGridViewUserList.Rows[index].Selected = true;
                dataGridViewUserList.CurrentCell = dataGridViewUserList[0, index + 1];
                int k = dataGridViewUserList.CurrentRow.Index + 1;
                textBoxNumberRows.Text = k.ToString();
            }
        }

        private void DataGridViewUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
