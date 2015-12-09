namespace Parliament
{
    partial class invoices
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
            this.home_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mp_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reason_combo = new System.Windows.Forms.ComboBox();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.invoice_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(397, 29);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(75, 23);
            this.home_btn.TabIndex = 39;
            this.home_btn.Text = "Home";
            this.home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "MP";
            // 
            // mp_combo
            // 
            this.mp_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mp_combo.FormattingEnabled = true;
            this.mp_combo.Location = new System.Drawing.Point(109, 71);
            this.mp_combo.Name = "mp_combo";
            this.mp_combo.Size = new System.Drawing.Size(121, 21);
            this.mp_combo.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Reason";
            // 
            // reason_combo
            // 
            this.reason_combo.FormattingEnabled = true;
            this.reason_combo.Location = new System.Drawing.Point(109, 183);
            this.reason_combo.Name = "reason_combo";
            this.reason_combo.Size = new System.Drawing.Size(121, 21);
            this.reason_combo.TabIndex = 49;
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(109, 133);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(100, 20);
            this.amount_txt.TabIndex = 53;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(48, 248);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 54;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(199, 248);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 55;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(353, 248);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 56;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Invoice no";
            // 
            // invoice_combo
            // 
            this.invoice_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoice_combo.FormattingEnabled = true;
            this.invoice_combo.Location = new System.Drawing.Point(109, 29);
            this.invoice_combo.Name = "invoice_combo";
            this.invoice_combo.Size = new System.Drawing.Size(121, 21);
            this.invoice_combo.TabIndex = 58;
            this.invoice_combo.SelectedIndexChanged += new System.EventHandler(this.invoice_combo_SelectedIndexChanged);
            // 
            // invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 343);
            this.Controls.Add(this.invoice_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.reason_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mp_combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.home_btn);
            this.Name = "invoices";
            this.Text = "invoices";
            this.Load += new System.EventHandler(this.invoices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mp_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox reason_combo;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox invoice_combo;
    }
}