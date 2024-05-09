namespace QuestManager
{
    partial class RewardForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rewardTreeView = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rewardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.textLabel = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.NumericUpDown();
            this.questComboBox = new System.Windows.Forms.ComboBox();
            this.durability = new System.Windows.Forms.GroupBox();
            this.enableNewDurability = new System.Windows.Forms.CheckBox();
            this.enableEqpt = new System.Windows.Forms.CheckBox();
            this.customNewDurabilityMax = new System.Windows.Forms.NumericUpDown();
            this.customDurability = new System.Windows.Forms.CheckBox();
            this.setCustomDurability = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idField)).BeginInit();
            this.durability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customNewDurabilityMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCustomDurability)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.rewardTreeView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(266, 450);
            this.splitContainer2.SplitterDistance = 397;
            this.splitContainer2.TabIndex = 0;
            // 
            // rewardTreeView
            // 
            this.rewardTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rewardTreeView.Location = new System.Drawing.Point(0, 0);
            this.rewardTreeView.Name = "rewardTreeView";
            this.rewardTreeView.Size = new System.Drawing.Size(266, 397);
            this.rewardTreeView.TabIndex = 0;
            this.rewardTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rewardTreeView_AfterSelect);
            this.rewardTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.rewardTreeView_NodeMouseClick);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.addButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.removeButton);
            this.splitContainer3.Size = new System.Drawing.Size(266, 49);
            this.splitContainer3.SplitterDistance = 136;
            this.splitContainer3.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 49);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Maroon;
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.removeButton.Location = new System.Drawing.Point(0, 0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(126, 49);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Supprimer";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.gb2);
            this.flowLayoutPanel1.Controls.Add(this.durability);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(530, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rewardTypeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Récompense";
            // 
            // rewardTypeComboBox
            // 
            this.rewardTypeComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rewardTypeComboBox.FormattingEnabled = true;
            this.rewardTypeComboBox.Location = new System.Drawing.Point(3, 16);
            this.rewardTypeComboBox.Name = "rewardTypeComboBox";
            this.rewardTypeComboBox.Size = new System.Drawing.Size(186, 21);
            this.rewardTypeComboBox.TabIndex = 0;
            this.rewardTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.rewardTypeComboBox_SelectedIndexChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.flowLayoutPanel2);
            this.gb2.Location = new System.Drawing.Point(3, 57);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(515, 100);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            this.gb2.Text = "Récupérer";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.amountField);
            this.flowLayoutPanel2.Controls.Add(this.textLabel);
            this.flowLayoutPanel2.Controls.Add(this.idField);
            this.flowLayoutPanel2.Controls.Add(this.questComboBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(509, 81);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(3, 3);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(54, 20);
            this.amountField.TabIndex = 0;
            this.amountField.ValueChanged += new System.EventHandler(this.amountField_ValueChanged);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(63, 5);
            this.textLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(46, 13);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "avec l\'id";
            this.textLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(115, 3);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(50, 20);
            this.idField.TabIndex = 2;
            // 
            // questComboBox
            // 
            this.questComboBox.FormattingEnabled = true;
            this.questComboBox.Location = new System.Drawing.Point(171, 3);
            this.questComboBox.Name = "questComboBox";
            this.questComboBox.Size = new System.Drawing.Size(121, 21);
            this.questComboBox.TabIndex = 3;
            // 
            // durability
            // 
            this.durability.Controls.Add(this.enableNewDurability);
            this.durability.Controls.Add(this.enableEqpt);
            this.durability.Controls.Add(this.customNewDurabilityMax);
            this.durability.Controls.Add(this.customDurability);
            this.durability.Controls.Add(this.setCustomDurability);
            this.durability.Location = new System.Drawing.Point(3, 163);
            this.durability.Name = "durability";
            this.durability.Size = new System.Drawing.Size(512, 100);
            this.durability.TabIndex = 3;
            this.durability.TabStop = false;
            this.durability.Text = "Modifier la durabilité";
            this.durability.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // enableNewDurability
            // 
            this.enableNewDurability.AutoSize = true;
            this.enableNewDurability.Location = new System.Drawing.Point(191, 39);
            this.enableNewDurability.Name = "enableNewDurability";
            this.enableNewDurability.Size = new System.Drawing.Size(113, 17);
            this.enableNewDurability.TabIndex = 8;
            this.enableNewDurability.Text = "Nouvelle durabilité";
            this.enableNewDurability.UseVisualStyleBackColor = true;
            this.enableNewDurability.CheckedChanged += new System.EventHandler(this.enableNewDurability_CheckedChanged);
            // 
            // enableEqpt
            // 
            this.enableEqpt.AutoSize = true;
            this.enableEqpt.Location = new System.Drawing.Point(6, 39);
            this.enableEqpt.Name = "enableEqpt";
            this.enableEqpt.Size = new System.Drawing.Size(147, 17);
            this.enableEqpt.TabIndex = 7;
            this.enableEqpt.Text = "Durabilité de l\'équipement";
            this.enableEqpt.UseVisualStyleBackColor = true;
            this.enableEqpt.CheckedChanged += new System.EventHandler(this.enableEqpt_CheckedChanged);
            // 
            // customNewDurabilityMax
            // 
            this.customNewDurabilityMax.Location = new System.Drawing.Point(209, 59);
            this.customNewDurabilityMax.Name = "customNewDurabilityMax";
            this.customNewDurabilityMax.Size = new System.Drawing.Size(120, 20);
            this.customNewDurabilityMax.TabIndex = 6;
            this.customNewDurabilityMax.ValueChanged += new System.EventHandler(this.customNewDurabilityMax_ValueChanged);
            // 
            // customDurability
            // 
            this.customDurability.AutoSize = true;
            this.customDurability.Location = new System.Drawing.Point(3, 19);
            this.customDurability.Name = "customDurability";
            this.customDurability.Size = new System.Drawing.Size(141, 17);
            this.customDurability.TabIndex = 0;
            this.customDurability.Text = "Durabilité personnalisé ?";
            this.customDurability.UseVisualStyleBackColor = true;
            this.customDurability.CheckedChanged += new System.EventHandler(this.customDurability_CheckedChanged);
            // 
            // setCustomDurability
            // 
            this.setCustomDurability.Location = new System.Drawing.Point(24, 59);
            this.setCustomDurability.Name = "setCustomDurability";
            this.setCustomDurability.Size = new System.Drawing.Size(120, 20);
            this.setCustomDurability.TabIndex = 4;
            this.setCustomDurability.ValueChanged += new System.EventHandler(this.setCustomDurability_ValueChanged);
            // 
            // RewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RewardForm";
            this.Text = "RewardForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idField)).EndInit();
            this.durability.ResumeLayout(false);
            this.durability.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customNewDurabilityMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCustomDurability)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView rewardTreeView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox rewardTypeComboBox;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.NumericUpDown idField;
        private System.Windows.Forms.ComboBox questComboBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox durability;
        private System.Windows.Forms.CheckBox customDurability;
        private System.Windows.Forms.CheckBox enableNewDurability;
        private System.Windows.Forms.CheckBox enableEqpt;
        private System.Windows.Forms.NumericUpDown customNewDurabilityMax;
        private System.Windows.Forms.NumericUpDown setCustomDurability;
    }
}