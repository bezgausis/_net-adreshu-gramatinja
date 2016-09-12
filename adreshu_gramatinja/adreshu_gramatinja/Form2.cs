﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {/*
            try
            {
                string path = Application.StartupPath;
                XmlDataDocument xmldata = new XmlDataDocument();
                xmldata.DataSet.ReadXml(path + "\\adrešu gramatiņa\\settings.xml");
                
                dataGridView1.DataSource = xmldata.DataSet;
                dataGridView1.DataMember = "Person";

              

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */
            try
            {
                XmlReader xmlFile;
                string path = Application.StartupPath;
                xmlFile = XmlReader.Create(path + "\\adrešu gramatiņa\\settings.xml", new XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml(xmlFile);
                dataGridView1.DataSource = ds.Tables[0];
                xmlFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

          
        }

        private void uzPDF_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomEmail();

        }

        private void randomEmail()
        {
            Random rnd = new Random();
            int r = rnd.Next(dataGridView1.RowCount);

            string str;

            str = dataGridView1.Rows[r].Cells[1].Value.ToString();
            button1.Text = str;
            dataGridView1.CurrentCell = dataGridView1.Rows[r].Cells[1];

        }
    }
}
