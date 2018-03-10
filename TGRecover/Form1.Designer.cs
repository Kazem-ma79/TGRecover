namespace TGRecover
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
            this.Loader = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Path = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loader
            // 
            this.Loader.Description = "Select installation path of telegram desktop";
            this.Loader.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.Path);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(7, 27);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(323, 23);
            this.Path.TabIndex = 0;
            this.Path.Text = "Path :";
            this.Path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.Location = new System.Drawing.Point(30, 3);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(50, 23);
            this.Select.TabIndex = 1;
            this.Select.Text = "Config";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(303, 54);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(44, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(348, 78);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram Session Recover";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog Loader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Exit;
    }
}

