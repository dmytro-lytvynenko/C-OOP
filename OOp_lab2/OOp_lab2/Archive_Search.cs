using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace OOp_lab2
{
    public partial class Archive_Search : Form
    {
        string path = "Archive.xml";
        List<Archive> final = new List<Archive>();
        public Archive_Search()
        {
            InitializeComponent();
        }
        public void FillBox()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Archive.xml");
            XmlNodeList elem = doc.SelectNodes("//author");
            foreach(XmlNode e in elem)
            {
                XmlNodeList list1 = e.ChildNodes;
                foreach(XmlNode el in list1)
                {
                    string author = el.ParentNode.Attributes.GetNamedItem("AUTHOR").Value;
                    if (!comboBox1.Items.Contains(author))
                        comboBox1.Items.Add(author);
                    string material = el.Attributes.GetNamedItem("MATERIAL").Value;
                    if (!comboBox2.Items.Contains(material))
                        comboBox2.Items.Add(material);
                    string faculty = el.Attributes.GetNamedItem("FACULTY").Value;
                    if (!comboBox3.Items.Contains(faculty))
                        comboBox3.Items.Add(faculty);
                    string cathedry = el.Attributes.GetNamedItem("CATHEDRY").Value;
                    if (!comboBox4.Items.Contains(cathedry))
                        comboBox4.Items.Add(cathedry);
                    string material_type = el.Attributes.GetNamedItem("MATERIAL_TYPE").Value;
                    if (!comboBox5.Items.Contains(material_type))
                        comboBox5.Items.Add(material_type);
                    string pages = el.Attributes.GetNamedItem("PAGES").Value;
                    if (!comboBox6.Items.Contains(pages))
                        comboBox6.Items.Add(pages);
                    string date = el.Attributes.GetNamedItem("DATE").Value;
                    if (!comboBox7.Items.Contains(date))
                        comboBox7.Items.Add(date);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Author.Checked = false;
            Material.Checked = false;
            Faculty.Checked = false;
            Cathedry.Checked = false;
            Material_Type.Checked = false;
            Pages.Checked = false;
            Date.Checked = false;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            LINQ.Checked = false;
            DOM.Checked = false;
            SAX.Checked = false;
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("XSL.xsl");
            string input = @"Archive.xml";
            string result = @"info.html";

            xslt.Transform(input, result);
            MessageBox.Show("Success!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Archive _car = MyArchive();
            if (LINQ.Checked)
            {
                IStrategy CurrentStrategy = new LINQ(path);
                final = CurrentStrategy.Algorithm(_car, path);
                Output(final);
            }
            if (DOM.Checked)
            {
                IStrategy CurrentStrategy = new DOM(path);
                final = CurrentStrategy.Algorithm(_car, path);
                Output(final);
            }
            if (SAX.Checked)
            {
                IStrategy CurrentStrategy = new SAX(path);
                final = CurrentStrategy.Algorithm(_car, path);
                Output(final);
            }
            else
            {
                IStrategy CurrentStrategy = new LINQ(path);
                final = CurrentStrategy.Algorithm(_car, path);
                Output(final);
            }
        }

        private Archive MyArchive()
        {
            string[] info = new string[7];
            if (Author.Checked) info[0] = Convert.ToString(comboBox1.Text);
            if (Material.Checked) info[1] = Convert.ToString(comboBox2.Text);
            if (Faculty.Checked) info[2] = Convert.ToString(comboBox3.Text);
            if (Cathedry.Checked) info[3] = Convert.ToString(comboBox4.Text);
            if (Material_Type.Checked) info[4] = Convert.ToString(comboBox5.Text);
            if (Pages.Checked) info[5] = Convert.ToString(comboBox6.Text);
            if (Date.Checked) info[6] = Convert.ToString(comboBox7.Text);
            Archive perfectArchive = new Archive(info);
            return perfectArchive;
        }

        private void Output(List<Archive> final)
        {
            richTextBox1.Clear();
            if (final.Count == 0)
            {
                richTextBox1.AppendText("Nothing was found! \n");
                return;
            }
            int i = 1;
            foreach (Archive n in final)
            {
                richTextBox1.AppendText(i++ + "." + "\n");
                richTextBox1.AppendText("Author: " + n.Author + "\n");
                richTextBox1.AppendText("Material: " + n.Material + "\n");
                richTextBox1.AppendText("Faculty: " + n.Faculty + "\n");
                richTextBox1.AppendText("Cathedry: " + n.Cathedry + "\n");
                richTextBox1.AppendText("Material_Type: " + n.Material_Type + "\n");
                richTextBox1.AppendText("Pages: " + n.Pages + "\n");
                richTextBox1.AppendText("Date: " + n.Date + "\n");
                richTextBox1.AppendText("____________________________________" + "\n");
            }
        }

        private void Archive_Search_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FillBox();
        }

        private void Archive_Search_FormClosing(object sender, FormClosingEventArgs e)
        {
                DialogResult userAnswer = MessageBox.Show("Ви точно бажаєте закрити додаток?", "Закрити додаток?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (userAnswer == DialogResult.Yes)
                    this.Dispose();
                else if (userAnswer == DialogResult.No)
                    e.Cancel = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}