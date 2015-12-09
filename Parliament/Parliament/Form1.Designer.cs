namespace Parliament
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
            this.con_btn = new System.Windows.Forms.Button();
            this.status_btn = new System.Windows.Forms.Button();
            this.complainants_btn = new System.Windows.Forms.Button();
            this.mps_btn = new System.Windows.Forms.Button();
            this.cases_btn = new System.Windows.Forms.Button();
            this.invoice_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // con_btn
            // 
            this.con_btn.Location = new System.Drawing.Point(80, 60);
            this.con_btn.Name = "con_btn";
            this.con_btn.Size = new System.Drawing.Size(104, 23);
            this.con_btn.TabIndex = 1;
            this.con_btn.Text = "constituencies";
            this.con_btn.UseVisualStyleBackColor = true;
            this.con_btn.Click += new System.EventHandler(this.con_btn_Click);
            // 
            // status_btn
            // 
            this.status_btn.Location = new System.Drawing.Point(80, 113);
            this.status_btn.Name = "status_btn";
            this.status_btn.Size = new System.Drawing.Size(104, 23);
            this.status_btn.TabIndex = 2;
            this.status_btn.Text = "statuses";
            this.status_btn.UseVisualStyleBackColor = true;
            this.status_btn.Click += new System.EventHandler(this.status_btn_Click);
            // 
            // complainants_btn
            // 
            this.complainants_btn.Location = new System.Drawing.Point(80, 174);
            this.complainants_btn.Name = "complainants_btn";
            this.complainants_btn.Size = new System.Drawing.Size(104, 23);
            this.complainants_btn.TabIndex = 3;
            this.complainants_btn.Text = "complainants";
            this.complainants_btn.UseVisualStyleBackColor = true;
            this.complainants_btn.Click += new System.EventHandler(this.complainants_btn_Click);
            // 
            // mps_btn
            // 
            this.mps_btn.Location = new System.Drawing.Point(80, 234);
            this.mps_btn.Name = "mps_btn";
            this.mps_btn.Size = new System.Drawing.Size(104, 23);
            this.mps_btn.TabIndex = 4;
            this.mps_btn.Text = "mps";
            this.mps_btn.UseVisualStyleBackColor = true;
            this.mps_btn.Click += new System.EventHandler(this.mps_btn_Click);
            // 
            // cases_btn
            // 
            this.cases_btn.Location = new System.Drawing.Point(80, 279);
            this.cases_btn.Name = "cases_btn";
            this.cases_btn.Size = new System.Drawing.Size(104, 23);
            this.cases_btn.TabIndex = 5;
            this.cases_btn.Text = "cases";
            this.cases_btn.UseVisualStyleBackColor = true;
            this.cases_btn.Click += new System.EventHandler(this.cases_btn_Click);
            // 
            // invoice_btn
            // 
            this.invoice_btn.Location = new System.Drawing.Point(80, 339);
            this.invoice_btn.Name = "invoice_btn";
            this.invoice_btn.Size = new System.Drawing.Size(104, 23);
            this.invoice_btn.TabIndex = 6;
            this.invoice_btn.Text = "invoices";
            this.invoice_btn.UseVisualStyleBackColor = true;
            this.invoice_btn.Click += new System.EventHandler(this.invoice_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 413);
            this.Controls.Add(this.invoice_btn);
            this.Controls.Add(this.cases_btn);
            this.Controls.Add(this.mps_btn);
            this.Controls.Add(this.complainants_btn);
            this.Controls.Add(this.status_btn);
            this.Controls.Add(this.con_btn);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button con_btn;
        private System.Windows.Forms.Button status_btn;
        private System.Windows.Forms.Button complainants_btn;
        private System.Windows.Forms.Button mps_btn;
        private System.Windows.Forms.Button cases_btn;
        private System.Windows.Forms.Button invoice_btn;
    }
}

