namespace DZ_17_01_2021
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxOpen = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxViewWindow = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.tileStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.largeIconToolStripMenuItem.Text = "Список изображений";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.LargeIconToolStripMenuItemClick);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.smallIconToolStripMenuItem.Text = "Список иконок";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.SmallIconToolStripMenuItemClick);
            // 
            // tileStripMenuItem
            // 
            this.tileStripMenuItem.Name = "tileStripMenuItem";
            this.tileStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tileStripMenuItem.Text = "Плитка";
            this.tileStripMenuItem.Click += new System.EventHandler(this.TileStripMenuItemClick);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.listToolStripMenuItem.Text = "Список";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.ListToolStripMenuItemClick);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.detailsToolStripMenuItem.Text = "Таблица";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItemClick);
            // 
            // textBoxOpen
            // 
            this.textBoxOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpen.Location = new System.Drawing.Point(0, 27);
            this.textBoxOpen.Name = "textBoxOpen";
            this.textBoxOpen.Size = new System.Drawing.Size(778, 20);
            this.textBoxOpen.TabIndex = 1;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOpen.Location = new System.Drawing.Point(776, 27);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(24, 20);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpenClick);
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.FullRowSelect = true;
            this.treeView.ImageKey = "default.jpg";
            this.treeView.ImageList = this.imageListSmall;
            this.treeView.Location = new System.Drawing.Point(0, 53);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageKey = "default.jpg";
            this.treeView.Size = new System.Drawing.Size(229, 395);
            this.treeView.TabIndex = 3;
            this.treeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewAfterExpand);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewNodeMouseDoubleClick);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "folder.jpg");
            this.imageListSmall.Images.SetKeyName(1, "default.jpg");
            this.imageListSmall.Images.SetKeyName(2, "file_txt.jpg");
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnType,
            this.columnDate,
            this.columnSize});
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageListLarge;
            this.listView.Location = new System.Drawing.Point(235, 53);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(565, 395);
            this.listView.SmallImageList = this.imageListSmall;
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewMouseDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Имя";
            this.columnName.Width = 200;
            // 
            // columnType
            // 
            this.columnType.Text = "Тип";
            this.columnType.Width = 100;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Дата изменения";
            this.columnDate.Width = 100;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Размер";
            this.columnSize.Width = 100;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "folder.jpg");
            this.imageListLarge.Images.SetKeyName(1, "default.jpg");
            this.imageListLarge.Images.SetKeyName(2, "file_txt.jpg");
            // 
            // comboBoxViewWindow
            // 
            this.comboBoxViewWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxViewWindow.FormattingEnabled = true;
            this.comboBoxViewWindow.Items.AddRange(new object[] {
            "Список изображений",
            "Список иконок",
            "Плитка",
            "Список",
            "Таблица"});
            this.comboBoxViewWindow.Location = new System.Drawing.Point(660, 0);
            this.comboBoxViewWindow.Name = "comboBoxViewWindow";
            this.comboBoxViewWindow.Size = new System.Drawing.Size(140, 21);
            this.comboBoxViewWindow.TabIndex = 5;
            this.comboBoxViewWindow.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вид окна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxViewWindow);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxOpen);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Explorer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxOpen;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox comboBoxViewWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
    }
}

