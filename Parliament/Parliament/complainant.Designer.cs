namespace Parliament
{
    partial class complainant
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
            this.label1 = new System.Windows.Forms.Label();
            this.con_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.con_text = new System.Windows.Forms.TextBox();
            this.con_list = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(414, 22);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(75, 23);
            this.home_btn.TabIndex = 10;
            this.home_btn.Text = "Home";
            this.home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Complainants";
            // 
            // con_combo
            // 
            this.con_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.con_combo.FormattingEnabled = true;
            this.con_combo.Location = new System.Drawing.Point(155, 85);
            this.con_combo.Name = "con_combo";
            this.con_combo.Size = new System.Drawing.Size(121, 21);
            this.con_combo.TabIndex = 12;
            this.con_combo.SelectedIndexChanged += new System.EventHandler(this.con_combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // con_text
            // 
            this.con_text.Location = new System.Drawing.Point(400, 86);
            this.con_text.Name = "con_text";
            this.con_text.Size = new System.Drawing.Size(100, 20);
            this.con_text.TabIndex = 14;
            // 
            // con_list
            // 
            this.con_list.FormattingEnabled = true;
            this.con_list.Location = new System.Drawing.Point(204, 135);
            this.con_list.Name = "con_list";
            this.con_list.Size = new System.Drawing.Size(120, 95);
            this.con_list.TabIndex = 15;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(54, 266);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 16;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(189, 266);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 17;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(322, 266);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // complainant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 365);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.con_list);
            this.Controls.Add(this.con_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.con_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home_btn);
            this.Name = "complainant";
            this.Text = "complainant";
            this.Load += new System.EventHandler(this.complainant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox con_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox con_text;
        private System.Windows.Forms.ListBox con_list;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}