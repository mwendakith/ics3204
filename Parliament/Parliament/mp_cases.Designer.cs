namespace Parliament
{
    partial class mp_cases
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
            this.mp_cases_list = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mp_cases_list
            // 
            this.mp_cases_list.FormattingEnabled = true;
            this.mp_cases_list.Location = new System.Drawing.Point(159, 102);
            this.mp_cases_list.Name = "mp_cases_list";
            this.mp_cases_list.Size = new System.Drawing.Size(566, 251);
            this.mp_cases_list.TabIndex = 1;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(30, 22);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 39;
            this.back_btn.Text = "Back";
            this.back_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // mp_cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 429);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.mp_cases_list);
            this.Name = "mp_cases";
            this.Text = "mp_cases";
            this.Load += new System.EventHandler(this.mp_cases_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mp_cases_list;
        private System.Windows.Forms.Button back_btn;
    }
}