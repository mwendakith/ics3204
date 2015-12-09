namespace Parliament
{
    partial class constituency
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
            this.con_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.con_list = new System.Windows.Forms.ListBox();
            this.con_text = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // con_combo
            // 
            this.con_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.con_combo.FormattingEnabled = true;
            this.con_combo.Location = new System.Drawing.Point(155, 77);
            this.con_combo.Name = "con_combo";
            this.con_combo.Size = new System.Drawing.Size(121, 21);
            this.con_combo.TabIndex = 0;
            this.con_combo.SelectedIndexChanged += new System.EventHandler(this.con_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Constituencies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // con_list
            // 
            this.con_list.FormattingEnabled = true;
            this.con_list.Location = new System.Drawing.Point(284, 148);
            this.con_list.Name = "con_list";
            this.con_list.Size = new System.Drawing.Size(120, 95);
            this.con_list.TabIndex = 3;
            // 
            // con_text
            // 
            this.con_text.Location = new System.Drawing.Point(516, 84);
            this.con_text.Name = "con_text";
            this.con_text.Size = new System.Drawing.Size(100, 20);
            this.con_text.TabIndex = 4;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(45, 322);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(178, 322);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(329, 322);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(500, 322);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 8;
            this.refresh_btn.Text = "Refresh List";
            this.refresh_btn.UseVisualStyleBackColor = true;
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(590, 22);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(75, 23);
            this.home_btn.TabIndex = 9;
            this.home_btn.Text = "Home";
            this.home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // constituency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 475);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.con_text);
            this.Controls.Add(this.con_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.con_combo);
            this.Name = "constituency";
            this.Text = "constituency";
            this.Load += new System.EventHandler(this.constituency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox con_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox con_list;
        private System.Windows.Forms.TextBox con_text;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button home_btn;
    }
}