using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> people = new List<Person>();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            izveidotxml();
            nolasitxml();

           
        }

        private void nolasitxml()
        {
            string path = Application.StartupPath;
            ///////////////////////////////////////////////////////personu nolasišana
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\adrešu gramatiņa\\settings.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("People/Person"))
            {
                Person p = new Person();
                p.Name = xNode.SelectSingleNode("Name").InnerText;
                p.Email = xNode.SelectSingleNode("Email").InnerText;
                p.StreetAddress = xNode.SelectSingleNode("Address").InnerText;
                p.AdditionNotes = xNode.SelectSingleNode("Notes").InnerText;
                p.Birthday = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("Birthday").InnerText));
                people.Add(p);
                lwKlienti.Items.Add(p.Name);

            }
        }

        private void izveidotxml()
        {
            string path = Application.StartupPath;
            if (!Directory.Exists(path + "\\adrešu gramatiņa"))
                Directory.CreateDirectory(path + "\\adrešu gramatiņa");
            if (!File.Exists(path + "\\adrešu gramatiņa\\settings.xml"))
            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\adrešu gramatiņa\\settings.xml", Encoding.UTF8);
                xW.WriteStartElement("People");
                xW.WriteEndElement();
                xW.Close();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pievienotPersonu();
        }

        private void pievienotPersonu()
        {
            Person p = new Person();
            p.Name = txtFullName.Text;
            p.Email = txtEmail.Text;
            p.StreetAddress = txtFullName.Text;
            p.Birthday = dtpDOB.Value;
            p.AdditionNotes = txtNotes.Text;

            people.Add(p);
            lwKlienti.Items.Add(p.Name);
            txtAdrese.Text = "";
            txtEmail.Text = "";
            txtFullName.Text = "";
            txtNotes.Text = "";
            dtpDOB.Value = DateTime.Now;
        }

        private void lwKlienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtFullName.Text = people[lwKlienti.SelectedItems[0].Index].Name;
                txtEmail.Text = people[lwKlienti.SelectedItems[0].Index].Email;
                txtAdrese.Text = people[lwKlienti.SelectedItems[0].Index].StreetAddress;
                txtNotes.Text = people[lwKlienti.SelectedItems[0].Index].AdditionNotes;
                dtpDOB.Value = people[lwKlienti.SelectedItems[0].Index].Birthday;
            }
            catch { }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Remove();
        }
        void Remove()
        {
            try
            {
              

                people.RemoveAt(lwKlienti.SelectedItems[0].Index);

                lwKlienti.Items.Remove(lwKlienti.SelectedItems[0]);

                txtAdrese.Text = "";
                txtEmail.Text = "";
                txtFullName.Text = "";
                txtNotes.Text = "";
                dtpDOB.Value = DateTime.Now;
               
            }
            catch { }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tsmRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                people[lwKlienti.SelectedItems[0].Index].Name = txtFullName.Text;
                people[lwKlienti.SelectedItems[0].Index].Email = txtEmail.Text;
                people[lwKlienti.SelectedItems[0].Index].AdditionNotes = txtNotes.Text;
                people[lwKlienti.SelectedItems[0].Index].StreetAddress = txtAdrese.Text;
                people[lwKlienti.SelectedItems[0].Index].Birthday = dtpDOB.Value;
                lwKlienti.SelectedItems[0].Text = txtFullName.Text;
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saglabaXML();
        }

        private void saglabaXML()
        {
            XmlDocument xDoc = new XmlDocument();
            string path = Application.StartupPath;
            xDoc.Load(path + "\\adrešu gramatiņa\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("People");
            xNode.RemoveAll();
            foreach (Person p in people)
            {
                XmlNode xTop = xDoc.CreateElement("Person"); // satures visus datus par klientiem
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xAddress = xDoc.CreateElement("Address");
                XmlNode xNotes = xDoc.CreateElement("Notes");
                XmlNode xBirthday = xDoc.CreateElement("Birthday");
                xName.InnerText = p.Name;
                xEmail.InnerText = p.Email;
                xNotes.InnerText = p.AdditionNotes;
                xAddress.InnerText = p.StreetAddress;
                xBirthday.InnerText = p.Birthday.ToFileTime().ToString();
                xTop.AppendChild(xName);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xAddress);
                xTop.AppendChild(xBirthday);
                xTop.AppendChild(xNotes);
                xDoc.DocumentElement.AppendChild(xTop);
            }
            xDoc.Save(path + "\\adrešu gramatiņa\\settings.xml");
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saglabaXML();
            //this.Visible = false;
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
            this.Visible = true;
        }
    }
    class Person {
        public string Name
        {
            get;
            set;     
        }
        public string Email
        {
            get;
            set;
        }
        public string StreetAddress
        {
            get;
            set;
        }
        public string AdditionNotes
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
    }
}
