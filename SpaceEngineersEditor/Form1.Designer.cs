namespace SpaceEngineersEditor
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.fileLoadedLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x3Btn = new System.Windows.Forms.Button();
            this.x10Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(16, 42);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(135, 23);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load CubeBlocks.sbc";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // fileLoadedLabel
            // 
            this.fileLoadedLabel.AutoSize = true;
            this.fileLoadedLabel.BackColor = System.Drawing.Color.Red;
            this.fileLoadedLabel.Location = new System.Drawing.Point(16, 68);
            this.fileLoadedLabel.Name = "fileLoadedLabel";
            this.fileLoadedLabel.Size = new System.Drawing.Size(40, 13);
            this.fileLoadedLabel.TabIndex = 1;
            this.fileLoadedLabel.Text = "No File";
            // 
            // resetBtn
            // 
            this.resetBtn.Enabled = false;
            this.resetBtn.Location = new System.Drawing.Point(16, 84);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(135, 23);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset to default";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Build Times";
            // 
            // x3Btn
            // 
            this.x3Btn.Enabled = false;
            this.x3Btn.Location = new System.Drawing.Point(15, 131);
            this.x3Btn.Name = "x3Btn";
            this.x3Btn.Size = new System.Drawing.Size(136, 23);
            this.x3Btn.TabIndex = 4;
            this.x3Btn.Text = "x3 faster";
            this.x3Btn.UseVisualStyleBackColor = true;
            this.x3Btn.Click += new System.EventHandler(this.x3Btn_Click);
            // 
            // x10Btn
            // 
            this.x10Btn.Enabled = false;
            this.x10Btn.Location = new System.Drawing.Point(16, 161);
            this.x10Btn.Name = "x10Btn";
            this.x10Btn.Size = new System.Drawing.Size(135, 23);
            this.x10Btn.TabIndex = 5;
            this.x10Btn.Text = "x10 faster";
            this.x10Btn.UseVisualStyleBackColor = true;
            this.x10Btn.Click += new System.EventHandler(this.x10Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "How to use!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.x10Btn);
            this.Controls.Add(this.x3Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.fileLoadedLabel);
            this.Controls.Add(this.loadBtn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SE Build times";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label fileLoadedLabel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button x3Btn;
        private System.Windows.Forms.Button x10Btn;
        private System.Windows.Forms.Button button1;
    }
}

