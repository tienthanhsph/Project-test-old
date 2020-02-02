/*
 * Created by SharpDevelop.
 * User: TIEN THANH
 * Date: 15-Jun-15
 * Time: 5:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace TranferFile
{
	/// <summary>
	/// Description of clsFile_n_Folder.
	/// </summary>
	public class clsFile_n_Folder
	{
		public clsFile_n_Folder()
		{
		
		}
		
		public void CopyTo(string _path1, string _path2)
		{
            DirectoryInfo dirInfo1 = new DirectoryInfo(_path1);
           // DirectoryInfo dirInfo2 = new DirectoryInfo(_path2);

            FileInfo[] files = dirInfo1.GetFiles();
            foreach (FileInfo file in files)
            {
                if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    try
                    {
                        file.CopyTo(_path2 + "\\" + file.Name, true);
                    }
                    catch (UnauthorizedAccessException)
                    { }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
                }
            }
            DirectoryInfo[] directorys = dirInfo1.GetDirectories();
            if (directorys.Length > 0 && directorys != null)
            {
                foreach (DirectoryInfo directory in directorys)
                {
                    if ((directory.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {
                       if (!Directory.Exists(_path2 + "\\" + directory.Name))
                            Directory.CreateDirectory(_path2 + "\\" + directory.Name);
                       CopyTo(directory.FullName, _path2+"\\"+directory.Name);
                    }
                }
            }
            
		}
		public void MoveTo(string _path1, string _path2)
		{
            DirectoryInfo dirInfo1 = new DirectoryInfo(_path1);
            // DirectoryInfo dirInfo2 = new DirectoryInfo(_path2);

            FileInfo[] files = dirInfo1.GetFiles();
            foreach (FileInfo file in files)
            {
                if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    try
                    {
                        file.MoveTo(_path2 + "\\" + file.Name);
                    }
                    catch (UnauthorizedAccessException)
                    { }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            DirectoryInfo[] directorys = dirInfo1.GetDirectories();
            if (directorys.Length > 0 && directorys != null)
            {
                foreach (DirectoryInfo directory in directorys)
                {
                    if ((directory.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {
                        if (!Directory.Exists(_path2 + "\\" + directory.Name))
                            Directory.CreateDirectory(_path2 + "\\" + directory.Name);
                        MoveTo(directory.FullName, _path2 + "\\" + directory.Name);
                        
                    }
                }
            }
            if (dirInfo1.GetFiles().Length == 0 && dirInfo1.GetDirectories().Length == 0)
                dirInfo1.Delete();
		}
        public void Sync(string _path1, string _path2)
        {
            Sync_1_Side(_path1, _path2);
            Sync_1_Side(_path2, _path1);
        }
		public void Sync_1_Side(string _path1, string _path2)
		{
            DirectoryInfo dirInfo1 = new DirectoryInfo(_path1);
            // DirectoryInfo dirInfo2 = new DirectoryInfo(_path2);

            FileInfo[] files = dirInfo1.GetFiles();
            foreach (FileInfo file in files)
            {
                if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    try
                    {
                        if (!File.Exists(_path2 + "\\" + file.Name))
                            file.CopyTo(_path2 + "\\" + file.Name, true);
                        else
                        {
                            FileInfo file1 = new FileInfo(file.FullName);
                            FileInfo file2 = new FileInfo(_path2 + "\\" + file.Name);

                            DateTime d1 = file1.LastWriteTime;
                            DateTime d2 = file2.LastWriteTime;
                            if (d1 < d2)
                            { }
                            else
                            {
                                file.CopyTo(_path2 + "\\" + file.Name, true);
                            }
                        }
                    }
                    catch (UnauthorizedAccessException)
                    { }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            DirectoryInfo[] directorys = dirInfo1.GetDirectories();
            if (directorys.Length > 0 && directorys != null)
            {
                foreach (DirectoryInfo directory in directorys)
                {
                    if ((directory.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {
                        if (!Directory.Exists(_path2 + "\\" + directory.Name))
                            Directory.CreateDirectory(_path2 + "\\" + directory.Name);
                        CopyTo(directory.FullName, _path2 + "\\" + directory.Name);
                    }
                }
            }
		}
		public void DelFolder(string _path)
		{
            DirectoryInfo dirInfo = new DirectoryInfo(_path);
            
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    try
                    {
                        file.Delete();
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
            if (directorys.Length > 0 && directorys != null)
            {
                foreach (DirectoryInfo directory in directorys)
                {
                    if ((directory.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {

                        DelFolder(directory.FullName);

                    }
                }
            }
            if (dirInfo.GetFiles().Length == 0 && dirInfo.GetDirectories().Length == 0)
                dirInfo.Delete();
		}
		
		
	}
}
