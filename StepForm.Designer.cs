namespace QuestManager
{
    partial class StepForm
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
            this.allSteps = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.addStepButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.removeNextStepButton = new System.Windows.Forms.Button();
            this.addNextStepButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.long_desc = new System.Windows.Forms.RichTextBox();
            this.gameDataId = new System.Windows.Forms.NumericUpDown();
            this.gameDataIdLabel = new System.Windows.Forms.Label();
            this.switchState = new System.Windows.Forms.CheckBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextSteps = new System.Windows.Forms.TreeView();
            this.isVisible = new System.Windows.Forms.CheckBox();
            this.short_desc = new System.Windows.Forms.TextBox();
            this.desc_label = new System.Windows.Forms.Label();
            this.steptype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
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
            ((System.ComponentModel.ISupportInitialize)(this.gameDataId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.removeNextStepButton);
            this.splitContainer1.Panel2.Controls.Add(this.addNextStepButton);
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Panel2.Controls.Add(this.long_desc);
            this.splitContainer1.Panel2.Controls.Add(this.gameDataId);
            this.splitContainer1.Panel2.Controls.Add(this.gameDataIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.switchState);
            this.splitContainer1.Panel2.Controls.Add(this.unitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.amount);
            this.splitContainer1.Panel2.Controls.Add(this.amountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.nextSteps);
            this.splitContainer1.Panel2.Controls.Add(this.isVisible);
            this.splitContainer1.Panel2.Controls.Add(this.short_desc);
            this.splitContainer1.Panel2.Controls.Add(this.desc_label);
            this.splitContainer1.Panel2.Controls.Add(this.steptype);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(684, 291);
            this.splitContainer1.SplitterDistance = 149;
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
            this.splitContainer2.Panel1.Controls.Add(this.allSteps);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(149, 291);
            this.splitContainer2.SplitterDistance = 262;
            this.splitContainer2.TabIndex = 0;
            // 
            // allSteps
            // 
            this.allSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSteps.Location = new System.Drawing.Point(0, 0);
            this.allSteps.Name = "allSteps";
            this.allSteps.Size = new System.Drawing.Size(149, 262);
            this.allSteps.TabIndex = 0;
            this.allSteps.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.allSteps_AfterSelect);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.addStepButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer3.Size = new System.Drawing.Size(149, 25);
            this.splitContainer3.SplitterDistance = 78;
            this.splitContainer3.TabIndex = 0;
            // 
            // addStepButton
            // 
            this.addStepButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStepButton.Location = new System.Drawing.Point(0, 0);
            this.addStepButton.Name = "addStepButton";
            this.addStepButton.Size = new System.Drawing.Size(78, 25);
            this.addStepButton.TabIndex = 0;
            this.addStepButton.Text = "Ajouter";
            this.addStepButton.UseVisualStyleBackColor = true;
            this.addStepButton.Click += new System.EventHandler(this.addStepButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 25);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseMnemonic = false;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // removeNextStepButton
            // 
            this.removeNextStepButton.Location = new System.Drawing.Point(397, 146);
            this.removeNextStepButton.Name = "removeNextStepButton";
            this.removeNextStepButton.Size = new System.Drawing.Size(36, 23);
            this.removeNextStepButton.TabIndex = 16;
            this.removeNextStepButton.Text = "<=";
            this.removeNextStepButton.UseVisualStyleBackColor = true;
            this.removeNextStepButton.Click += new System.EventHandler(this.removeNextStepButton_Click);
            // 
            // addNextStepButton
            // 
            this.addNextStepButton.Location = new System.Drawing.Point(397, 97);
            this.addNextStepButton.Name = "addNextStepButton";
            this.addNextStepButton.Size = new System.Drawing.Size(36, 23);
            this.addNextStepButton.TabIndex = 15;
            this.addNextStepButton.Text = "=>";
            this.addNextStepButton.UseVisualStyleBackColor = true;
            this.addNextStepButton.Click += new System.EventHandler(this.addNextStepButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(299, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(97, 134);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // long_desc
            // 
            this.long_desc.Location = new System.Drawing.Point(6, 69);
            this.long_desc.Name = "long_desc";
            this.long_desc.Size = new System.Drawing.Size(272, 129);
            this.long_desc.TabIndex = 3;
            this.long_desc.Text = "";
            this.long_desc.TextChanged += new System.EventHandler(this.long_desc_TextChanged);
            // 
            // gameDataId
            // 
            this.gameDataId.Location = new System.Drawing.Point(202, 6);
            this.gameDataId.Margin = new System.Windows.Forms.Padding(2);
            this.gameDataId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.gameDataId.Name = "gameDataId";
            this.gameDataId.Size = new System.Drawing.Size(90, 20);
            this.gameDataId.TabIndex = 13;
            this.gameDataId.ValueChanged += new System.EventHandler(this.gameDataId_ValueChanged);
            // 
            // gameDataIdLabel
            // 
            this.gameDataIdLabel.AutoSize = true;
            this.gameDataIdLabel.Location = new System.Drawing.Point(187, 7);
            this.gameDataIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameDataIdLabel.Name = "gameDataIdLabel";
            this.gameDataIdLabel.Size = new System.Drawing.Size(16, 13);
            this.gameDataIdLabel.TabIndex = 12;
            this.gameDataIdLabel.Text = "Id";
            this.gameDataIdLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // switchState
            // 
            this.switchState.AutoSize = true;
            this.switchState.Location = new System.Drawing.Point(5, 223);
            this.switchState.Name = "switchState";
            this.switchState.Size = new System.Drawing.Size(80, 17);
            this.switchState.TabIndex = 11;
            this.switchState.Text = "Interrupteur";
            this.switchState.UseVisualStyleBackColor = true;
            this.switchState.CheckedChanged += new System.EventHandler(this.switchState_CheckedChanged);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(100, 243);
            this.unitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(35, 13);
            this.unitLabel.TabIndex = 10;
            this.unitLabel.Text = "label4";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(5, 241);
            this.amount.Margin = new System.Windows.Forms.Padding(2);
            this.amount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(90, 20);
            this.amount.TabIndex = 9;
            this.amount.ValueChanged += new System.EventHandler(this.amount_ValueChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(4, 223);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(54, 13);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "amount of";
            this.amountLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Etapes débloquées";
            // 
            // nextSteps
            // 
            this.nextSteps.Enabled = false;
            this.nextSteps.Location = new System.Drawing.Point(434, 69);
            this.nextSteps.Name = "nextSteps";
            this.nextSteps.Size = new System.Drawing.Size(89, 134);
            this.nextSteps.TabIndex = 6;
            // 
            // isVisible
            // 
            this.isVisible.AutoSize = true;
            this.isVisible.Location = new System.Drawing.Point(447, 8);
            this.isVisible.Name = "isVisible";
            this.isVisible.Size = new System.Drawing.Size(65, 17);
            this.isVisible.TabIndex = 5;
            this.isVisible.Text = "Visible ?";
            this.isVisible.UseVisualStyleBackColor = true;
            this.isVisible.CheckedChanged += new System.EventHandler(this.isVisible_CheckedChanged);
            // 
            // short_desc
            // 
            this.short_desc.Location = new System.Drawing.Point(6, 69);
            this.short_desc.Name = "short_desc";
            this.short_desc.Size = new System.Drawing.Size(272, 20);
            this.short_desc.TabIndex = 3;
            this.short_desc.TextChanged += new System.EventHandler(this.short_desc_TextChanged);
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Location = new System.Drawing.Point(3, 53);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(75, 13);
            this.desc_label.TabIndex = 2;
            this.desc_label.Text = "Description (?)";
            // 
            // steptype
            // 
            this.steptype.FormattingEnabled = true;
            this.steptype.Location = new System.Drawing.Point(40, 6);
            this.steptype.Name = "steptype";
            this.steptype.Size = new System.Drawing.Size(121, 21);
            this.steptype.TabIndex = 1;
            this.steptype.SelectedIndexChanged += new System.EventHandler(this.steptype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            this.process1.Exited += new System.EventHandler(this.process1_Exited);
            // 
            // StepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 291);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StepForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionnaire d\'étapes";
            this.Load += new System.EventHandler(this.StepForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.gameDataId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox steptype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox short_desc;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.RichTextBox long_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView nextSteps;
        private System.Windows.Forms.CheckBox isVisible;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox switchState;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button addStepButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TreeView allSteps;
        private System.Windows.Forms.Label gameDataIdLabel;
        private System.Windows.Forms.NumericUpDown gameDataId;
        private System.Windows.Forms.Button removeNextStepButton;
        private System.Windows.Forms.Button addNextStepButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Diagnostics.Process process1;
    }
}