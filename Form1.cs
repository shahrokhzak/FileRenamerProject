using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization ;
using System.IO ;
using System.Linq;
using System.Security.AccessControl ;
using System.Text;
using System.Text.RegularExpressions ;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamerProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BrowseFolder_btn_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //path_lbl.Text=folderBrowserDialog1.SelectedPath;
                statusBar_lbl.Text=folderBrowserDialog1.SelectedPath;
                MessageBox.Show(string.Format("Your Selected Path is: {0}", folderBrowserDialog1.SelectedPath));
            }
            else
                MessageBox.Show("You Didn't Choose New Path");
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            if (  !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath) )
            {
                foreach ( var filename in System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath) )
                {
                    //test_tbx.Text += filename + "\r\n" ;
                    if (filename.IndexOf(contain_tbx.Text,StringComparison.CurrentCultureIgnoreCase)>0)
                    {
                        test_tbx.Text += "true \r\n" ;
                        //System.IO.File.Move(filename,filename.Replace(contain_tbx.Text,replace_tbx.Text));
                        System.IO.File.Move(filename,Regex.Replace(filename, contain_tbx.Text, replace_tbx.Text, RegexOptions.IgnoreCase));
                    }
                    else
                    {
                        test_tbx.Text += "false \r\n" ;
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("You Must Select a Path") ;
            }
           
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //string.IsNullOrEmpty(contain_tbx.Text) ? apply_btn.Enabled = false : apply_btn.Enabled = true;
          
        }

    }
}
