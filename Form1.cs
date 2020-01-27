using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;

namespace clrmdapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        OpenFileDialog odfclrdac = new OpenFileDialog();
        
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "DMP|*.dmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filename.Text = ofd.SafeFileName;
                filepath.Text = ofd.FileName;
            }
        }



        private void resultobox_TextChanged(object sender, EventArgs e)
        {

        }





        private void memscen_Click(object sender, EventArgs e)
        {



            if (filexisit())
            {
                var a = File.ReadAllText(filepath.Text, Encoding.Default);
                resultobox.Text = a;
                Memory.Createruntime(odfclrdac.FileName,ofd.FileName );
                

                


            }
            else
            {
                resultobox.Text = "Please make sure file is there";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filexisit())
            {
                var a = File.ReadAllText(filepath.Text, Encoding.Default);
                resultobox.Text = a;

            }
            else
            {
                resultobox.Text = "Please make sure file is there";
            }
        }

        public bool filexisit()
        {
            var a = File.Exists(ofd.FileName);
            return a;

        }

        private void dacloc_FileOk(object sender, CancelEventArgs e)
        {


        }

        private void mnmn(object sender, EventArgs e)
        {

        }

        private void dacloc_Click(object sender, EventArgs e)
        {
            ofd.Filter = "DLL|*.dll";
            if (odfclrdac.ShowDialog() == DialogResult.OK)
            {

                resultobox.Text = "File loaded " + odfclrdac.FileName + "Succes";
               
              
               
            }
        }
    }
}