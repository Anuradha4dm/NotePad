namespace nodepad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.fIndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timedateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editItemMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItem,
            this.openItemMenu,
            this.saveItemMenu,
            this.saveAsItemMenu,
            this.toolStripMenuItem1,
            this.pageSetupToolStripMenuItem,
            this.exitItemMenu});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // newItem
            // 
            this.newItem.Name = "newItem";
            this.newItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newItem.Size = new System.Drawing.Size(184, 22);
            this.newItem.Text = "New";
            this.newItem.Click += new System.EventHandler(this.newItem_Click);
            // 
            // openItemMenu
            // 
            this.openItemMenu.Name = "openItemMenu";
            this.openItemMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openItemMenu.Size = new System.Drawing.Size(184, 22);
            this.openItemMenu.Text = "Open";
            this.openItemMenu.Click += new System.EventHandler(this.openItemMenu_Click);
            // 
            // saveItemMenu
            // 
            this.saveItemMenu.Name = "saveItemMenu";
            this.saveItemMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveItemMenu.Size = new System.Drawing.Size(184, 22);
            this.saveItemMenu.Text = "Save";
            this.saveItemMenu.Click += new System.EventHandler(this.saveItemMenu_Click);
            // 
            // saveAsItemMenu
            // 
            this.saveAsItemMenu.Name = "saveAsItemMenu";
            this.saveAsItemMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsItemMenu.Size = new System.Drawing.Size(184, 22);
            this.saveAsItemMenu.Text = "Save as";
            this.saveAsItemMenu.Click += new System.EventHandler(this.saveAsItemMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            // 
            // exitItemMenu
            // 
            this.exitItemMenu.Name = "exitItemMenu";
            this.exitItemMenu.Size = new System.Drawing.Size(184, 22);
            this.exitItemMenu.Text = "Exit";
            this.exitItemMenu.Click += new System.EventHandler(this.exitItemMenu_Click);
            // 
            // editItemMenu
            // 
            this.editItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoItem,
            this.toolStripMenuItem2,
            this.cutItem,
            this.copyItem,
            this.pasteItem,
            this.deleteItem,
            this.toolStripMenuItem3,
            this.fIndToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.toolStripMenuItem4,
            this.selectAllItem,
            this.timedateToolStripMenuItem});
            this.editItemMenu.Name = "editItemMenu";
            this.editItemMenu.Size = new System.Drawing.Size(39, 20);
            this.editItemMenu.Text = "Edit";
            this.editItemMenu.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // undoItem
            // 
            this.undoItem.Name = "undoItem";
            this.undoItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoItem.Size = new System.Drawing.Size(180, 22);
            this.undoItem.Text = "Undo";
            this.undoItem.Click += new System.EventHandler(this.undoItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // cutItem
            // 
            this.cutItem.Enabled = false;
            this.cutItem.Name = "cutItem";
            this.cutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutItem.Size = new System.Drawing.Size(180, 22);
            this.cutItem.Text = "Cut";
            this.cutItem.Click += new System.EventHandler(this.cutItem_Click);
            // 
            // copyItem
            // 
            this.copyItem.Enabled = false;
            this.copyItem.Name = "copyItem";
            this.copyItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyItem.Size = new System.Drawing.Size(180, 22);
            this.copyItem.Text = "Copy";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // pasteItem
            // 
            this.pasteItem.Enabled = false;
            this.pasteItem.Name = "pasteItem";
            this.pasteItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteItem.Size = new System.Drawing.Size(180, 22);
            this.pasteItem.Text = "Paste";
            this.pasteItem.Click += new System.EventHandler(this.pasteItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteItem.Size = new System.Drawing.Size(180, 22);
            this.deleteItem.Text = "Delete";
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // fIndToolStripMenuItem
            // 
            this.fIndToolStripMenuItem.Name = "fIndToolStripMenuItem";
            this.fIndToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fIndToolStripMenuItem.Text = "Find";
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findNextToolStripMenuItem.Text = "Find Next";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceToolStripMenuItem.Text = "Replace...";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Enabled = false;
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToToolStripMenuItem.Text = "Go To...";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllItem
            // 
            this.selectAllItem.Name = "selectAllItem";
            this.selectAllItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllItem.Text = "Select All";
            this.selectAllItem.Click += new System.EventHandler(this.selectAllItem_Click);
            // 
            // timedateToolStripMenuItem
            // 
            this.timedateToolStripMenuItem.Name = "timedateToolStripMenuItem";
            this.timedateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timedateToolStripMenuItem.Text = "Time/date";
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(0, 24);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 426);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItem;
        private System.Windows.Forms.ToolStripMenuItem openItemMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsItemMenu;
        private System.Windows.Forms.ToolStripMenuItem saveItemMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitItemMenu;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem editItemMenu;
        private System.Windows.Forms.ToolStripMenuItem undoItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutItem;
        private System.Windows.Forms.ToolStripMenuItem copyItem;
        private System.Windows.Forms.ToolStripMenuItem pasteItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fIndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem selectAllItem;
        private System.Windows.Forms.ToolStripMenuItem timedateToolStripMenuItem;
    }
}

