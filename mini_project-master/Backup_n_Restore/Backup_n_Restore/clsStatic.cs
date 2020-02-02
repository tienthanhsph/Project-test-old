using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_n_Restore
{
    public static class clsStatic
    {
        //public int Flag { get; set; }
        public static void TrangThaiBanDau(Control ctrl)
        {
            try
            {

                if (ctrl.Controls.Count > 0)
                {
                    foreach (Control con in ctrl.Controls)
                    {
                        if (con is TextBox)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((TextBox)con).Enabled = false;
                        }
                        else if (con is RichTextBox)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((RichTextBox)con).Enabled = false;
                        }
                        else if (con is NumericUpDown)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((NumericUpDown)con).Enabled = false;
                        }
                        else if (con is DateTimePicker)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((DateTimePicker)con).Enabled = false;
                        }
                        else if (con is CheckBox)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((CheckBox)con).Enabled = false;
                        }
                        else if (con is RadioButton)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((RadioButton)con).Enabled = false;
                        }
                        else if (con is ComboBox)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((ComboBox)con).Enabled = false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void TrangThaiChucNang(Control ctrl)
        {
            try
            {

                if (ctrl.Controls.Count > 0)
                {
                    foreach (Control con in ctrl.Controls)
                    {
                        if (con is TextBox)
                        {
                            con.BackColor = Color.White;
                            ((TextBox)con).Enabled = true;
                        }
                        else if (con is RichTextBox)
                        {
                            con.BackColor = Color.White;
                            ((RichTextBox)con).Enabled = true;
                        }
                        else if (con is NumericUpDown)
                        {
                            con.BackColor = Color.White;
                            ((NumericUpDown)con).Enabled = true;
                        }
                        else if (con is DateTimePicker)
                        {
                            con.BackColor = Color.White;
                            ((DateTimePicker)con).Enabled = true;
                        }
                        else if (con is CheckBox)
                        {
                            con.BackColor = Color.White;
                            ((CheckBox)con).Enabled = true;
                        }
                        else if (con is RadioButton)
                        {
                            con.BackColor = Color.White;
                            ((RadioButton)con).Enabled = true;
                        }
                        else if (con is ComboBox)
                        {
                            con.BackColor = Color.White;
                            ((ComboBox)con).Enabled = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void TrangThaiKetThuc(Control ctrl)
        {
            try
            {

                if (ctrl.Controls.Count > 0)
                {
                    foreach (Control con in ctrl.Controls)
                    {
                        if (con is TextBox)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((TextBox)con).Enabled = false;
                        }
                        else if (con is RichTextBox)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((RichTextBox)con).Enabled = false;
                        }
                        else if (con is NumericUpDown)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((NumericUpDown)con).Enabled = false;
                        }
                        else if (con is DateTimePicker)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((DateTimePicker)con).Enabled = false;
                        }
                        else if (con is CheckBox)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((CheckBox)con).Enabled = false;
                        }
                        else if (con is RadioButton)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((RadioButton)con).Enabled = false;
                        }
                        else if (con is ComboBox)
                        {
                            //con.BackColor = Color.LemonChiffon;
                            ((ComboBox)con).Enabled = false;
                        }
                    }
                }

                //MessageBox.Show(Flag.ToString() + " Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static int ThemSuaXoa()
        {
            int kq = 0;



            return kq;
        }
        public static void StyleDataGridView()
        { 
        
        }
        public static void ShowDataFromGridView()
        { }


    }
}
