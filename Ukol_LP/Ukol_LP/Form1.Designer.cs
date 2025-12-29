namespace Ukol_LP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            labelText = new Label();
            labelAtributy = new Label();
            labelZanoreni = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelMinAttr = new Label();
            labelPoradi = new Label();
            labelMaxAttr = new Label();
            labelMaxChildren = new Label();
            labelMaxDepth = new Label();
            labelFileName = new Label();
            splitContainer1 = new SplitContainer();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripSeparator2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1385, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = SystemColors.ButtonHighlight;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.ForeColor = SystemColors.ControlText;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "Otevřít";
            toolStripButton1.ToolTipText = "otevřít soubor";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "Uložit";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "Zavřít";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.LabelEdit = true;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(459, 781);
            treeView1.TabIndex = 1;
            treeView1.AfterLabelEdit += treeView1_AfterLabelEdit;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder.png");
            imageList1.Images.SetKeyName(1, "blank-file-icon.png");
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Top;
            labelText.Location = new Point(3, 0);
            labelText.Name = "labelText";
            labelText.Size = new Size(916, 25);
            labelText.TabIndex = 3;
            labelText.Text = "Text:";
            // 
            // labelAtributy
            // 
            labelAtributy.AutoSize = true;
            labelAtributy.Dock = DockStyle.Top;
            labelAtributy.Location = new Point(3, 25);
            labelAtributy.Name = "labelAtributy";
            labelAtributy.Size = new Size(916, 25);
            labelAtributy.TabIndex = 4;
            labelAtributy.Text = "Atributy:";
            // 
            // labelZanoreni
            // 
            labelZanoreni.AutoSize = true;
            labelZanoreni.Dock = DockStyle.Top;
            labelZanoreni.Location = new Point(3, 50);
            labelZanoreni.Name = "labelZanoreni";
            labelZanoreni.Size = new Size(916, 25);
            labelZanoreni.TabIndex = 5;
            labelZanoreni.Text = "Zanoření:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(labelMinAttr, 0, 10);
            tableLayoutPanel1.Controls.Add(labelPoradi, 0, 3);
            tableLayoutPanel1.Controls.Add(labelText, 0, 0);
            tableLayoutPanel1.Controls.Add(labelZanoreni, 0, 2);
            tableLayoutPanel1.Controls.Add(labelAtributy, 0, 1);
            tableLayoutPanel1.Controls.Add(labelMaxAttr, 0, 9);
            tableLayoutPanel1.Controls.Add(labelMaxChildren, 0, 8);
            tableLayoutPanel1.Controls.Add(labelMaxDepth, 0, 7);
            tableLayoutPanel1.Controls.Add(labelFileName, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(922, 781);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // labelMinAttr
            // 
            labelMinAttr.AutoSize = true;
            labelMinAttr.Dock = DockStyle.Top;
            labelMinAttr.Location = new Point(3, 220);
            labelMinAttr.Name = "labelMinAttr";
            labelMinAttr.Size = new Size(916, 25);
            labelMinAttr.TabIndex = 8;
            labelMinAttr.Text = "Min. počet atributů, které nějaký element obsahuje:";
            // 
            // labelPoradi
            // 
            labelPoradi.AutoSize = true;
            labelPoradi.Dock = DockStyle.Top;
            labelPoradi.Location = new Point(3, 75);
            labelPoradi.Name = "labelPoradi";
            labelPoradi.Size = new Size(916, 25);
            labelPoradi.TabIndex = 11;
            labelPoradi.Text = "Pořadí mezi sourozenci:";
            // 
            // labelMaxAttr
            // 
            labelMaxAttr.AutoSize = true;
            labelMaxAttr.Dock = DockStyle.Top;
            labelMaxAttr.Location = new Point(3, 195);
            labelMaxAttr.Name = "labelMaxAttr";
            labelMaxAttr.Size = new Size(916, 25);
            labelMaxAttr.TabIndex = 9;
            labelMaxAttr.Text = "Max. počet atributů, které nějaký element obsahuje:";
            labelMaxAttr.Click += labelMaxAttr_Click;
            // 
            // labelMaxChildren
            // 
            labelMaxChildren.AutoSize = true;
            labelMaxChildren.Dock = DockStyle.Top;
            labelMaxChildren.Location = new Point(3, 170);
            labelMaxChildren.Name = "labelMaxChildren";
            labelMaxChildren.Size = new Size(916, 25);
            labelMaxChildren.TabIndex = 7;
            labelMaxChildren.Text = "Max. přímí potomci:";
            // 
            // labelMaxDepth
            // 
            labelMaxDepth.AutoSize = true;
            labelMaxDepth.Dock = DockStyle.Top;
            labelMaxDepth.Location = new Point(3, 145);
            labelMaxDepth.Name = "labelMaxDepth";
            labelMaxDepth.Size = new Size(916, 25);
            labelMaxDepth.TabIndex = 6;
            labelMaxDepth.Text = "Hloubka nejzanořenějšího elementu:";
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Dock = DockStyle.Top;
            labelFileName.Location = new Point(3, 120);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(916, 25);
            labelFileName.TabIndex = 10;
            labelFileName.Text = "Název souboru:";
            labelFileName.Click += labelFileName_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2MinSize = 200;
            splitContainer1.Size = new Size(1385, 781);
            splitContainer1.SplitterDistance = 459;
            splitContainer1.TabIndex = 9;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            splitContainer1.SizeChanged += splitContainer1_SizeChanged;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1385, 814);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private TreeView treeView1;
        private ImageList imageList1;
        private Label labelText;
        private Label labelAtributy;
        private Label labelZanoreni;
        private Label labelMaxDepth;
        private Label labelMaxAttr;
        private Label labelMinAttr;
        private Label labelMaxChildren;
        private Label labelFileName;
        private Label labelPoradi;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
    }
}
