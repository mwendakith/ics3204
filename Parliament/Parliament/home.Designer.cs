namespace Parliament
{
    partial class home
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
            this.con_btn = new System.Windows.Forms.Button();
            this.status_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // con_btn
            // 
            this.con_btn.Location = new System.Drawing.Point(84, 35);
            this.con_btn.Name = "con_btn";
            this.con_btn.Size = new System.Drawing.Size(104, 23);
            this.con_btn.TabIndex = 0;
            this.con_btn.Text = "constituencies";
            this.con_btn.UseVisualStyleBackColor = true;
            this.con_btn.Click += new System.EventHandler(this.con_btn_Click);
            // 
            // status_btn
            // 
            this.status_btn.Location = new System.Drawing.Point(84, 90);
            this.status_btn.Name = "status_btn";
            this.status_btn.Size = new System.Drawing.Size(104, 23);
            this.status_btn.TabIndex = 1;
            this.status_btn.Text = "statuses";
            this.status_btn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.status_btn);
            this.Controls.Add(this.con_btn);
            this.Name = "home";
            this.Text = "home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button con_btn;
        private System.Windows.Forms.Button status_btn;
        private System.Windows.Forms.Button button3;
    }
}