using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjMenuHeThong
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        int stt = 0;
        public void TaoMenu(string user)
        { 
            string query =" SELECT  DISTINCT C.[nMoTaChucNang]  "+
	                        " FROM tblUsers A, tblUserChucNang B, tblTuDienChucNang C  "+
	                        " WHERE A.[TenDangNhap] =  '"+user+"'"+
		                    " AND A.[MaUsers] = B.[MaUsers]  "+
		                    " AND B.[iMaChucNang] = C.[iMaChucNang]";
            string[] Names = cls._ExecuteReader(query, "nMoTaChucNang");
            stt = 0;
            foreach (string name in Names)
            {
                if (name.Trim() != string.Empty)
                {                    
                    CreateButton(name, name, true, stt);
                    stt++;
                }
            }
        }
        private void CreateButton(string Name, string Text, bool Status, int STT)
        {
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Point ViTri = new Point(10, 100+ STT * 40);
            button.Location = ViTri;
            button.Name = Name;
            button.Size = new System.Drawing.Size(200, 40);
            button.TabIndex = 0;
            button.Text = Text;
            button.UseVisualStyleBackColor = true;
            button.Click += new System.EventHandler(button_Click);
            this.Controls.Add(button);
            button.Enabled = Status;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (Control ctr in this.Parent.Controls)
            {
                if (ctr is Label)
                {
                    if (ctr.Name == "lblKetQua")
                    {
                        ctr.Text = "Ban Da Chon: " + btn.Name;
                    }
                }
            }
            //MessageBox.Show(this.Parent.Name);
            //MessageBox.Show(this.ParentForm.Name);
            foreach (Control ctr in this.Controls)
            {
                if (ctr is Button)
                {
                    if (ctr.Name != btn.Name)
                    {
                        ctr.BackColor = this.BackColor;
                    }
                    else
                    {
                        ctr.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
