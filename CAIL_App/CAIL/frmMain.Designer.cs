namespace CAIL
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompair = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtCode1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCode1Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCode1Save = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtCode2 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCode2Load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCode2Save = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCgC1toC2 = new System.Windows.Forms.Button();
            this.btnCgC2toC1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnCompair
            // 
            this.btnCompair.Location = new System.Drawing.Point(12, 12);
            this.btnCompair.Name = "btnCompair";
            this.btnCompair.Size = new System.Drawing.Size(75, 23);
            this.btnCompair.TabIndex = 0;
            this.btnCompair.Text = "Compair";
            this.btnCompair.UseVisualStyleBackColor = true;
            this.btnCompair.Click += new System.EventHandler(this.btnCompair_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtCode1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(824, 426);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 1;
            // 
            // rtCode1
            // 
            this.rtCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtCode1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtCode1.ForeColor = System.Drawing.Color.Black;
            this.rtCode1.Location = new System.Drawing.Point(0, 33);
            this.rtCode1.Name = "rtCode1";
            this.rtCode1.Size = new System.Drawing.Size(392, 393);
            this.rtCode1.TabIndex = 1;
            this.rtCode1.Text = "Begin\n    --- Insert your CAIL code here\nEnd";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCode1Load);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCode1Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 33);
            this.panel2.TabIndex = 0;
            // 
            // btnCode1Load
            // 
            this.btnCode1Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode1Load.Location = new System.Drawing.Point(231, 6);
            this.btnCode1Load.Name = "btnCode1Load";
            this.btnCode1Load.Size = new System.Drawing.Size(75, 23);
            this.btnCode1Load.TabIndex = 1;
            this.btnCode1Load.Text = "Load";
            this.btnCode1Load.UseVisualStyleBackColor = true;
            this.btnCode1Load.Click += new System.EventHandler(this.btnCode1Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code1";
            // 
            // btnCode1Save
            // 
            this.btnCode1Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode1Save.Location = new System.Drawing.Point(312, 6);
            this.btnCode1Save.Name = "btnCode1Save";
            this.btnCode1Save.Size = new System.Drawing.Size(75, 23);
            this.btnCode1Save.TabIndex = 1;
            this.btnCode1Save.Text = "Save";
            this.btnCode1Save.UseVisualStyleBackColor = true;
            this.btnCode1Save.Click += new System.EventHandler(this.btnCode1Save_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rtCode2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(43, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(385, 426);
            this.panel5.TabIndex = 3;
            // 
            // rtCode2
            // 
            this.rtCode2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtCode2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtCode2.ForeColor = System.Drawing.Color.Black;
            this.rtCode2.Location = new System.Drawing.Point(0, 33);
            this.rtCode2.Name = "rtCode2";
            this.rtCode2.Size = new System.Drawing.Size(385, 393);
            this.rtCode2.TabIndex = 1;
            this.rtCode2.Text = "Begin\n    --- Insert your CAIL code here\nEnd";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCode2Load);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnCode2Save);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 33);
            this.panel3.TabIndex = 0;
            // 
            // btnCode2Load
            // 
            this.btnCode2Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode2Load.Location = new System.Drawing.Point(222, 6);
            this.btnCode2Load.Name = "btnCode2Load";
            this.btnCode2Load.Size = new System.Drawing.Size(75, 23);
            this.btnCode2Load.TabIndex = 1;
            this.btnCode2Load.Text = "Load";
            this.btnCode2Load.UseVisualStyleBackColor = true;
            this.btnCode2Load.Click += new System.EventHandler(this.btnCode2Load_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code2";
            // 
            // btnCode2Save
            // 
            this.btnCode2Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode2Save.Location = new System.Drawing.Point(303, 6);
            this.btnCode2Save.Name = "btnCode2Save";
            this.btnCode2Save.Size = new System.Drawing.Size(75, 23);
            this.btnCode2Save.TabIndex = 1;
            this.btnCode2Save.Text = "Save";
            this.btnCode2Save.UseVisualStyleBackColor = true;
            this.btnCode2Save.Click += new System.EventHandler(this.btnCode2Save_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChange);
            this.panel4.Controls.Add(this.btnCgC1toC2);
            this.panel4.Controls.Add(this.btnCgC2toC1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 426);
            this.panel4.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnChange.Location = new System.Drawing.Point(6, 105);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(31, 30);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "<>";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCgC1toC2
            // 
            this.btnCgC1toC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCgC1toC2.Location = new System.Drawing.Point(6, 69);
            this.btnCgC1toC2.Name = "btnCgC1toC2";
            this.btnCgC1toC2.Size = new System.Drawing.Size(31, 30);
            this.btnCgC1toC2.TabIndex = 0;
            this.btnCgC1toC2.Text = "<<";
            this.btnCgC1toC2.UseVisualStyleBackColor = true;
            this.btnCgC1toC2.Click += new System.EventHandler(this.btnCgC1toC2_Click);
            // 
            // btnCgC2toC1
            // 
            this.btnCgC2toC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCgC2toC1.Location = new System.Drawing.Point(6, 33);
            this.btnCgC2toC1.Name = "btnCgC2toC1";
            this.btnCgC2toC1.Size = new System.Drawing.Size(31, 30);
            this.btnCgC2toC1.TabIndex = 0;
            this.btnCgC2toC1.Text = ">>";
            this.btnCgC2toC1.UseVisualStyleBackColor = true;
            this.btnCgC2toC1.Click += new System.EventHandler(this.btnCgC2toC1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 472);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Clustering Algorithms Independence Language (CAIL) code analyzer";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCompair;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtCode1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtCode2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCode2Load;
        private System.Windows.Forms.Button btnCode2Save;
        private System.Windows.Forms.Button btnCode1Load;
        private System.Windows.Forms.Button btnCode1Save;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCgC1toC2;
        private System.Windows.Forms.Button btnCgC2toC1;

    }
}

