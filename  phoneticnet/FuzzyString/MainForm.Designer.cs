namespace FuzzyString
{
	partial class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.benaderingGroupBox2 = new System.Windows.Forms.GroupBox();
			this.compareTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.fuzzyComboBox = new System.Windows.Forms.ComboBox();
			this.responseTextBox = new System.Windows.Forms.TextBox();
			this.originaleTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.alternateTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.phoneticComboBox = new System.Windows.Forms.ComboBox();
			this.primaryTextBox = new System.Windows.Forms.TextBox();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.totaleTimeGroupBox = new System.Windows.Forms.GroupBox();
			this.dmetaphoneLabel = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.metaphoneLabel = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.dmLabel = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.soundexLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.infoLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.wordListTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.benaderingGroupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.totaleTimeGroupBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AccessibleDescription = null;
			this.menuStrip1.AccessibleName = null;
			this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("menuStrip1.Anchor")));
			this.menuStrip1.AutoSize = ((bool)(resources.GetObject("menuStrip1.AutoSize")));
			this.menuStrip1.BackgroundImage = null;
			this.menuStrip1.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("menuStrip1.BackgroundImageLayout")));
			this.menuStrip1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("menuStrip1.Dock")));
			this.menuStrip1.Font = null;
			this.menuStrip1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("menuStrip1.ImeMode")));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = ((System.Drawing.Point)(resources.GetObject("menuStrip1.Location")));
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("menuStrip1.RightToLeft")));
			this.menuStrip1.Size = ((System.Drawing.Size)(resources.GetObject("menuStrip1.Size")));
			this.menuStrip1.TabIndex = ((int)(resources.GetObject("menuStrip1.TabIndex")));
			this.menuStrip1.Text = resources.GetString("menuStrip1.Text");
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.AccessibleDescription = null;
			this.fileToolStripMenuItem.AccessibleName = null;
			this.fileToolStripMenuItem.AutoSize = ((bool)(resources.GetObject("fileToolStripMenuItem.AutoSize")));
			this.fileToolStripMenuItem.BackgroundImage = null;
			this.fileToolStripMenuItem.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fileToolStripMenuItem.BackgroundImageLayout")));
			this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Enabled = ((bool)(resources.GetObject("fileToolStripMenuItem.Enabled")));
			this.fileToolStripMenuItem.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("fileToolStripMenuItem.ImageAlign")));
			this.fileToolStripMenuItem.ImageScaling = ((System.Windows.Forms.ToolStripItemImageScaling)(resources.GetObject("fileToolStripMenuItem.ImageScaling")));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.RightToLeftAutoMirrorImage = ((bool)(resources.GetObject("fileToolStripMenuItem.RightToLeftAutoMirrorImage")));
			this.fileToolStripMenuItem.ShortcutKeyDisplayString = null;
			this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(resources.GetObject("fileToolStripMenuItem.ShortcutKeys")));
			this.fileToolStripMenuItem.ShowShortcutKeys = ((bool)(resources.GetObject("fileToolStripMenuItem.ShowShortcutKeys")));
			this.fileToolStripMenuItem.Size = ((System.Drawing.Size)(resources.GetObject("fileToolStripMenuItem.Size")));
			this.fileToolStripMenuItem.Text = resources.GetString("fileToolStripMenuItem.Text");
			this.fileToolStripMenuItem.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("fileToolStripMenuItem.TextAlign")));
			this.fileToolStripMenuItem.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("fileToolStripMenuItem.TextImageRelation")));
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.AccessibleDescription = null;
			this.closeToolStripMenuItem.AccessibleName = null;
			this.closeToolStripMenuItem.AutoSize = ((bool)(resources.GetObject("closeToolStripMenuItem.AutoSize")));
			this.closeToolStripMenuItem.BackgroundImage = null;
			this.closeToolStripMenuItem.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("closeToolStripMenuItem.BackgroundImageLayout")));
			this.closeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.closeToolStripMenuItem.Enabled = ((bool)(resources.GetObject("closeToolStripMenuItem.Enabled")));
			this.closeToolStripMenuItem.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("closeToolStripMenuItem.ImageAlign")));
			this.closeToolStripMenuItem.ImageScaling = ((System.Windows.Forms.ToolStripItemImageScaling)(resources.GetObject("closeToolStripMenuItem.ImageScaling")));
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.RightToLeftAutoMirrorImage = ((bool)(resources.GetObject("closeToolStripMenuItem.RightToLeftAutoMirrorImage")));
			this.closeToolStripMenuItem.ShortcutKeyDisplayString = null;
			this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(resources.GetObject("closeToolStripMenuItem.ShortcutKeys")));
			this.closeToolStripMenuItem.ShowShortcutKeys = ((bool)(resources.GetObject("closeToolStripMenuItem.ShowShortcutKeys")));
			this.closeToolStripMenuItem.Size = ((System.Drawing.Size)(resources.GetObject("closeToolStripMenuItem.Size")));
			this.closeToolStripMenuItem.Text = resources.GetString("closeToolStripMenuItem.Text");
			this.closeToolStripMenuItem.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("closeToolStripMenuItem.TextAlign")));
			this.closeToolStripMenuItem.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("closeToolStripMenuItem.TextImageRelation")));
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.AccessibleDescription = null;
			this.helpToolStripMenuItem.AccessibleName = null;
			this.helpToolStripMenuItem.AutoSize = ((bool)(resources.GetObject("helpToolStripMenuItem.AutoSize")));
			this.helpToolStripMenuItem.BackgroundImage = null;
			this.helpToolStripMenuItem.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("helpToolStripMenuItem.BackgroundImageLayout")));
			this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem1,
									this.toolStripMenuItem1,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Enabled = ((bool)(resources.GetObject("helpToolStripMenuItem.Enabled")));
			this.helpToolStripMenuItem.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("helpToolStripMenuItem.ImageAlign")));
			this.helpToolStripMenuItem.ImageScaling = ((System.Windows.Forms.ToolStripItemImageScaling)(resources.GetObject("helpToolStripMenuItem.ImageScaling")));
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.RightToLeftAutoMirrorImage = ((bool)(resources.GetObject("helpToolStripMenuItem.RightToLeftAutoMirrorImage")));
			this.helpToolStripMenuItem.ShortcutKeyDisplayString = null;
			this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(resources.GetObject("helpToolStripMenuItem.ShortcutKeys")));
			this.helpToolStripMenuItem.ShowShortcutKeys = ((bool)(resources.GetObject("helpToolStripMenuItem.ShowShortcutKeys")));
			this.helpToolStripMenuItem.Size = ((System.Drawing.Size)(resources.GetObject("helpToolStripMenuItem.Size")));
			this.helpToolStripMenuItem.Text = resources.GetString("helpToolStripMenuItem.Text");
			this.helpToolStripMenuItem.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("helpToolStripMenuItem.TextAlign")));
			this.helpToolStripMenuItem.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("helpToolStripMenuItem.TextImageRelation")));
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.AccessibleDescription = null;
			this.helpToolStripMenuItem1.AccessibleName = null;
			this.helpToolStripMenuItem1.AutoSize = ((bool)(resources.GetObject("helpToolStripMenuItem1.AutoSize")));
			this.helpToolStripMenuItem1.BackgroundImage = null;
			this.helpToolStripMenuItem1.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("helpToolStripMenuItem1.BackgroundImageLayout")));
			this.helpToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.helpToolStripMenuItem1.Enabled = ((bool)(resources.GetObject("helpToolStripMenuItem1.Enabled")));
			this.helpToolStripMenuItem1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("helpToolStripMenuItem1.ImageAlign")));
			this.helpToolStripMenuItem1.ImageScaling = ((System.Windows.Forms.ToolStripItemImageScaling)(resources.GetObject("helpToolStripMenuItem1.ImageScaling")));
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.RightToLeftAutoMirrorImage = ((bool)(resources.GetObject("helpToolStripMenuItem1.RightToLeftAutoMirrorImage")));
			this.helpToolStripMenuItem1.ShortcutKeyDisplayString = null;
			this.helpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(resources.GetObject("helpToolStripMenuItem1.ShortcutKeys")));
			this.helpToolStripMenuItem1.ShowShortcutKeys = ((bool)(resources.GetObject("helpToolStripMenuItem1.ShowShortcutKeys")));
			this.helpToolStripMenuItem1.Size = ((System.Drawing.Size)(resources.GetObject("helpToolStripMenuItem1.Size")));
			this.helpToolStripMenuItem1.Text = resources.GetString("helpToolStripMenuItem1.Text");
			this.helpToolStripMenuItem1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("helpToolStripMenuItem1.TextAlign")));
			this.helpToolStripMenuItem1.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("helpToolStripMenuItem1.TextImageRelation")));
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.AccessibleDescription = null;
			this.toolStripMenuItem1.AccessibleName = null;
			this.toolStripMenuItem1.AutoSize = ((bool)(resources.GetObject("toolStripMenuItem1.AutoSize")));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = ((System.Drawing.Size)(resources.GetObject("toolStripMenuItem1.Size")));
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.AccessibleDescription = null;
			this.aboutToolStripMenuItem.AccessibleName = null;
			this.aboutToolStripMenuItem.AutoSize = ((bool)(resources.GetObject("aboutToolStripMenuItem.AutoSize")));
			this.aboutToolStripMenuItem.BackgroundImage = null;
			this.aboutToolStripMenuItem.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("aboutToolStripMenuItem.BackgroundImageLayout")));
			this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.aboutToolStripMenuItem.Enabled = ((bool)(resources.GetObject("aboutToolStripMenuItem.Enabled")));
			this.aboutToolStripMenuItem.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("aboutToolStripMenuItem.ImageAlign")));
			this.aboutToolStripMenuItem.ImageScaling = ((System.Windows.Forms.ToolStripItemImageScaling)(resources.GetObject("aboutToolStripMenuItem.ImageScaling")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.RightToLeftAutoMirrorImage = ((bool)(resources.GetObject("aboutToolStripMenuItem.RightToLeftAutoMirrorImage")));
			this.aboutToolStripMenuItem.ShortcutKeyDisplayString = null;
			this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(resources.GetObject("aboutToolStripMenuItem.ShortcutKeys")));
			this.aboutToolStripMenuItem.ShowShortcutKeys = ((bool)(resources.GetObject("aboutToolStripMenuItem.ShowShortcutKeys")));
			this.aboutToolStripMenuItem.Size = ((System.Drawing.Size)(resources.GetObject("aboutToolStripMenuItem.Size")));
			this.aboutToolStripMenuItem.Text = resources.GetString("aboutToolStripMenuItem.Text");
			this.aboutToolStripMenuItem.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("aboutToolStripMenuItem.TextAlign")));
			this.aboutToolStripMenuItem.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("aboutToolStripMenuItem.TextImageRelation")));
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.AccessibleDescription = null;
			this.tabControl1.AccessibleName = null;
			this.tabControl1.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControl1.Alignment")));
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControl1.Anchor")));
			this.tabControl1.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControl1.Appearance")));
			this.tabControl1.BackgroundImage = null;
			this.tabControl1.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("tabControl1.BackgroundImageLayout")));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControl1.Dock")));
			this.tabControl1.Font = null;
			this.tabControl1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControl1.ImeMode")));
			this.tabControl1.Location = ((System.Drawing.Point)(resources.GetObject("tabControl1.Location")));
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControl1.RightToLeft")));
			this.tabControl1.RightToLeftLayout = ((bool)(resources.GetObject("tabControl1.RightToLeftLayout")));
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = ((bool)(resources.GetObject("tabControl1.ShowToolTips")));
			this.tabControl1.Size = ((System.Drawing.Size)(resources.GetObject("tabControl1.Size")));
			this.tabControl1.TabIndex = ((int)(resources.GetObject("tabControl1.TabIndex")));
			// 
			// tabPage1
			// 
			this.tabPage1.AccessibleDescription = null;
			this.tabPage1.AccessibleName = null;
			this.tabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage1.Anchor")));
			this.tabPage1.AutoScroll = ((bool)(resources.GetObject("tabPage1.AutoScroll")));
			this.tabPage1.BackgroundImage = null;
			this.tabPage1.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("tabPage1.BackgroundImageLayout")));
			this.tabPage1.Controls.Add(this.benaderingGroupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage1.Dock")));
			this.tabPage1.Font = null;
			this.tabPage1.ImageIndex = ((int)(resources.GetObject("tabPage1.ImageIndex")));
			this.tabPage1.ImageKey = resources.GetString("tabPage1.ImageKey");
			this.tabPage1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage1.ImeMode")));
			this.tabPage1.Location = ((System.Drawing.Point)(resources.GetObject("tabPage1.Location")));
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("tabPage1.Padding")));
			this.tabPage1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage1.RightToLeft")));
			this.tabPage1.Size = ((System.Drawing.Size)(resources.GetObject("tabPage1.Size")));
			this.tabPage1.TabIndex = ((int)(resources.GetObject("tabPage1.TabIndex")));
			this.tabPage1.Text = resources.GetString("tabPage1.Text");
			this.tabPage1.ToolTipText = resources.GetString("tabPage1.ToolTipText");
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// benaderingGroupBox2
			// 
			this.benaderingGroupBox2.AccessibleDescription = null;
			this.benaderingGroupBox2.AccessibleName = null;
			this.benaderingGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("benaderingGroupBox2.Anchor")));
			this.benaderingGroupBox2.AutoSize = ((bool)(resources.GetObject("benaderingGroupBox2.AutoSize")));
			this.benaderingGroupBox2.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("benaderingGroupBox2.AutoSizeMode")));
			this.benaderingGroupBox2.BackgroundImage = null;
			this.benaderingGroupBox2.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("benaderingGroupBox2.BackgroundImageLayout")));
			this.benaderingGroupBox2.Controls.Add(this.compareTextBox);
			this.benaderingGroupBox2.Controls.Add(this.label7);
			this.benaderingGroupBox2.Controls.Add(this.fuzzyComboBox);
			this.benaderingGroupBox2.Controls.Add(this.responseTextBox);
			this.benaderingGroupBox2.Controls.Add(this.originaleTextBox);
			this.benaderingGroupBox2.Controls.Add(this.label4);
			this.benaderingGroupBox2.Controls.Add(this.label5);
			this.benaderingGroupBox2.Controls.Add(this.label6);
			this.benaderingGroupBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("benaderingGroupBox2.Dock")));
			this.benaderingGroupBox2.Font = null;
			this.benaderingGroupBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("benaderingGroupBox2.ImeMode")));
			this.benaderingGroupBox2.Location = ((System.Drawing.Point)(resources.GetObject("benaderingGroupBox2.Location")));
			this.benaderingGroupBox2.Name = "benaderingGroupBox2";
			this.benaderingGroupBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("benaderingGroupBox2.RightToLeft")));
			this.benaderingGroupBox2.Size = ((System.Drawing.Size)(resources.GetObject("benaderingGroupBox2.Size")));
			this.benaderingGroupBox2.TabIndex = ((int)(resources.GetObject("benaderingGroupBox2.TabIndex")));
			this.benaderingGroupBox2.TabStop = false;
			this.benaderingGroupBox2.Text = resources.GetString("benaderingGroupBox2.Text");
			// 
			// compareTextBox
			// 
			this.compareTextBox.AccessibleDescription = null;
			this.compareTextBox.AccessibleName = null;
			this.compareTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("compareTextBox.Anchor")));
			this.compareTextBox.BackgroundImage = null;
			this.compareTextBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("compareTextBox.BackgroundImageLayout")));
			this.compareTextBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("compareTextBox.Dock")));
			this.compareTextBox.Font = null;
			this.compareTextBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("compareTextBox.ImeMode")));
			this.compareTextBox.Location = ((System.Drawing.Point)(resources.GetObject("compareTextBox.Location")));
			this.compareTextBox.MaxLength = ((int)(resources.GetObject("compareTextBox.MaxLength")));
			this.compareTextBox.Multiline = ((bool)(resources.GetObject("compareTextBox.Multiline")));
			this.compareTextBox.Name = "compareTextBox";
			this.compareTextBox.PasswordChar = ((char)(resources.GetObject("compareTextBox.PasswordChar")));
			this.compareTextBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("compareTextBox.RightToLeft")));
			this.compareTextBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("compareTextBox.ScrollBars")));
			this.compareTextBox.Size = ((System.Drawing.Size)(resources.GetObject("compareTextBox.Size")));
			this.compareTextBox.TabIndex = ((int)(resources.GetObject("compareTextBox.TabIndex")));
			this.compareTextBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("compareTextBox.TextAlign")));
			this.compareTextBox.WordWrap = ((bool)(resources.GetObject("compareTextBox.WordWrap")));
			this.compareTextBox.TextChanged += new System.EventHandler(this.Compare_TextChanged);
			// 
			// label7
			// 
			this.label7.AccessibleDescription = null;
			this.label7.AccessibleName = null;
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label7.Anchor")));
			this.label7.AutoSize = ((bool)(resources.GetObject("label7.AutoSize")));
			this.label7.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label7.BackgroundImageLayout")));
			this.label7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label7.Dock")));
			this.label7.Font = null;
			this.label7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.ImageAlign")));
			this.label7.ImageIndex = ((int)(resources.GetObject("label7.ImageIndex")));
			this.label7.ImageKey = resources.GetString("label7.ImageKey");
			this.label7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label7.ImeMode")));
			this.label7.Location = ((System.Drawing.Point)(resources.GetObject("label7.Location")));
			this.label7.Name = "label7";
			this.label7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label7.RightToLeft")));
			this.label7.Size = ((System.Drawing.Size)(resources.GetObject("label7.Size")));
			this.label7.TabIndex = ((int)(resources.GetObject("label7.TabIndex")));
			this.label7.Text = resources.GetString("label7.Text");
			this.label7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.TextAlign")));
			// 
			// fuzzyComboBox
			// 
			this.fuzzyComboBox.AccessibleDescription = null;
			this.fuzzyComboBox.AccessibleName = null;
			this.fuzzyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fuzzyComboBox.Anchor")));
			this.fuzzyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.fuzzyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.fuzzyComboBox.BackgroundImage = null;
			this.fuzzyComboBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fuzzyComboBox.BackgroundImageLayout")));
			this.fuzzyComboBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("fuzzyComboBox.Dock")));
			this.fuzzyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fuzzyComboBox.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("fuzzyComboBox.FlatStyle")));
			this.fuzzyComboBox.Font = null;
			this.fuzzyComboBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fuzzyComboBox.ImeMode")));
			this.fuzzyComboBox.IntegralHeight = ((bool)(resources.GetObject("fuzzyComboBox.IntegralHeight")));
			this.fuzzyComboBox.Items.AddRange(new object[] {
									resources.GetString("fuzzyComboBox.Items"),
									resources.GetString("fuzzyComboBox.Items1")});
			this.fuzzyComboBox.Location = ((System.Drawing.Point)(resources.GetObject("fuzzyComboBox.Location")));
			this.fuzzyComboBox.MaxDropDownItems = ((int)(resources.GetObject("fuzzyComboBox.MaxDropDownItems")));
			this.fuzzyComboBox.MaxLength = ((int)(resources.GetObject("fuzzyComboBox.MaxLength")));
			this.fuzzyComboBox.Name = "fuzzyComboBox";
			this.fuzzyComboBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("fuzzyComboBox.RightToLeft")));
			this.fuzzyComboBox.Size = ((System.Drawing.Size)(resources.GetObject("fuzzyComboBox.Size")));
			this.fuzzyComboBox.TabIndex = ((int)(resources.GetObject("fuzzyComboBox.TabIndex")));
			this.fuzzyComboBox.SelectedValueChanged += new System.EventHandler(this.fuzzyComboBox_SelectedIndexChanged);
			// 
			// responseTextBox
			// 
			this.responseTextBox.AccessibleDescription = null;
			this.responseTextBox.AccessibleName = null;
			this.responseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("responseTextBox.Anchor")));
			this.responseTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.responseTextBox.BackgroundImage = null;
			this.responseTextBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("responseTextBox.BackgroundImageLayout")));
			this.responseTextBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("responseTextBox.Dock")));
			this.responseTextBox.Font = null;
			this.responseTextBox.HideSelection = false;
			this.responseTextBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("responseTextBox.ImeMode")));
			this.responseTextBox.Location = ((System.Drawing.Point)(resources.GetObject("responseTextBox.Location")));
			this.responseTextBox.MaxLength = ((int)(resources.GetObject("responseTextBox.MaxLength")));
			this.responseTextBox.Multiline = ((bool)(resources.GetObject("responseTextBox.Multiline")));
			this.responseTextBox.Name = "responseTextBox";
			this.responseTextBox.PasswordChar = ((char)(resources.GetObject("responseTextBox.PasswordChar")));
			this.responseTextBox.ReadOnly = true;
			this.responseTextBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("responseTextBox.RightToLeft")));
			this.responseTextBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("responseTextBox.ScrollBars")));
			this.responseTextBox.Size = ((System.Drawing.Size)(resources.GetObject("responseTextBox.Size")));
			this.responseTextBox.TabIndex = ((int)(resources.GetObject("responseTextBox.TabIndex")));
			this.responseTextBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("responseTextBox.TextAlign")));
			this.responseTextBox.WordWrap = ((bool)(resources.GetObject("responseTextBox.WordWrap")));
			// 
			// originaleTextBox
			// 
			this.originaleTextBox.AccessibleDescription = null;
			this.originaleTextBox.AccessibleName = null;
			this.originaleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("originaleTextBox.Anchor")));
			this.originaleTextBox.BackgroundImage = null;
			this.originaleTextBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("originaleTextBox.BackgroundImageLayout")));
			this.originaleTextBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("originaleTextBox.Dock")));
			this.originaleTextBox.Font = null;
			this.originaleTextBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("originaleTextBox.ImeMode")));
			this.originaleTextBox.Location = ((System.Drawing.Point)(resources.GetObject("originaleTextBox.Location")));
			this.originaleTextBox.MaxLength = ((int)(resources.GetObject("originaleTextBox.MaxLength")));
			this.originaleTextBox.Multiline = ((bool)(resources.GetObject("originaleTextBox.Multiline")));
			this.originaleTextBox.Name = "originaleTextBox";
			this.originaleTextBox.PasswordChar = ((char)(resources.GetObject("originaleTextBox.PasswordChar")));
			this.originaleTextBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("originaleTextBox.RightToLeft")));
			this.originaleTextBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("originaleTextBox.ScrollBars")));
			this.originaleTextBox.Size = ((System.Drawing.Size)(resources.GetObject("originaleTextBox.Size")));
			this.originaleTextBox.TabIndex = ((int)(resources.GetObject("originaleTextBox.TabIndex")));
			this.originaleTextBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("originaleTextBox.TextAlign")));
			this.originaleTextBox.WordWrap = ((bool)(resources.GetObject("originaleTextBox.WordWrap")));
			this.originaleTextBox.TextChanged += new System.EventHandler(this.Compare_TextChanged);
			// 
			// label4
			// 
			this.label4.AccessibleDescription = null;
			this.label4.AccessibleName = null;
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label4.BackgroundImageLayout")));
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Font = null;
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImageKey = resources.GetString("label4.ImageKey");
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			// 
			// label5
			// 
			this.label5.AccessibleDescription = null;
			this.label5.AccessibleName = null;
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
			this.label5.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label5.BackgroundImageLayout")));
			this.label5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label5.Dock")));
			this.label5.Font = null;
			this.label5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.ImageAlign")));
			this.label5.ImageIndex = ((int)(resources.GetObject("label5.ImageIndex")));
			this.label5.ImageKey = resources.GetString("label5.ImageKey");
			this.label5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label5.ImeMode")));
			this.label5.Location = ((System.Drawing.Point)(resources.GetObject("label5.Location")));
			this.label5.Name = "label5";
			this.label5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label5.RightToLeft")));
			this.label5.Size = ((System.Drawing.Size)(resources.GetObject("label5.Size")));
			this.label5.TabIndex = ((int)(resources.GetObject("label5.TabIndex")));
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.TextAlign")));
			// 
			// label6
			// 
			this.label6.AccessibleDescription = null;
			this.label6.AccessibleName = null;
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label6.Anchor")));
			this.label6.AutoSize = ((bool)(resources.GetObject("label6.AutoSize")));
			this.label6.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label6.BackgroundImageLayout")));
			this.label6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label6.Dock")));
			this.label6.Font = null;
			this.label6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.ImageAlign")));
			this.label6.ImageIndex = ((int)(resources.GetObject("label6.ImageIndex")));
			this.label6.ImageKey = resources.GetString("label6.ImageKey");
			this.label6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label6.ImeMode")));
			this.label6.Location = ((System.Drawing.Point)(resources.GetObject("label6.Location")));
			this.label6.Name = "label6";
			this.label6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label6.RightToLeft")));
			this.label6.Size = ((System.Drawing.Size)(resources.GetObject("label6.Size")));
			this.label6.TabIndex = ((int)(resources.GetObject("label6.TabIndex")));
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.TextAlign")));
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = null;
			this.groupBox1.AccessibleName = null;
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.AutoSize = ((bool)(resources.GetObject("groupBox1.AutoSize")));
			this.groupBox1.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("groupBox1.AutoSizeMode")));
			this.groupBox1.BackgroundImage = null;
			this.groupBox1.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("groupBox1.BackgroundImageLayout")));
			this.groupBox1.Controls.Add(this.alternateTextBox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.phoneticComboBox);
			this.groupBox1.Controls.Add(this.primaryTextBox);
			this.groupBox1.Controls.Add(this.inputTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox1.Dock")));
			this.groupBox1.Font = null;
			this.groupBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox1.ImeMode")));
			this.groupBox1.Location = ((System.Drawing.Point)(resources.GetObject("groupBox1.Location")));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox1.RightToLeft")));
			this.groupBox1.Size = ((System.Drawing.Size)(resources.GetObject("groupBox1.Size")));
			this.groupBox1.TabIndex = ((int)(resources.GetObject("groupBox1.TabIndex")));
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = resources.GetString("groupBox1.Text");
			// 
			// alternateTextBox
			// 
			this.alternateTextBox.AccessibleDescription = null;
			this.alternateTextBox.AccessibleName = null;
			this.alternateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("alternateTextBox.Anchor")));
			this.alternateTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.alternateTextBox.BackgroundImage = null;
			this.alternateTextBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("alternateTextBox.BackgroundImageLayout")));
			this.alternateTextBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("alternateTextBox.Dock")));
			this.alternateTextBox.Font = null;
			this.alternateTextBox.HideSelection = false;
			this.alternateTextBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("alternateTextBox.ImeMode")));
			this.alternateTextBox.Location = ((System.Drawing.Point)(resources.GetObject("alternateTextBox.Location")));
			this.alternateTextBox.MaxLength = ((int)(resources.GetObject("alternateTextBox.MaxLength")));
			this.alternateTextBox.Multiline = ((bool)(resources.GetObject("alternateTextBox.Multiline")));
			this.alternateTextBox.Name = "alternateTextBox";
			this.alternateTextBox.PasswordChar = ((char)(resources.GetObject("alternateTextBox.PasswordChar")));
			this.alternateTextBox.ReadOnly = true;
			this.alternateTextBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("alternateTextBox.RightToLeft")));
			this.alternateTextBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("alternateTextBox.ScrollBars")));
			this.alternateTextBox.Size = ((System.Drawing.Size)(resources.GetObject("alternateTextBox.Size")));
			this.alternateTextBox.TabIndex = ((int)(resources.GetObject("alternateTextBox.TabIndex")));
			this.alternateTextBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("alternateTextBox.TextAlign")));
			this.alternateTextBox.WordWrap = ((bool)(resources.GetObject("alternateTextBox.WordWrap")));
			// 
			// label8
			// 
			this.label8.AccessibleDescription = null;
			this.label8.AccessibleName = null;
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label8.Anchor")));
			this.label8.AutoSize = ((bool)(resources.GetObject("label8.AutoSize")));
			this.label8.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label8.BackgroundImageLayout")));
			this.label8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label8.Dock")));
			this.label8.Font = null;
			this.label8.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.ImageAlign")));
			this.label8.ImageIndex = ((int)(resources.GetObject("label8.ImageIndex")));
			this.label8.ImageKey = resources.GetString("label8.ImageKey");
			this.label8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label8.ImeMode")));
			this.label8.Location = ((System.Drawing.Point)(resources.GetObject("label8.Location")));
			this.label8.Name = "label8";
			this.label8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label8.RightToLeft")));
			this.label8.Size = ((System.Drawing.Size)(resources.GetObject("label8.Size")));
			this.label8.TabIndex = ((int)(resources.GetObject("label8.TabIndex")));
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.TextAlign")));
			// 
			// phoneticComboBox
			// 
			this.phoneticComboBox.AccessibleDescription = null;
			this.phoneticComboBox.AccessibleName = null;
			this.phoneticComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("phoneticComboBox.Anchor")));
			this.phoneticComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.phoneticComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.phoneticComboBox.BackgroundImage = null;
			this.phoneticComboBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("phoneticComboBox.BackgroundImageLayout")));
			this.phoneticComboBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("phoneticComboBox.Dock")));
			this.phoneticComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.phoneticComboBox.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("phoneticComboBox.FlatStyle")));
			this.phoneticComboBox.Font = null;
			this.phoneticComboBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("phoneticComboBox.ImeMode")));
			this.phoneticComboBox.IntegralHeight = ((bool)(resources.GetObject("phoneticComboBox.IntegralHeight")));
			this.phoneticComboBox.Items.AddRange(new object[] {
									resources.GetString("phoneticComboBox.Items"),
									resources.GetString("phoneticComboBox.Items1"),
									resources.GetString("phoneticComboBox.Items2"),
									resources.GetString("phoneticComboBox.Items3")});
			this.phoneticComboBox.Location = ((System.Drawing.Point)(resources.GetObject("phoneticComboBox.Location")));
			this.phoneticComboBox.MaxDropDownItems = ((int)(resources.GetObject("phoneticComboBox.MaxDropDownItems")));
			this.phoneticComboBox.MaxLength = ((int)(resources.GetObject("phoneticComboBox.MaxLength")));
			this.phoneticComboBox.Name = "phoneticComboBox";
			this.phoneticComboBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("phoneticComboBox.RightToLeft")));
			this.phoneticComboBox.Size = ((System.Drawing.Size)(resources.GetObject("phoneticComboBox.Size")));
			this.phoneticComboBox.TabIndex = ((int)(resources.GetObject("phoneticComboBox.TabIndex")));
			this.phoneticComboBox.SelectedValueChanged += new System.EventHandler(this.Phonetic_SelectedIndexChanged);
			// 
			// primaryTextBox
			// 
			this.primaryTextBox.AccessibleDescription = null;
			this.primaryTextBox.AccessibleName = null;
			this.primaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("primaryTextBox.Anchor")));
			this.primaryTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.primaryTextBox.BackgroundImage = null;
			this.primaryTextBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("primaryTextBox.BackgroundImageLayout")));
			this.primaryTextBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("primaryTextBox.Dock")));
			this.primaryTextBox.Font = null;
			this.primaryTextBox.HideSelection = false;
			this.primaryTextBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("primaryTextBox.ImeMode")));
			this.primaryTextBox.Location = ((System.Drawing.Point)(resources.GetObject("primaryTextBox.Location")));
			this.primaryTextBox.MaxLength = ((int)(resources.GetObject("primaryTextBox.MaxLength")));
			this.primaryTextBox.Multiline = ((bool)(resources.GetObject("primaryTextBox.Multiline")));
			this.primaryTextBox.Name = "primaryTextBox";
			this.primaryTextBox.PasswordChar = ((char)(resources.GetObject("primaryTextBox.PasswordChar")));
			this.primaryTextBox.ReadOnly = true;
			this.primaryTextBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("primaryTextBox.RightToLeft")));
			this.primaryTextBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("primaryTextBox.ScrollBars")));
			this.primaryTextBox.Size = ((System.Drawing.Size)(resources.GetObject("primaryTextBox.Size")));
			this.primaryTextBox.TabIndex = ((int)(resources.GetObject("primaryTextBox.TabIndex")));
			this.primaryTextBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("primaryTextBox.TextAlign")));
			this.primaryTextBox.WordWrap = ((bool)(resources.GetObject("primaryTextBox.WordWrap")));
			// 
			// inputTextBox
			// 
			this.inputTextBox.AccessibleDescription = null;
			this.inputTextBox.AccessibleName = null;
			this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("inputTextBox.Anchor")));
			this.inputTextBox.BackgroundImage = null;
			this.inputTextBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("inputTextBox.BackgroundImageLayout")));
			this.inputTextBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("inputTextBox.Dock")));
			this.inputTextBox.Font = null;
			this.inputTextBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("inputTextBox.ImeMode")));
			this.inputTextBox.Location = ((System.Drawing.Point)(resources.GetObject("inputTextBox.Location")));
			this.inputTextBox.MaxLength = ((int)(resources.GetObject("inputTextBox.MaxLength")));
			this.inputTextBox.Multiline = ((bool)(resources.GetObject("inputTextBox.Multiline")));
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.PasswordChar = ((char)(resources.GetObject("inputTextBox.PasswordChar")));
			this.inputTextBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("inputTextBox.RightToLeft")));
			this.inputTextBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("inputTextBox.ScrollBars")));
			this.inputTextBox.Size = ((System.Drawing.Size)(resources.GetObject("inputTextBox.Size")));
			this.inputTextBox.TabIndex = ((int)(resources.GetObject("inputTextBox.TabIndex")));
			this.inputTextBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("inputTextBox.TextAlign")));
			this.inputTextBox.WordWrap = ((bool)(resources.GetObject("inputTextBox.WordWrap")));
			this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
			// 
			// label3
			// 
			this.label3.AccessibleDescription = null;
			this.label3.AccessibleName = null;
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label3.BackgroundImageLayout")));
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Font = null;
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImageKey = resources.GetString("label3.ImageKey");
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			// 
			// label1
			// 
			this.label1.AccessibleDescription = null;
			this.label1.AccessibleName = null;
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label1.BackgroundImageLayout")));
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Font = null;
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImageKey = resources.GetString("label1.ImageKey");
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = null;
			this.label2.AccessibleName = null;
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label2.BackgroundImageLayout")));
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Font = null;
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImageKey = resources.GetString("label2.ImageKey");
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			// 
			// tabPage2
			// 
			this.tabPage2.AccessibleDescription = null;
			this.tabPage2.AccessibleName = null;
			this.tabPage2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage2.Anchor")));
			this.tabPage2.AutoScroll = ((bool)(resources.GetObject("tabPage2.AutoScroll")));
			this.tabPage2.BackgroundImage = null;
			this.tabPage2.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("tabPage2.BackgroundImageLayout")));
			this.tabPage2.Controls.Add(this.totaleTimeGroupBox);
			this.tabPage2.Controls.Add(this.infoLabel);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage2.Dock")));
			this.tabPage2.Font = null;
			this.tabPage2.ImageIndex = ((int)(resources.GetObject("tabPage2.ImageIndex")));
			this.tabPage2.ImageKey = resources.GetString("tabPage2.ImageKey");
			this.tabPage2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage2.ImeMode")));
			this.tabPage2.Location = ((System.Drawing.Point)(resources.GetObject("tabPage2.Location")));
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("tabPage2.Padding")));
			this.tabPage2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage2.RightToLeft")));
			this.tabPage2.Size = ((System.Drawing.Size)(resources.GetObject("tabPage2.Size")));
			this.tabPage2.TabIndex = ((int)(resources.GetObject("tabPage2.TabIndex")));
			this.tabPage2.Text = resources.GetString("tabPage2.Text");
			this.tabPage2.ToolTipText = resources.GetString("tabPage2.ToolTipText");
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// totaleTimeGroupBox
			// 
			this.totaleTimeGroupBox.AccessibleDescription = null;
			this.totaleTimeGroupBox.AccessibleName = null;
			this.totaleTimeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("totaleTimeGroupBox.Anchor")));
			this.totaleTimeGroupBox.AutoSize = ((bool)(resources.GetObject("totaleTimeGroupBox.AutoSize")));
			this.totaleTimeGroupBox.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("totaleTimeGroupBox.AutoSizeMode")));
			this.totaleTimeGroupBox.BackgroundImage = null;
			this.totaleTimeGroupBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("totaleTimeGroupBox.BackgroundImageLayout")));
			this.totaleTimeGroupBox.Controls.Add(this.dmetaphoneLabel);
			this.totaleTimeGroupBox.Controls.Add(this.label16);
			this.totaleTimeGroupBox.Controls.Add(this.metaphoneLabel);
			this.totaleTimeGroupBox.Controls.Add(this.label14);
			this.totaleTimeGroupBox.Controls.Add(this.dmLabel);
			this.totaleTimeGroupBox.Controls.Add(this.label12);
			this.totaleTimeGroupBox.Controls.Add(this.soundexLabel);
			this.totaleTimeGroupBox.Controls.Add(this.label9);
			this.totaleTimeGroupBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("totaleTimeGroupBox.Dock")));
			this.totaleTimeGroupBox.Font = null;
			this.totaleTimeGroupBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("totaleTimeGroupBox.ImeMode")));
			this.totaleTimeGroupBox.Location = ((System.Drawing.Point)(resources.GetObject("totaleTimeGroupBox.Location")));
			this.totaleTimeGroupBox.Name = "totaleTimeGroupBox";
			this.totaleTimeGroupBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("totaleTimeGroupBox.RightToLeft")));
			this.totaleTimeGroupBox.Size = ((System.Drawing.Size)(resources.GetObject("totaleTimeGroupBox.Size")));
			this.totaleTimeGroupBox.TabIndex = ((int)(resources.GetObject("totaleTimeGroupBox.TabIndex")));
			this.totaleTimeGroupBox.TabStop = false;
			this.totaleTimeGroupBox.Text = resources.GetString("totaleTimeGroupBox.Text");
			// 
			// dmetaphoneLabel
			// 
			this.dmetaphoneLabel.AccessibleDescription = null;
			this.dmetaphoneLabel.AccessibleName = null;
			this.dmetaphoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dmetaphoneLabel.Anchor")));
			this.dmetaphoneLabel.AutoSize = ((bool)(resources.GetObject("dmetaphoneLabel.AutoSize")));
			this.dmetaphoneLabel.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("dmetaphoneLabel.BackgroundImageLayout")));
			this.dmetaphoneLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dmetaphoneLabel.Dock")));
			this.dmetaphoneLabel.Font = null;
			this.dmetaphoneLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dmetaphoneLabel.ImageAlign")));
			this.dmetaphoneLabel.ImageIndex = ((int)(resources.GetObject("dmetaphoneLabel.ImageIndex")));
			this.dmetaphoneLabel.ImageKey = resources.GetString("dmetaphoneLabel.ImageKey");
			this.dmetaphoneLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dmetaphoneLabel.ImeMode")));
			this.dmetaphoneLabel.Location = ((System.Drawing.Point)(resources.GetObject("dmetaphoneLabel.Location")));
			this.dmetaphoneLabel.Name = "dmetaphoneLabel";
			this.dmetaphoneLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dmetaphoneLabel.RightToLeft")));
			this.dmetaphoneLabel.Size = ((System.Drawing.Size)(resources.GetObject("dmetaphoneLabel.Size")));
			this.dmetaphoneLabel.TabIndex = ((int)(resources.GetObject("dmetaphoneLabel.TabIndex")));
			this.dmetaphoneLabel.Text = resources.GetString("dmetaphoneLabel.Text");
			this.dmetaphoneLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dmetaphoneLabel.TextAlign")));
			// 
			// label16
			// 
			this.label16.AccessibleDescription = null;
			this.label16.AccessibleName = null;
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label16.Anchor")));
			this.label16.AutoSize = ((bool)(resources.GetObject("label16.AutoSize")));
			this.label16.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label16.BackgroundImageLayout")));
			this.label16.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label16.Dock")));
			this.label16.Font = null;
			this.label16.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label16.ImageAlign")));
			this.label16.ImageIndex = ((int)(resources.GetObject("label16.ImageIndex")));
			this.label16.ImageKey = resources.GetString("label16.ImageKey");
			this.label16.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label16.ImeMode")));
			this.label16.Location = ((System.Drawing.Point)(resources.GetObject("label16.Location")));
			this.label16.Name = "label16";
			this.label16.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label16.RightToLeft")));
			this.label16.Size = ((System.Drawing.Size)(resources.GetObject("label16.Size")));
			this.label16.TabIndex = ((int)(resources.GetObject("label16.TabIndex")));
			this.label16.Text = resources.GetString("label16.Text");
			this.label16.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label16.TextAlign")));
			// 
			// metaphoneLabel
			// 
			this.metaphoneLabel.AccessibleDescription = null;
			this.metaphoneLabel.AccessibleName = null;
			this.metaphoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("metaphoneLabel.Anchor")));
			this.metaphoneLabel.AutoSize = ((bool)(resources.GetObject("metaphoneLabel.AutoSize")));
			this.metaphoneLabel.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("metaphoneLabel.BackgroundImageLayout")));
			this.metaphoneLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("metaphoneLabel.Dock")));
			this.metaphoneLabel.Font = null;
			this.metaphoneLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("metaphoneLabel.ImageAlign")));
			this.metaphoneLabel.ImageIndex = ((int)(resources.GetObject("metaphoneLabel.ImageIndex")));
			this.metaphoneLabel.ImageKey = resources.GetString("metaphoneLabel.ImageKey");
			this.metaphoneLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("metaphoneLabel.ImeMode")));
			this.metaphoneLabel.Location = ((System.Drawing.Point)(resources.GetObject("metaphoneLabel.Location")));
			this.metaphoneLabel.Name = "metaphoneLabel";
			this.metaphoneLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("metaphoneLabel.RightToLeft")));
			this.metaphoneLabel.Size = ((System.Drawing.Size)(resources.GetObject("metaphoneLabel.Size")));
			this.metaphoneLabel.TabIndex = ((int)(resources.GetObject("metaphoneLabel.TabIndex")));
			this.metaphoneLabel.Text = resources.GetString("metaphoneLabel.Text");
			this.metaphoneLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("metaphoneLabel.TextAlign")));
			// 
			// label14
			// 
			this.label14.AccessibleDescription = null;
			this.label14.AccessibleName = null;
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label14.Anchor")));
			this.label14.AutoSize = ((bool)(resources.GetObject("label14.AutoSize")));
			this.label14.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label14.BackgroundImageLayout")));
			this.label14.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label14.Dock")));
			this.label14.Font = null;
			this.label14.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label14.ImageAlign")));
			this.label14.ImageIndex = ((int)(resources.GetObject("label14.ImageIndex")));
			this.label14.ImageKey = resources.GetString("label14.ImageKey");
			this.label14.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label14.ImeMode")));
			this.label14.Location = ((System.Drawing.Point)(resources.GetObject("label14.Location")));
			this.label14.Name = "label14";
			this.label14.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label14.RightToLeft")));
			this.label14.Size = ((System.Drawing.Size)(resources.GetObject("label14.Size")));
			this.label14.TabIndex = ((int)(resources.GetObject("label14.TabIndex")));
			this.label14.Text = resources.GetString("label14.Text");
			this.label14.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label14.TextAlign")));
			// 
			// dmLabel
			// 
			this.dmLabel.AccessibleDescription = null;
			this.dmLabel.AccessibleName = null;
			this.dmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dmLabel.Anchor")));
			this.dmLabel.AutoSize = ((bool)(resources.GetObject("dmLabel.AutoSize")));
			this.dmLabel.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("dmLabel.BackgroundImageLayout")));
			this.dmLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dmLabel.Dock")));
			this.dmLabel.Font = null;
			this.dmLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dmLabel.ImageAlign")));
			this.dmLabel.ImageIndex = ((int)(resources.GetObject("dmLabel.ImageIndex")));
			this.dmLabel.ImageKey = resources.GetString("dmLabel.ImageKey");
			this.dmLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dmLabel.ImeMode")));
			this.dmLabel.Location = ((System.Drawing.Point)(resources.GetObject("dmLabel.Location")));
			this.dmLabel.Name = "dmLabel";
			this.dmLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dmLabel.RightToLeft")));
			this.dmLabel.Size = ((System.Drawing.Size)(resources.GetObject("dmLabel.Size")));
			this.dmLabel.TabIndex = ((int)(resources.GetObject("dmLabel.TabIndex")));
			this.dmLabel.Text = resources.GetString("dmLabel.Text");
			this.dmLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dmLabel.TextAlign")));
			// 
			// label12
			// 
			this.label12.AccessibleDescription = null;
			this.label12.AccessibleName = null;
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label12.Anchor")));
			this.label12.AutoSize = ((bool)(resources.GetObject("label12.AutoSize")));
			this.label12.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label12.BackgroundImageLayout")));
			this.label12.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label12.Dock")));
			this.label12.Font = null;
			this.label12.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label12.ImageAlign")));
			this.label12.ImageIndex = ((int)(resources.GetObject("label12.ImageIndex")));
			this.label12.ImageKey = resources.GetString("label12.ImageKey");
			this.label12.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label12.ImeMode")));
			this.label12.Location = ((System.Drawing.Point)(resources.GetObject("label12.Location")));
			this.label12.Name = "label12";
			this.label12.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label12.RightToLeft")));
			this.label12.Size = ((System.Drawing.Size)(resources.GetObject("label12.Size")));
			this.label12.TabIndex = ((int)(resources.GetObject("label12.TabIndex")));
			this.label12.Text = resources.GetString("label12.Text");
			this.label12.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label12.TextAlign")));
			// 
			// soundexLabel
			// 
			this.soundexLabel.AccessibleDescription = null;
			this.soundexLabel.AccessibleName = null;
			this.soundexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("soundexLabel.Anchor")));
			this.soundexLabel.AutoSize = ((bool)(resources.GetObject("soundexLabel.AutoSize")));
			this.soundexLabel.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("soundexLabel.BackgroundImageLayout")));
			this.soundexLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("soundexLabel.Dock")));
			this.soundexLabel.Font = null;
			this.soundexLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("soundexLabel.ImageAlign")));
			this.soundexLabel.ImageIndex = ((int)(resources.GetObject("soundexLabel.ImageIndex")));
			this.soundexLabel.ImageKey = resources.GetString("soundexLabel.ImageKey");
			this.soundexLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("soundexLabel.ImeMode")));
			this.soundexLabel.Location = ((System.Drawing.Point)(resources.GetObject("soundexLabel.Location")));
			this.soundexLabel.Name = "soundexLabel";
			this.soundexLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("soundexLabel.RightToLeft")));
			this.soundexLabel.Size = ((System.Drawing.Size)(resources.GetObject("soundexLabel.Size")));
			this.soundexLabel.TabIndex = ((int)(resources.GetObject("soundexLabel.TabIndex")));
			this.soundexLabel.Text = resources.GetString("soundexLabel.Text");
			this.soundexLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("soundexLabel.TextAlign")));
			// 
			// label9
			// 
			this.label9.AccessibleDescription = null;
			this.label9.AccessibleName = null;
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label9.Anchor")));
			this.label9.AutoSize = ((bool)(resources.GetObject("label9.AutoSize")));
			this.label9.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("label9.BackgroundImageLayout")));
			this.label9.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label9.Dock")));
			this.label9.Font = null;
			this.label9.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.ImageAlign")));
			this.label9.ImageIndex = ((int)(resources.GetObject("label9.ImageIndex")));
			this.label9.ImageKey = resources.GetString("label9.ImageKey");
			this.label9.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label9.ImeMode")));
			this.label9.Location = ((System.Drawing.Point)(resources.GetObject("label9.Location")));
			this.label9.Name = "label9";
			this.label9.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label9.RightToLeft")));
			this.label9.Size = ((System.Drawing.Size)(resources.GetObject("label9.Size")));
			this.label9.TabIndex = ((int)(resources.GetObject("label9.TabIndex")));
			this.label9.Text = resources.GetString("label9.Text");
			this.label9.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.TextAlign")));
			// 
			// infoLabel
			// 
			this.infoLabel.AccessibleDescription = null;
			this.infoLabel.AccessibleName = null;
			this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("infoLabel.Anchor")));
			this.infoLabel.AutoSize = ((bool)(resources.GetObject("infoLabel.AutoSize")));
			this.infoLabel.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("infoLabel.BackgroundImageLayout")));
			this.infoLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("infoLabel.Dock")));
			this.infoLabel.Font = null;
			this.infoLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("infoLabel.ImageAlign")));
			this.infoLabel.ImageIndex = ((int)(resources.GetObject("infoLabel.ImageIndex")));
			this.infoLabel.ImageKey = resources.GetString("infoLabel.ImageKey");
			this.infoLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("infoLabel.ImeMode")));
			this.infoLabel.Location = ((System.Drawing.Point)(resources.GetObject("infoLabel.Location")));
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("infoLabel.RightToLeft")));
			this.infoLabel.Size = ((System.Drawing.Size)(resources.GetObject("infoLabel.Size")));
			this.infoLabel.TabIndex = ((int)(resources.GetObject("infoLabel.TabIndex")));
			this.infoLabel.Text = resources.GetString("infoLabel.Text");
			this.infoLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("infoLabel.TextAlign")));
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleDescription = null;
			this.groupBox2.AccessibleName = null;
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox2.Anchor")));
			this.groupBox2.AutoSize = ((bool)(resources.GetObject("groupBox2.AutoSize")));
			this.groupBox2.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("groupBox2.AutoSizeMode")));
			this.groupBox2.BackgroundImage = null;
			this.groupBox2.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("groupBox2.BackgroundImageLayout")));
			this.groupBox2.Controls.Add(this.wordListTextBox);
			this.groupBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox2.Dock")));
			this.groupBox2.Font = null;
			this.groupBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox2.ImeMode")));
			this.groupBox2.Location = ((System.Drawing.Point)(resources.GetObject("groupBox2.Location")));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox2.RightToLeft")));
			this.groupBox2.Size = ((System.Drawing.Size)(resources.GetObject("groupBox2.Size")));
			this.groupBox2.TabIndex = ((int)(resources.GetObject("groupBox2.TabIndex")));
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = resources.GetString("groupBox2.Text");
			// 
			// wordListTextBox
			// 
			this.wordListTextBox.AccessibleDescription = null;
			this.wordListTextBox.AccessibleName = null;
			this.wordListTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wordListTextBox.Anchor")));
			this.wordListTextBox.BackgroundImage = null;
			this.wordListTextBox.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("wordListTextBox.BackgroundImageLayout")));
			this.wordListTextBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wordListTextBox.Dock")));
			this.wordListTextBox.Font = null;
			this.wordListTextBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wordListTextBox.ImeMode")));
			this.wordListTextBox.Location = ((System.Drawing.Point)(resources.GetObject("wordListTextBox.Location")));
			this.wordListTextBox.MaxLength = ((int)(resources.GetObject("wordListTextBox.MaxLength")));
			this.wordListTextBox.Multiline = ((bool)(resources.GetObject("wordListTextBox.Multiline")));
			this.wordListTextBox.Name = "wordListTextBox";
			this.wordListTextBox.PasswordChar = ((char)(resources.GetObject("wordListTextBox.PasswordChar")));
			this.wordListTextBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wordListTextBox.RightToLeft")));
			this.wordListTextBox.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("wordListTextBox.ScrollBars")));
			this.wordListTextBox.Size = ((System.Drawing.Size)(resources.GetObject("wordListTextBox.Size")));
			this.wordListTextBox.TabIndex = ((int)(resources.GetObject("wordListTextBox.TabIndex")));
			this.wordListTextBox.Text = resources.GetString("wordListTextBox.Text");
			this.wordListTextBox.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("wordListTextBox.TextAlign")));
			this.wordListTextBox.WordWrap = ((bool)(resources.GetObject("wordListTextBox.WordWrap")));
			// 
			// button1
			// 
			this.button1.AccessibleDescription = null;
			this.button1.AccessibleName = null;
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.AutoSize = ((bool)(resources.GetObject("button1.AutoSize")));
			this.button1.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("button1.AutoSizeMode")));
			this.button1.BackgroundImage = null;
			this.button1.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("button1.BackgroundImageLayout")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = null;
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImageKey = resources.GetString("button1.ImageKey");
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.button1.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("button1.TextImageRelation")));
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// closeButton
			// 
			this.closeButton.AccessibleDescription = null;
			this.closeButton.AccessibleName = null;
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("closeButton.Anchor")));
			this.closeButton.AutoSize = ((bool)(resources.GetObject("closeButton.AutoSize")));
			this.closeButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("closeButton.AutoSizeMode")));
			this.closeButton.BackgroundImage = null;
			this.closeButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("closeButton.BackgroundImageLayout")));
			this.closeButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("closeButton.Dock")));
			this.closeButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("closeButton.FlatStyle")));
			this.closeButton.Font = null;
			this.closeButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("closeButton.ImageAlign")));
			this.closeButton.ImageIndex = ((int)(resources.GetObject("closeButton.ImageIndex")));
			this.closeButton.ImageKey = resources.GetString("closeButton.ImageKey");
			this.closeButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("closeButton.ImeMode")));
			this.closeButton.Location = ((System.Drawing.Point)(resources.GetObject("closeButton.Location")));
			this.closeButton.Name = "closeButton";
			this.closeButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("closeButton.RightToLeft")));
			this.closeButton.Size = ((System.Drawing.Size)(resources.GetObject("closeButton.Size")));
			this.closeButton.TabIndex = ((int)(resources.GetObject("closeButton.TabIndex")));
			this.closeButton.Text = resources.GetString("closeButton.Text");
			this.closeButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("closeButton.TextAlign")));
			this.closeButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("closeButton.TextImageRelation")));
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
			// 
			// MainForm
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			this.AutoScaleDimensions = ((System.Drawing.SizeF)(resources.GetObject("$this.AutoScaleDimensions")));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoSize = ((bool)(resources.GetObject("$this.AutoSize")));
			this.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("$this.AutoSizeMode")));
			this.BackgroundImage = null;
			this.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("$this.BackgroundImageLayout")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.Font = null;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = null;
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.Name = "MainForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.RightToLeftLayout = ((bool)(resources.GetObject("$this.RightToLeftLayout")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.benaderingGroupBox2.ResumeLayout(false);
			this.benaderingGroupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.totaleTimeGroupBox.ResumeLayout(false);
			this.totaleTimeGroupBox.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox benaderingGroupBox2;
        private System.Windows.Forms.TextBox compareTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fuzzyComboBox;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.TextBox originaleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox alternateTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox phoneticComboBox;
        private System.Windows.Forms.TextBox primaryTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox wordListTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox totaleTimeGroupBox;
        private System.Windows.Forms.Label dmetaphoneLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label metaphoneLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label dmLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label soundexLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button closeButton;
	}
}
