﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Reflection;

namespace CsRSS
{


    public partial class Form1 : Form
    {
        FileStream fs;

        public Form1()
        {
            InitializeComponent();

            LoadList();

            if (URLcomboBox.Items.Count > 0)
            {
                URLcomboBox.SelectedIndex = 0;
            }
        }

        String[,] rssData = null;

        private bool DelBetween(ref string strSource, string strStart, string strEnd)
        {
            try
            {
                int Start, End;
                if (strSource.Contains(strStart) && strSource.Contains(strEnd))
                {
                    Start = strSource.IndexOf(strStart, 0);
                    End = strSource.IndexOf(strEnd, Start) + strEnd.Length;

                    strSource = strSource.Remove(Start, End - Start);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd: " + exc.Message);
                return false;
            }
        }

        private String[,] getRssData(String url)
        {

            String[,] tempRssData = new String[1000, 3];

            try
            {


                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(url);
                System.Net.WebResponse myResponse = myRequest.GetResponse();

                System.IO.Stream rssStream = myResponse.GetResponseStream();
                System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

                rssDoc.Load(rssStream);



                System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");




                for (int i = 0; i < rssItems.Count; i++)
                {
                    System.Xml.XmlNode rssNode;

                    rssNode = rssItems.Item(i).SelectSingleNode("title");
                    if (rssNode != null)
                    {
                        tempRssData[i, 0] = rssNode.InnerText;
                    }
                    else
                    {
                        tempRssData[i, 0] = "";
                    }

                    rssNode = rssItems.Item(i).SelectSingleNode("description");
                    if (rssNode != null)
                    {
                        tempRssData[i, 1] = rssNode.InnerText;

                        int j = 0;
                        do
                        {

                            DelBetween(ref tempRssData[i, 1], "<a", "/a>");
                            DelBetween(ref tempRssData[i, 1], "&", "; ");

                            
                            if (tempRssData[i, 1][j] == '<')
                            {
                                int count = 0;
                                do
                                {
                                    count++;
                                } while (tempRssData[i, 1][j + count - 1] != '>');

                                tempRssData[i, 1] = tempRssData[i, 1].Remove(j, count);

                                j = -1;
                            }

                            j++;
                        } while (j < tempRssData[i, 1].Length);

                        tempRssData[i, 1] = tempRssData[i, 1].Trim();
                    }
                    else
                    {
                        tempRssData[i, 1] = "";
                    }

                    rssNode = rssItems.Item(i).SelectSingleNode("link");
                    if (rssNode != null)
                    {
                        tempRssData[i, 2] = rssNode.InnerText;
                    }
                    else
                    {
                        tempRssData[i, 2] = "";
                    }

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd: " + exc.Message.ToString());
            }

            return tempRssData;

        }

        private void buttonURL_Click(object sender, EventArgs e)
        {
            TitlescomboBox.Items.Clear();

            rssData = getRssData(URLcomboBox.GetItemText(URLcomboBox.SelectedItem));

            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    TitlescomboBox.Items.Add(rssData[i, 0]);
                }
            }

            if (TitlescomboBox.Items.Count > 0)
                TitlescomboBox.SelectedIndex = 0;

        }

        private void TitlescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[TitlescomboBox.SelectedIndex, 1] != null)
            {
                DescriptiontextBox.Text = rssData[TitlescomboBox.SelectedIndex, 1];
            }
        }

        private void buttonGoTo_Click(object sender, EventArgs e)
        {
            try
            {
                if (rssData[TitlescomboBox.SelectedIndex, 2] != null)
                {
                    System.Diagnostics.Process.Start(rssData[TitlescomboBox.SelectedIndex, 2]);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd: " + exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Url Form_Add_Url = new Add_Url();

            Form_Add_Url.EventActivateParent += new EventHandler(Activate);
            Form_Add_Url.Show();
            this.Enabled = false;
        }

        private void LoadList()
        {
            try
            {
                using (fs = File.Open("url_rss_list.txt", FileMode.Open, FileAccess.Read))
                {

                    int numBytesToRead = (int)fs.Length;

                    byte[] artemp = new byte[1];
                    UTF8Encoding tempen = new UTF8Encoding(true);
                    String temp = null;

                    URLcomboBox.Items.Clear();

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

                            URLcomboBox.Items.Add(temp);
                            temp = null;
                        }
                    }

                }
            }
            catch (Exception exc)
            {

                if (exc is System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Błąd: " + exc.Message + "\nPo dodaniu kanału zostanie stworzony nowy plik");
                }
                else
                {
                    MessageBox.Show("Błąd: " + exc.Message);
                }

            }
        }

        private void Activate(object sender, EventArgs e)
        {
            LoadList();
            this.Enabled = true;
        }


    }
}
