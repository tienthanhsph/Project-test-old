/*
 * Created by SharpDevelop.
 * User: TIEN THANH
 * Date: 15-Jun-15
 * Time: 5:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace TranferFile
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			

		}
		
		public string  BrowFolder()
        {
            #region "xem file"
            //OpenFileDialog openfile = new OpenFileDialog();
            //openfile.InitialDirectory = _fromdir;
            //openfile.Filter = "All files (*.*)|*.*";
            //openfile.ShowDialog();
            //string destFolder = openfile.FileName;
            //FileInfo finfo = new System.IO.FileInfo(destFolder);
            //DirectoryInfo dir = finfo.Directory;
            //MessageBox.Show(dir.FullName);
            #endregion
            FolderBrowserDialog brow = new FolderBrowserDialog();
            //brow.ShowNewFolderButton = false;            
            //brow.RootFolder = Environment.SpecialFolder.MyComputer;// hay! cái này cần dùng nhiều lúc làm việc
            brow.ShowDialog();
            string kq="";
            kq= brow.SelectedPath;
            return kq;            
        }
		
        private void GetTree(DirectoryInfo _info, TreeView _tree)
        { 
            

            DirectoryInfo[] directorys = _info.GetDirectories();

            _tree.Name = _info.Name;
            TreeNode _root = new TreeNode(_info.Name);
            _tree.Nodes.Add(_root);

            FileInfo[] files = _info.GetFiles().Where(file => (file.Attributes & FileAttributes.Hidden) == 0).ToArray();
            foreach (FileInfo file in files)
            {
                if((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {

                    try
                    {
                        TreeNode childNode = new TreeNode(file.Name);
                        childNode.Name = file.FullName;
                        _root.Nodes.Add(childNode);
                    }

                    catch (UnauthorizedAccessException)
                    { }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                    
                   
            } 
            foreach (DirectoryInfo directory in directorys)
            {
                if((directory.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    try
                    {
                        TreeNode node = new TreeNode(directory.Name);
                        node.Name = directory.FullName;
                        _root.Nodes.Add(node);
                        AddToTreeNode(node, directory);
                    }

                    catch (UnauthorizedAccessException)
                    { }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                
            }

            

            // expand path in treeview from root to _info
            string[] path = _info.FullName.Split('\\');
            TreeNode DoingNode= new TreeNode();
            string buildPath = path[0];
            foreach (TreeNode node in _tree.Nodes)
            {
                if (node.Text  == path[1].Trim())
                {                    
                    DoingNode = node;
                    DoingNode.Expand();
                    buildPath += "\\"+path[1].Trim();
                }
            }
            for (int i = 1; i < path.Length-1; i++)
            {
                
                foreach (TreeNode _node in DoingNode.Nodes)
                {
                    string pt = buildPath +"\\"+ path[i+1];
                    if (_node.Name ==pt )
                    {
                        DoingNode = _node;
                        DoingNode.Expand();
                        buildPath =pt;

                    }
                }
            }


           
        }
        
        private void AddToTreeNode(TreeNode _node, DirectoryInfo  dirInfo)
        {
            FileInfo[] files = dirInfo.GetFiles().Where(file => (file.Attributes & FileAttributes.Hidden) == 0).ToArray();
            foreach (FileInfo file in files)
            {
                if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    try
                    {
                        TreeNode childNode = new TreeNode(file.Name);
                        childNode.Name = file.FullName;
                        _node.Nodes.Add(childNode);
                    }

                    catch (UnauthorizedAccessException)
                    { }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                   
                
            } 
            DirectoryInfo[] directorys = dirInfo.GetDirectories();
            foreach (DirectoryInfo directory in directorys)
            {
                if ((directory.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    try
                    {
                        TreeNode childNode = new TreeNode(directory.Name);
                        childNode.Name = directory.FullName;
                        _node.Nodes.Add(childNode);
                        AddToTreeNode(childNode, directory);
                    }

                    catch (UnauthorizedAccessException)
                    { }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        void Button1Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            textBox1.Text = BrowFolder();
            if (textBox1.Text.Trim() == "")
                return;
            DirectoryInfo info = new DirectoryInfo(textBox1.Text.Trim());
            GetTree(info, treeView1);
            treeView1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
            textBox2.Text = BrowFolder();
            if (textBox2.Text.Trim() == "")
                return;
            DirectoryInfo info = new DirectoryInfo(textBox2.Text.Trim());
            GetTree(info, treeView2);
            treeView2.Refresh();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = e.Node.Name.ToString();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Text = e.Node.Name.ToString();
        }

        

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.Nodes.Clear();
            textBox1.Text = e.Node.Name;
            try
            {
                DirectoryInfo info = new DirectoryInfo(textBox1.Text.Trim());
                GetTree(info, treeView1);
                treeView1.Refresh();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView2.Nodes.Clear();
            textBox2.Text = e.Node.Name;
            try
            {
                DirectoryInfo info = new DirectoryInfo(textBox2.Text.Trim());
                GetTree(info, treeView2);
                treeView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (textBox2.Text.Trim() != "")
                    {
                        DirectoryInfo info = new DirectoryInfo(textBox2.Text.Trim());
                        GetTree(info, treeView2);
                        treeView2.Refresh();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (textBox1.Text.Trim() != "")
                    {
                        DirectoryInfo info = new DirectoryInfo(textBox1.Text.Trim());
                        GetTree(info, treeView1);
                        treeView1.Refresh();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                clsFile_n_Folder cls = new clsFile_n_Folder();
                cls.CopyTo(textBox1.Text.Trim(), textBox2.Text.Trim());
                try
                {
                    treeView1.Nodes.Clear();
                    DirectoryInfo info = new DirectoryInfo(textBox1.Text.Trim());
                    GetTree(info, treeView1);
                    treeView1.Refresh();

                    treeView2.Nodes.Clear();
                    DirectoryInfo info2 = new DirectoryInfo(textBox2.Text.Trim());
                    GetTree(info2, treeView2);
                    treeView2.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                clsFile_n_Folder cls = new clsFile_n_Folder();
                cls.MoveTo(textBox1.Text.Trim(), textBox2.Text.Trim());
                
                try
                {
                    treeView1.Nodes.Clear();
                    //DirectoryInfo info = new DirectoryInfo(textBox1.Text.Trim());
                    //GetTree(info, treeView1);
                    //treeView1.Refresh();

                    treeView2.Nodes.Clear();
                    DirectoryInfo info2 = new DirectoryInfo(textBox2.Text.Trim());
                    GetTree(info2, treeView2);
                    treeView2.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SYNC_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                clsFile_n_Folder cls = new clsFile_n_Folder();
                cls.Sync(textBox1.Text.Trim(), textBox2.Text.Trim());
                try
                {
                    treeView1.Nodes.Clear();
                    DirectoryInfo info = new DirectoryInfo(textBox1.Text.Trim());
                    GetTree(info, treeView1);
                    treeView1.Refresh();

                    treeView2.Nodes.Clear();
                    DirectoryInfo info2 = new DirectoryInfo(textBox2.Text.Trim());
                    GetTree(info2, treeView2);
                    treeView2.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" )
            {
                clsFile_n_Folder cls = new clsFile_n_Folder();                
                try
                {
                    cls.DelFolder(textBox1.Text.Trim());


                    treeView1.Nodes.Clear();
                    //DirectoryInfo info = new DirectoryInfo(textBox1.Text.Trim());
                    //GetTree(info, treeView1);
                    //treeView1.Refresh();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
               
		
	}
}
