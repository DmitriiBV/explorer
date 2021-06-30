using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DZ_17_01_2021
{
    public partial class Form1 : Form
    {        
        private TreeNode TreeSelectedNodeToList { get; set; }
        private bool TreeControl { get; set; }
        public Form1()
        { 
            TreeControl = false;
            InitializeComponent();            
            ConstructorTreeViewFullPath(Environment.CurrentDirectory);
            comboBoxViewWindow.SelectedIndex = 0;         
        }
        private void ButtonOpenClick(object sender, EventArgs e) => OpenFolderBrowserDialog();
        private void OpenToolStripMenuItemClick(object sender, EventArgs e) => OpenFolderBrowserDialog();
        private void OpenFolderBrowserDialog()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TreeControl = false;
                treeView.Nodes.Clear();
                ConstructorTreeViewFullPath(folderBrowserDialog.SelectedPath);
            }
        }
        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    listView.View = View.LargeIcon;
                    break;
                case 1:
                    listView.View = View.SmallIcon;
                    break;
                case 2:
                    listView.View = View.Tile;
                    break;
                case 3:
                    listView.View = View.List;
                    break;
                case 4:
                    listView.View = View.Details;
                    break;
            }
        }
        private void LargeIconToolStripMenuItemClick(object sender, EventArgs e) => comboBoxViewWindow.SelectedIndex = 0;
        private void SmallIconToolStripMenuItemClick(object sender, EventArgs e) => comboBoxViewWindow.SelectedIndex = 1;
        private void TileStripMenuItemClick(object sender, EventArgs e) => comboBoxViewWindow.SelectedIndex = 2;
        private void ListToolStripMenuItemClick(object sender, EventArgs e) => comboBoxViewWindow.SelectedIndex = 3;
        private void DetailsToolStripMenuItemClick(object sender, EventArgs e) => comboBoxViewWindow.SelectedIndex = 4;
        private void ConstructorTreeViewFullPath(string fullPath)
        {
            var temp= fullPath;            
            textBoxOpen.Text= temp.Replace("\\\\", "\\");
            DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
            List<DirectoryInfo> dirInfoList = new List<DirectoryInfo>();
            dirInfoList.Add(dirInfo);
            while (dirInfo.Parent != null)
            {
                dirInfoList.Add(new DirectoryInfo(dirInfo.Parent.FullName));
                dirInfo = new DirectoryInfo(dirInfo.Parent.FullName);
            }           
            DirectoryInfo[] dirInfoArray = dirInfoList.ToArray();
            for (int i = dirInfoArray.Length - 1; i >= 0; i--)
            {
                ShowTreeViewFullPath(dirInfoArray[i]);               
            }            
            treeView.SelectedNode.ForeColor = Color.White;
            treeView.SelectedNode.BackColor = Color.Gray;
            ShowListView();
            TreeControl = true;            
        }
        private void ShowTreeViewFullPath(DirectoryInfo directoryInfo)
        {
            if (treeView.Nodes.Count == 0)
                ShowTreeViewNode(null, directoryInfo.FullName);            
            else
            {             
                TreeNode[] treeNodes = treeView.SelectedNode.Nodes.Find(directoryInfo.Name, true);
                treeNodes.ToList().ForEach(it => ShowTreeViewNode(it));
            }
        }        
        private void ShowTreeViewNode(TreeNode treeNode = null, string fullPath="")
        {
            TreeNode parentNode;
            DirectoryInfo info;
            if (treeNode == null)
            {                
                info = new DirectoryInfo(fullPath);
                parentNode = CreateFolderNode(info);               
                treeView.Nodes.Add(parentNode);
            }
            else
            {
                parentNode = treeNode;
                info = (DirectoryInfo)parentNode.Tag;
                parentNode.Nodes.Clear();
            }     
            
            if (info.Exists)
            {
                TreeNode pChildNode;
                TreeNode childNode;
                DirectoryInfo[] subSubDirs;
                foreach (DirectoryInfo subDir in info.GetDirectories())
                {
                    try
                    {
                        pChildNode = CreateFolderNode(subDir);                        
                        subSubDirs = subDir.GetDirectories();
                        parentNode.Nodes.Add(pChildNode);
                        if (subSubDirs.Length != 0)
                        {
                            childNode= CreateFolderNode(subSubDirs[0]);                            
                            pChildNode.Nodes.Add(childNode);
                        }
                    }
                    catch (UnauthorizedAccessException/*Exception*/ ) { }                    
                }
                foreach (FileInfo file in info.GetFiles())
                {
                    try
                    {
                        pChildNode = new TreeNode(file.Name);
                        pChildNode.Tag = new DirectoryInfo(info.FullName + "\\" + file.Name);
                        pChildNode.ImageKey = null;
                        pChildNode.SelectedImageKey = null;
                        if (file.Name.Contains(".txt"))
                        {
                            pChildNode.ImageKey = "file_txt.jpg";
                            pChildNode.SelectedImageKey = "file_txt.jpg";
                        }
                        pChildNode.Name = file.Name;
                        parentNode.Nodes.Add(pChildNode);
                    }
                    catch (UnauthorizedAccessException/*Exception*/ ) { }
                }
                parentNode.Expand();
                treeView.SelectedNode = parentNode;                
            }           
        }
        private TreeNode CreateFolderNode(DirectoryInfo dirInfo)
        {
            TreeNode node = new TreeNode(dirInfo.Name, 0, 0);
            node.Tag = dirInfo;
            node.ImageKey = "folder.jpg";
            node.SelectedImageKey = "folder.jpg";
            node.Name = dirInfo.Name;
            return node;
        }
        private void ShowListView()
        {
            TreeSelectedNodeToList = treeView.SelectedNode;
            listView.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)treeView.SelectedNode.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[] {new ListViewItem.ListViewSubItem(item, "Directory"),
                                                               new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                item.ImageKey = "folder.jpg";
                listView.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[] {new ListViewItem.ListViewSubItem(item, file.Extension),
                                                               new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()),
                                                               new ListViewItem.ListViewSubItem(item, file.GetFileSize())};
                item.SubItems.AddRange(subItems);
                if (file.Name.Contains(".txt"))
                    item.ImageKey = "file_txt.jpg";
                listView.Items.Add(item);
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void TreeViewAfterExpand(object sender, TreeViewEventArgs e)
        {
            if (TreeControl == true)
            {
                TreeControl = false;
                ShowTreeViewNode(e.Node);
                TreeControl = true;
            }
        }         
        private void TreeViewNodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {            
            DirectoryInfo info = new DirectoryInfo(e.Node.FullPath);
            if (info.Exists)
            {
                TreeControl = false;
                textBoxOpen.Text = e.Node.FullPath;
                treeView.Nodes.Clear();              
                ConstructorTreeViewFullPath(textBoxOpen.Text);              
            }
            else            
                return;            
        }
        private void ListViewMouseDoubleClick(object sender, MouseEventArgs e)
        {
            string temp="";          
            TreeNode[] treeNodes = TreeSelectedNodeToList.Nodes.Find(listView.GetItemAt(e.X, e.Y).Text, true);            
            treeNodes.ToList().ForEach(it => temp=it.FullPath);
            DirectoryInfo info = new DirectoryInfo(temp);
            if (info.Exists)
            {
                TreeControl = false;
                listView.Items.Clear();
                treeView.Nodes.Clear();
                ConstructorTreeViewFullPath(temp);
            }
            else 
            {
                if (listView.GetItemAt(e.X, e.Y).Text.Contains(".txt"))
                    System.Diagnostics.Process.Start("notepad.exe", temp);
            }                
        }        
    }
}