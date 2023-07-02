namespace mkvChapterEditor
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
            tbMKVpath = new TextBox();
            label1 = new Label();
            btnBrowse = new Button();
            tbCurrent = new TextBox();
            tbNew = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnReload = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // tbMKVpath
            // 
            tbMKVpath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMKVpath.Location = new Point(12, 27);
            tbMKVpath.Name = "tbMKVpath";
            tbMKVpath.Size = new Size(918, 23);
            tbMKVpath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "MKV Path:";
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(936, 27);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // tbCurrent
            // 
            tbCurrent.Location = new Point(12, 102);
            tbCurrent.Multiline = true;
            tbCurrent.Name = "tbCurrent";
            tbCurrent.ReadOnly = true;
            tbCurrent.Size = new Size(340, 522);
            tbCurrent.TabIndex = 3;
            // 
            // tbNew
            // 
            tbNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbNew.Location = new Point(675, 102);
            tbNew.Multiline = true;
            tbNew.Name = "tbNew";
            tbNew.Size = new Size(336, 522);
            tbNew.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 5;
            label2.Text = "Current MKV Chapters";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(675, 84);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "New MKV Chapters";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(277, 630);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(75, 23);
            btnReload.TabIndex = 7;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Location = new Point(936, 630);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new Point(855, 630);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 683);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnReload);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNew);
            Controls.Add(tbCurrent);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(tbMKVpath);
            Name = "Form1";
            Text = "MKV Chapter Editor";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMKVpath;
        private Label label1;
        private Button btnBrowse;
        private TextBox tbCurrent;
        private TextBox tbNew;
        private Label label2;
        private Label label3;
        private Button btnReload;
        private Button btnUpdate;
        private Button btnClear;
    }
}