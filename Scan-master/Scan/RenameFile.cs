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
    public partial class RenameFile : Form
    {
        public RenameFile()
        {
            InitializeComponent();
        }
        private void ReNameFile_(string fileName1, string fileName2)
        {
            FileInfo file = new FileInfo(fileName1);
            file.MoveTo(fileName2);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
//            string path = Application.StartupPath;
//            string name1 = path + "\\a.txt";
//            string name2 = path + "\\b.txt";
//            ReNameFile_(name1, name2);
//            System.Diagnostics.Process.Start(name2);
			foreach(TreeNode node in treeView1.Nodes)
			{
				if(node.Checked == true)
				{
					DirectoryInfo dir  = new DirectoryInfo(node.Name);
					FileInfo[] files = dir.GetFiles();
					if(files != null && files.Length >0)
					{
						string NameBefore="";
						string NameAfter="";
						string _dir = dir.FullName;
						foreach(FileInfo file in files)
						{
							if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
							{
								if(file.Name.Contains(textBox1.Text.Trim()))
								{
									NameBefore = file.Name;
									NameAfter=file.Name.Replace(textBox1.Text.Trim(),textBox2.Text.Trim());
									ReNameFile_(_dir+"\\"+NameBefore,_dir+"\\"+NameAfter);
								}
							}
						}
					}
				}
			}
            treeView1.Refresh();
            treeView2.Refresh();
        }
		
		void BtnFindFileClick(object sender, EventArgs e)
		{
			treeView1.Nodes.Clear();
			string path = clsGlobal.glbRootFolder+"\\"+clsGlobal.glbMaDonViHanhChinh;
			if(!Directory.Exists(path))
				Directory.CreateDirectory(path);
			DirectoryInfo dir = new DirectoryInfo(path);
			DirectoryInfo[] subDirs = dir.GetDirectories();
			foreach(DirectoryInfo subDir in subDirs)
			{
				if(subDir.CreationTime < dateTimePicker1.Value)
				{
                    MessageBox.Show(subDir.CreationTime.ToString());
					TreeNode newNode = new TreeNode(subDir.Name);
					newNode.Name=subDir.FullName;
					treeView1.Nodes.Add(newNode);
				}
			}
		}
		string folderPath="";
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
			treeView2.Nodes.Clear();
			folderPath = e.Node.Name;
			DirectoryInfo dir = new DirectoryInfo(folderPath);
			FileInfo[] files = dir.GetFiles();
			if(files != null && files.Length >0)
			{
				foreach(FileInfo file in files)
				{
					if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
					{
						TreeNode newNode = new TreeNode(file.Name);
						newNode.Name = file.FullName;
						treeView2.Nodes.Add(newNode);
					}
				}
				
			}
		}
		void TreeView2AfterSelect(object sender, TreeViewEventArgs e)
		{
			string filePath = e.Node.Name;			
			System.Diagnostics.Process.Start(filePath);
		}

        private void RenameFile_Load(object sender, EventArgs e)
        {
           
        }
		
    }
}
