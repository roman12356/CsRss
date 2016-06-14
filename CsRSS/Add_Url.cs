using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsRSS
{




    public partial class Add_Url : Form
    {

        FileStream fs;
        public event EventHandler EventActivateParent;


        public Add_Url()
        {
            InitializeComponent();

            LoadURL();
        }



        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (!URL_TextBox.Text.Contains("http://"))
            {
                URL_TextBox.Text = URL_TextBox.Text.Insert(0, "http://");
            }

            if (!URL_ListBox.Items.Contains(URL_TextBox.Text))
            {
                String temp = URL_TextBox.Text;

                temp = temp.Trim();
                URL_ListBox.Items.Add(temp);

                URL_TextBox.Text = "";
            }
            else
                MessageBox.Show(URL_TextBox.Text + " Jest już na liście");
        }


        private void Add_Url_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                using (fs = File.Open("url_rss_list.txt", FileMode.Truncate, FileAccess.Write))
                {
                    Byte[] ByteTemp = new byte[200];

                    UTF8Encoding tempUTF = new UTF8Encoding(true);


                    for (int i = 0; i < URL_ListBox.Items.Count; i++)
                    {
                        String temp = URL_ListBox.Items[i].ToString();


                        ByteTemp = new UTF8Encoding(true).GetBytes(URL_ListBox.Items[i].ToString());
                       // Byte[] ByteTempSingle = new Byte[1];

                        for (int j = 0; j < ByteTemp.Length; j++)
                        {
                            if (ByteTemp[j] > 31 && ByteTemp[j] < 127)
                            {
                                fs.WriteByte(ByteTemp[j]);
                            }
                        }
                        ByteTemp = new UTF8Encoding(true).GetBytes("\n");
                        fs.WriteByte(ByteTemp[0]);
                    }

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd: " + exc.Data.ToString());
            }

            this.EventActivateParent(this, e);


        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (URL_ListBox.Items.Count > 0)
            {
                try
                {
                    URL_ListBox.Items.RemoveAt(URL_ListBox.SelectedIndex);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Błąd: " + exc.Message);
                }
            }
        }

        private void LoadURL()
        {
            try
            {
                using (fs = File.Open("url_rss_list.txt", FileMode.OpenOrCreate, FileAccess.Read))
                {

                    int numBytesToRead = (int)fs.Length;

                    byte[] artemp = new byte[1];
                    UTF8Encoding tempen = new UTF8Encoding(true);
                    String temp = null;

                    URL_ListBox.Items.Clear();

                    for (int i = 0; i < numBytesToRead; i++)
                    {
                        fs.Read(artemp, 0, artemp.Length);
                        temp += tempen.GetString(artemp);
                        if (tempen.GetString(artemp) == "\n" || i == numBytesToRead - 1)
                        {
                            if (temp[temp.Length - 1] == '\n')
                            {
                                temp = temp.Remove(temp.Length - 1);
                            }

                            URL_ListBox.Items.Add(temp);
                            temp = null;
                        }
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd: " + exc.Message);
            }
        }

    }
}
