namespace QuestManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("--------------");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderSousToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stepModeSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUnFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainers = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.indexManagers = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rewards = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.steps = new System.Windows.Forms.TreeView();
            this.location = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.giver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isMain = new System.Windows.Forms.CheckBox();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.labeldesc = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fghfhgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainers)).BeginInit();
            this.mainContainers.Panel1.SuspendLayout();
            this.mainContainers.Panel2.SuspendLayout();
            this.mainContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zezToolStripMenuItem,
            this.stepModeSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // zezToolStripMenuItem
            // 
            this.zezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem1,
            this.chargerToolStripMenuItem,
            this.sauvegarderToolStripMenuItem1,
            this.sauvegarderSousToolStripMenuItem1});
            this.zezToolStripMenuItem.Name = "zezToolStripMenuItem";
            this.zezToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.zezToolStripMenuItem.Text = "Fichier";
            this.zezToolStripMenuItem.Click += new System.EventHandler(this.zezToolStripMenuItem_Click);
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.nouveauToolStripMenuItem1.Text = "Nouveau";
            this.nouveauToolStripMenuItem1.Click += new System.EventHandler(this.nouveauToolStripMenuItem1_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // sauvegarderToolStripMenuItem1
            // 
            this.sauvegarderToolStripMenuItem1.Enabled = false;
            this.sauvegarderToolStripMenuItem1.Name = "sauvegarderToolStripMenuItem1";
            this.sauvegarderToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.sauvegarderToolStripMenuItem1.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem1.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem1_Click);
            // 
            // sauvegarderSousToolStripMenuItem1
            // 
            this.sauvegarderSousToolStripMenuItem1.Enabled = false;
            this.sauvegarderSousToolStripMenuItem1.Name = "sauvegarderSousToolStripMenuItem1";
            this.sauvegarderSousToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.sauvegarderSousToolStripMenuItem1.Text = "Sauvegarder sous...";
            this.sauvegarderSousToolStripMenuItem1.Click += new System.EventHandler(this.sauvegarderSousToolStripMenuItem1_Click);
            // 
            // stepModeSetting
            // 
            this.stepModeSetting.Name = "stepModeSetting";
            this.stepModeSetting.Size = new System.Drawing.Size(186, 20);
            this.stepModeSetting.Text = "Mode des étapes : SUPER LONG";
            this.stepModeSetting.Click += new System.EventHandler(this.modeDesÉtapesSUPERLONGToolStripMenuItem_Click);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // chargerUnFichierToolStripMenuItem
            // 
            this.chargerUnFichierToolStripMenuItem.Name = "chargerUnFichierToolStripMenuItem";
            this.chargerUnFichierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chargerUnFichierToolStripMenuItem.Text = "Charger un fichier";
            this.chargerUnFichierToolStripMenuItem.Click += new System.EventHandler(this.chargerUnFichierToolStripMenuItem_Click);
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Enabled = false;
            this.sauvegarderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // sauvegarderSousToolStripMenuItem
            // 
            this.sauvegarderSousToolStripMenuItem.Enabled = false;
            this.sauvegarderSousToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sauvegarderSousToolStripMenuItem.Name = "sauvegarderSousToolStripMenuItem";
            this.sauvegarderSousToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sauvegarderSousToolStripMenuItem.Text = "Sauvegarder sous....";
            // 
            // mainContainers
            // 
            this.mainContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainers.Location = new System.Drawing.Point(0, 24);
            this.mainContainers.Name = "mainContainers";
            // 
            // mainContainers.Panel1
            // 
            this.mainContainers.Panel1.Controls.Add(this.splitContainer2);
            // 
            // mainContainers.Panel2
            // 
            this.mainContainers.Panel2.Controls.Add(this.label5);
            this.mainContainers.Panel2.Controls.Add(this.label4);
            this.mainContainers.Panel2.Controls.Add(this.panel2);
            this.mainContainers.Panel2.Controls.Add(this.panel1);
            this.mainContainers.Panel2.Controls.Add(this.location);
            this.mainContainers.Panel2.Controls.Add(this.label3);
            this.mainContainers.Panel2.Controls.Add(this.giver);
            this.mainContainers.Panel2.Controls.Add(this.label2);
            this.mainContainers.Panel2.Controls.Add(this.isMain);
            this.mainContainers.Panel2.Controls.Add(this.desc);
            this.mainContainers.Panel2.Controls.Add(this.labeldesc);
            this.mainContainers.Panel2.Controls.Add(this.name);
            this.mainContainers.Panel2.Controls.Add(this.label1);
            this.mainContainers.Size = new System.Drawing.Size(800, 426);
            this.mainContainers.SplitterDistance = 266;
            this.mainContainers.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.indexManagers);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(266, 426);
            this.splitContainer2.SplitterDistance = 380;
            this.splitContainer2.TabIndex = 1;
            // 
            // indexManagers
            // 
            this.indexManagers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indexManagers.Location = new System.Drawing.Point(0, 0);
            this.indexManagers.Name = "indexManagers";
            treeNode1.Name = "baseNode";
            treeNode1.Text = "--------------";
            treeNode1.ToolTipText = "--------------";
            this.indexManagers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.indexManagers.Size = new System.Drawing.Size(266, 380);
            this.indexManagers.TabIndex = 0;
            this.indexManagers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modifier Maximum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Récompenses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Etapes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rewards);
            this.panel2.Location = new System.Drawing.Point(277, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 169);
            this.panel2.TabIndex = 10;
            // 
            // rewards
            // 
            this.rewards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rewards.Location = new System.Drawing.Point(0, 0);
            this.rewards.Name = "rewards";
            this.rewards.Size = new System.Drawing.Size(228, 169);
            this.rewards.TabIndex = 0;
            this.rewards.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rewards_AfterSelect);
            this.rewards.Click += new System.EventHandler(this.rewards_Click);
            this.rewards.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rewards_MouseClick);
            this.rewards.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rewards_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.steps);
            this.panel1.Location = new System.Drawing.Point(22, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 169);
            this.panel1.TabIndex = 9;
            // 
            // steps
            // 
            this.steps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.steps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steps.Location = new System.Drawing.Point(0, 0);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(228, 169);
            this.steps.TabIndex = 0;
            this.steps.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.steps_AfterSelect);
            this.steps.Click += new System.EventHandler(this.steps_Click);
            this.steps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.steps_MouseClick);
            this.steps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.steps_MouseDown);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(68, 184);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(100, 20);
            this.location.TabIndex = 8;
            this.location.TextChanged += new System.EventHandler(this.location_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 187);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lieu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // giver
            // 
            this.giver.Location = new System.Drawing.Point(68, 148);
            this.giver.Name = "giver";
            this.giver.Size = new System.Drawing.Size(100, 20);
            this.giver.TabIndex = 6;
            this.giver.TextChanged += new System.EventHandler(this.giver_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Donneur";
            // 
            // isMain
            // 
            this.isMain.AutoSize = true;
            this.isMain.Location = new System.Drawing.Point(438, 11);
            this.isMain.Name = "isMain";
            this.isMain.Size = new System.Drawing.Size(80, 17);
            this.isMain.TabIndex = 4;
            this.isMain.Text = "Main Quest";
            this.isMain.UseVisualStyleBackColor = true;
            this.isMain.CheckedChanged += new System.EventHandler(this.isMain_CheckedChanged);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(17, 58);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(501, 77);
            this.desc.TabIndex = 3;
            this.desc.Text = "";
            this.desc.TextChanged += new System.EventHandler(this.desc_TextChanged);
            // 
            // labeldesc
            // 
            this.labeldesc.AutoSize = true;
            this.labeldesc.Location = new System.Drawing.Point(14, 42);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(60, 13);
            this.labeldesc.TabIndex = 2;
            this.labeldesc.Text = "Description";
            this.labeldesc.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(49, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(255, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.testToolStripMenuItem.Text = "test";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.testToolStripMenuItem1.Text = "test";
            // 
            // fghfhgToolStripMenuItem
            // 
            this.fghfhgToolStripMenuItem.Name = "fghfhgToolStripMenuItem";
            this.fghfhgToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fghfhgToolStripMenuItem.Text = "fghfhg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainers);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Base de donnée";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainContainers.Panel1.ResumeLayout(false);
            this.mainContainers.Panel2.ResumeLayout(false);
            this.mainContainers.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainers)).EndInit();
            this.mainContainers.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerUnFichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderSousToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainContainers;
        private System.Windows.Forms.TreeView indexManagers;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.CheckBox isMain;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox giver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView rewards;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView steps;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fghfhgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderSousToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem stepModeSetting;
    }
}

