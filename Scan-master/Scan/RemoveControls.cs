using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scan
{
    public partial class RemoveControls : Form
    {
        public RemoveControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                Button btn =  createBut(i);
                panel1.Controls.Add(btn);
                
            }
            MessageBox.Show(count());
        }
        private Button createBut(int i)
        {
            Button btn = new Button();
            btn.Name = i.ToString();
            return btn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> ToRemove = new List<string>();
            Control.ControlCollection colection = this.panel1.Controls;
            for (int i = 0; i < colection.Count; i++)
            {
                if (Convert.ToInt32(colection[i].Name) > 2)
                {
                    ToRemove.Add(colection[i].Name);
                }
            }
            foreach (string str in ToRemove)
            {
                foreach (Control tw in panel1.Controls)
                {
                    if (tw.Name == str)
                    {
                        panel1.Controls.Remove(tw);
                    }
                }
            }
                //foreach (Button btn in panel1.Controls.OfType<Button>())
                //{

                //    if (Convert.ToInt32(btn.Name) > 2)
                //    {
                //        panel1.Controls.Remove(btn);
                //    }
                //}
                MessageBox.Show(count());
        }
        private string count()
        {
            string collection = "";
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                collection += btn.Name + "; ";

            }
            return collection;
        }

        private void RemoveControls_Load(object sender, EventArgs e)
        {
            
        }
    }
}
