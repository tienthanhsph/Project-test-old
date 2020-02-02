/*
 * Created by SharpDevelop.
 * User: TIEN THANH
 * Date: 12-Jun-15
 * Time: 8:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TreeView
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
		string connection = " Server = DMC-PC\\SQL2005 ; Database = georgetown_TayHo ; User = sa ; Password = dmc3star ";
		SqlConnection con = new SqlConnection();
		SqlCommand com;
		SqlDataAdapter da;
		SqlDataReader reader;
		DataSet ds = new DataSet();
		private void OpenCon()
		{
			con.ConnectionString = connection;
			if(con.State == ConnectionState.Closed)
				con.Open();
			if(com == null)
				com = con.CreateCommand();
		}
		private void CloseCon()
		{
			if(con.State ==ConnectionState.Open)
				con.Close();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			try
			{
//				countTime = new Timer();
//				countTime.Interval=100;
//				countTime.Tick += new System.EventHandler( this.TinhGio);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		
		TreeNode nodeT;
		TreeNode nodeH;
		TreeNode nodeX;
		private void AddNodeTinh()
		{
			string q= " select * from tblTuDienDonViHanhChinhVN ";			
			OpenCon();
			com.CommandText = q;
			reader = com.ExecuteReader();
			if(reader.HasRows)
			{
				while(reader.Read())
				{					
					if(reader["MaXa"].ToString().Trim() == "0" && reader ["MaHuyen"].ToString().Trim() == "0")
						{
							nodeT = new TreeNode(reader["Ten"].ToString().Trim());
							nodeT.Name = reader["MaDonViHanhChinh"].ToString().Trim();
							treeView1.Nodes.Add(nodeT);
						}
					
				}
			}
			CloseCon();
		}
		private void AddNodeHuyen()
		{
			foreach(TreeNode node in treeView1.Nodes)
			{
				string q = " select * from tblTuDienDonViHanhChinhVN where MaXa ='0' and MaHuyen <> '0' and MaTinh = (select MaTinh from tblTuDienDonViHanhChinhVN where MaDonViHanhChinh ='"+node.Name.Trim()+"')";
				OpenCon();
				com.CommandText = q;				
				reader = com.ExecuteReader();
				if(reader.HasRows)
				{
					while(reader.Read())
					{
						nodeH= new TreeNode(reader["Ten"].ToString().Trim());
						nodeH.Name = reader["MaDonViHanhChinh"].ToString().Trim();
						node.Nodes.Add(nodeH);
					}
				}
				reader.Close();
				CloseCon();
				
				
			}

		}
		private void AddNodeXa()
		{
			foreach(TreeNode nodeI in treeView1.Nodes)
			{
				foreach( TreeNode nodeII in nodeI.Nodes)
				{
					string q = " select * from tblTuDienDonViHanhChinhVN where MaXa <> '0' and MaTinh <> '0' and MaHuyen = (select MaHuyen from tblTuDienDonViHanhChinhVN where MaDonViHanhChinh ='"+nodeII.Name.Trim()+"')";
					OpenCon();
					com.CommandText = q;				
					reader = com.ExecuteReader();
					if(reader.HasRows)
					{
						while(reader.Read())
						{
							nodeX= new TreeNode(reader["MaDonViHanhChinh"].ToString().Trim());
							nodeX.Text = reader["Ten"].ToString().Trim();
							nodeII.Nodes.Add(nodeX);
						}
					}
					reader.Close();
					CloseCon();
				}
			}
			
		}
		#region "Khong Can Dung"
		private void AddName2Node()
		{
			foreach(TreeNode node in treeView1.Nodes)
				if(node.Name.Trim() != "")
					AddName(node);
		}
		
		private void AddName(TreeNode node)
		{
			
			string q = " select Ten from tblTuDienDonViHanhChinhVN where MaDonViHanhChinh ='"+node.Name+"'";
			OpenCon();
			com.CommandText =q;
			node.Text = com.ExecuteScalar().ToString();
			CloseCon();
//			node.Text ="#";
			if(node.Nodes.Count>0)
			{
				foreach(TreeNode _node in node.Nodes)
				{
					if(_node.Name.Trim() != "")
						AddName(_node);
				}
			}
			
			
		}
		#endregion
		private void TimKiem(string search, TreeNode node)
		{
			if(node.Text.Contains(search))
			{
				Expand(node);
				node.BackColor= Color.Red;
			}
			if(node.Nodes.Count>0)
			{
				foreach(TreeNode _node in node.Nodes)
				{
					TimKiem(search,_node);
				}
			}
		}
		private void Collap_(TreeNode node)
		{
			node.Collapse();
			if(node.Nodes.Count >0)
			{
				foreach(TreeNode _node in node.Nodes)
				{
					Collap_(_node);
				}
			}
		}
		private void Expand(TreeNode node)
		{
			if(node.Parent != null)
			{
				node.Parent.Expand();
				Expand(node.Parent);
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			treeView1.Nodes.Clear();
			AddNodeTinh();
			AddNodeHuyen();
			AddNodeXa();

		}
		void Button2Click(object sender, EventArgs e)
		{
			foreach(TreeNode node in treeView1.Nodes)
				Collap_(node);
			foreach(TreeNode node in treeView1.Nodes)
				TimKiem(textBox1.Text, node);
		}
		void Button3Click(object sender, EventArgs e)
		{
			System.Diagnostics.Stopwatch _stw = new System.Diagnostics.Stopwatch();
			_stw.Start();
			for(int i =0; i< 1000;i++)
			{
				string q = " select Ten from tblTuDienDonViHanhChinhVN ";
				OpenCon();
				com.CommandText =q;
				string a = com.ExecuteScalar().ToString();
				CloseCon();
			}
			_stw.Stop();
			MessageBox.Show("Yeee!.....\n"+ _stw.ToString());
		}
//		Timer countTime ;
//		int time =0;
//		private void TinhGio(object sender, EventArgs e)
//		{
//			time ++;
//		}
		
	}
}
