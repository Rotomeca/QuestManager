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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.steptype = new System.Windows.Forms.ComboBox();
            this.desc_label = new System.Windows.Forms.Label();
            this.short_desc = new System.Windows.Forms.TextBox();
            this.long_desc = new System.Windows.Forms.RichTextBox();
            this.isVisible = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Panel2.Controls.Add(this.isVisible);
            this.splitContainer1.Panel2.Controls.Add(this.long_desc);
            this.splitContainer1.Panel2.Controls.Add(this.short_desc);
            this.splitContainer1.Panel2.Controls.Add(this.desc_label);
            this.splitContainer1.Panel2.Controls.Add(this.steptype);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(266, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // steptype
            // 
            this.steptype.FormattingEnabled = true;
            this.steptype.Location = new System.Drawing.Point(40, 6);
            this.steptype.Name = "steptype";
            this.steptype.Size = new System.Drawing.Size(121, 21);
            this.steptype.TabIndex = 1;
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
            // short_desc
            // 
            this.short_desc.Location = new System.Drawing.Point(6, 69);
            this.short_desc.Name = "short_desc";
            this.short_desc.Size = new System.Drawing.Size(155, 20);
            this.short_desc.TabIndex = 3;
            // 
            // long_desc
            // 
            this.long_desc.Location = new System.Drawing.Point(6, 69);
            this.long_desc.Name = "long_desc";
            this.long_desc.Size = new System.Drawing.Size(512, 129);
            this.long_desc.TabIndex = 4;
            this.long_desc.Text = "";
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
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(293, 283);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(219, 155);
            this.treeView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Etapes débloquées";
            // 
            // StepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox steptype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox short_desc;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.RichTextBox long_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox isVisible;
    }
}