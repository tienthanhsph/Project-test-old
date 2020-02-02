using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Scan
{
    public partial class Explorer : Form
    {
        public Explorer()
        {
            InitializeComponent();
        }
        private const int Width_ = 180;
        private const int Height_ = 250;
        private const int LX = 30;
        private const int LY = 20;
        private const int Distance_Treeview = 0;
        private TreeView CreateTreeView(int number)
        {
            TreeView newTreeView = new TreeView();
            newTreeView.Name = number.ToString();            
            //newTreeView.Location = new Point( LX + (number) * (Width_ + Distance_Treeview),LY);
            //newTreeView.Size = new Size(Width_, Height_);
            newTreeView.AfterSelect += new TreeViewEventHandler(treeView_AfterSelect);
            TreeNode firstNode = new TreeNode("-----["+number.ToString()+"]");            
            newTreeView.Nodes.Add(firstNode);
            
            return newTreeView;
        }
        private void SetupLocationTreeView(TreeView tree)
        {
            int length = 0;
            int _name = Convert.ToInt32(tree.Name);
            for (int i = 0; i < _name; i++)
            { 
               foreach (TreeView ctrl in panel1.Controls.OfType<TreeView>())
               {
                   if (Convert.ToInt32(ctrl.Name) == i)
                   {
                       length += ctrl.Width + Distance_Treeview;
                   }

               }
            }
            tree.Location = new Point(length, LY);
        }
       
        private void SetupSizeTreeView(TreeView tree)
        {
            int MaxLengthW=0;
            int MaxLengthH = 0;
            Graphics g = this.panel1.CreateGraphics();
            System.Drawing.Font ff = tree.Font;
            foreach (TreeNode node in tree.Nodes)
            {
                // g.MeasureString(....) là hàm lấy ra kích thước của chuỗi...
                if (Convert.ToInt32(g.MeasureString(node.Text, ff).Width) > MaxLengthW)
                {
                    MaxLengthW = Convert.ToInt32(g.MeasureString(node.Text, ff).Width);
                }                
                MaxLengthH += Convert.ToInt32(g.MeasureString(node.Text, ff).Height)+2;                
            }
            if (MaxLengthW < 120)
                MaxLengthW = 120;
            if (MaxLengthH < 240)
                MaxLengthH = 240;
            //if (MaxLengthH > panel1.Height-20)
            //    MaxLengthH = panel1.Height - 20;
            //if (MaxLengthW > 350)
            //    MaxLengthW = 350;
            tree.Width = MaxLengthW+30;
           
            tree.Height = MaxLengthH + 10;
              
        }
        string StartUp = "D:";
        int CurrentState = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FolderBrowserDialog brow = new FolderBrowserDialog();
            brow.RootFolder = Environment.SpecialFolder.Desktop;
            brow.ShowDialog();
            StartUp = brow.SelectedPath;

            CurrentState = 0;
            
            TreeView MainTreeView = CreateTreeView(CurrentState);   
            ClearTreeView_Infr(CurrentState);
            BuildTreeView(StartUp, MainTreeView);
            
#region "Da duoc thay bang ham"
            //try
            //{
            //    DirectoryInfo[] SubDirs = dir.GetDirectories();
            //    FileInfo[] files = dir.GetFiles();
            //    if (SubDirs.Length > 0)
            //    {
            //        foreach (DirectoryInfo SubDir in SubDirs)
            //        {
            //            if ((SubDir.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
            //            {
            //                TreeNode _node = new TreeNode(SubDir.Name);
            //                _node.Name = SubDir.FullName;
            //                MainTreeView.Nodes.Add(_node);
            //            }
            //        }
            //    }
            //    if (files.Length > 0)
            //    {
            //        foreach (FileInfo file in files)
            //        {
            //            if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
            //            {
            //                TreeNode _node = new TreeNode(file.Name);
            //                _node.Name = file.FullName;
            //                MainTreeView.Nodes.Add(_node);
            //            }
            //        }
            //    }

            //}

            //catch (UnauthorizedAccessException)
            //{

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //FormatTreeView(MainTreeView);
#endregion
            panel1.Controls.Add(MainTreeView);
        }
       
        
        private void FormatTreeView(TreeView tw)
        {
            foreach (TreeNode node in tw.Nodes)
            {
                string NodeName = node.Name;
                if (Directory.Exists(NodeName))
                {
                    node.BackColor = Color.Khaki;

                }
                else
                {
                    node.BackColor = Color.White;
                }
            }
            SetupSizeTreeView(tw);
            SetupLocationTreeView(tw);
        }
        private void ClearTreeView_Infr(int number)
        {
            List<string> collection = new List<string>();
            foreach (TreeView ctrl in panel1.Controls.OfType<TreeView>())
            {
                if (Convert.ToInt32(ctrl.Name) > CurrentState)
                {
                    collection.Add(ctrl.Name);
                }
                
            }
            foreach (string s in collection)
            {
                foreach (Control ctr in panel1.Controls)
                {
                    if (ctr.Name == s)
                    {
                        panel1.Controls.Remove(ctr);
                        ctr.Dispose();
                    }
                }
            }
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView treeview = (TreeView)sender;
            CurrentState =Convert.ToInt32( treeview.Name);
            ClearTreeView_Infr(CurrentState);

            TreeView SubDirTreeView =  CreateTreeView(CurrentState + 1);  

            TreeNode node = e.Node;
            string dirParentName = node.Name;
            if (Directory.Exists(dirParentName))
            {
                BuildTreeView(dirParentName, SubDirTreeView);
                #region "Da thay the bang ham"
                //try
                //{
                //    DirectoryInfo dirParent = new DirectoryInfo(dirParentName);
                //    DirectoryInfo[] SubDirs = dirParent.GetDirectories();
                //    FileInfo[] files = dirParent.GetFiles();
                //    if (SubDirs.Length > 0)
                //    {
                //        foreach (DirectoryInfo SubDir in SubDirs)
                //        {
                //            if ((SubDir.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                //            {
                //                TreeNode _node = new TreeNode(SubDir.Name);
                //                _node.Name = SubDir.FullName;
                //                SubDirTreeView.Nodes.Add(_node);
                //            }
                //        }
                //    }
                //    if (files.Length > 0)
                //    {
                //        foreach (FileInfo file in files)
                //        {
                //            if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                //            {
                //                TreeNode _node = new TreeNode(file.Name);
                //                _node.Name = file.FullName;
                //                SubDirTreeView.Nodes.Add(_node);
                //            }
                //        }
                //    }
                //    FormatTreeView(SubDirTreeView);
                //}

                //catch (UnauthorizedAccessException)
                //{

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                #endregion
            }

            else
            {
                System.Diagnostics.Process.Start(dirParentName);

            }
            panel1.Controls.Add(SubDirTreeView);
        }
        private void BuildTreeView(string _path, TreeView _tree)
        {
            _tree.Nodes.Clear();
           
            try
            {
                DirectoryInfo dirParent = new DirectoryInfo(_path);
                DirectoryInfo[] SubDirs = dirParent.GetDirectories();
                FileInfo[] files = dirParent.GetFiles();
                if (SubDirs.Length > 0)
                {
                    foreach (DirectoryInfo SubDir in SubDirs)
                    {
                        if ((SubDir.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                        {
                            TreeNode _node = new TreeNode(SubDir.Name);
                            _node.Name = SubDir.FullName;
                            
                            _tree.Nodes.Add(_node);
                        }
                    }
                }
                if (files.Length > 0)
                {
                    foreach (FileInfo file in files)
                    {
                        if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                        {
                            TreeNode _node = new TreeNode(file.Name);
                            _node.Name = file.FullName;
                          
                            _tree.Nodes.Add(_node);
                        }
                    }
                }
                FormatTreeView(_tree);
                
            }

            catch (UnauthorizedAccessException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Explorer_Load(object sender, EventArgs e)
        {
            
        }

        private void treeView_Resize(object sender, EventArgs e)
        {
            TreeView tw = (TreeView)sender;
            int number = Convert.ToInt32(tw.Name);
            List<string> collection = new List<string>();
            foreach (TreeView ctrl in panel1.Controls.OfType<TreeView>())
            {
                if (Convert.ToInt32(ctrl.Name) > number)
                {
                    collection.Add(ctrl.Name);
                }

            }
            if (collection.Count == 0)
                return;
            collection.Sort();

            
            int With_sender = tw.Width;
            int _X = tw.Location.X + With_sender + Distance_Treeview;
           
            for (int i = 0; i < collection.Count; i++)
            {
                foreach (TreeView ctrl in panel1.Controls.OfType<TreeView>())
                {

                    if (ctrl.Name == collection[i])
                    {
                        ctrl.Location = new Point(_X, LY);
                        _X += ctrl.Width + Distance_Treeview;
                    }

                }
            }
           
        }

    }
}
