namespace Parliament
{
    partial class mps
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
            this.surname_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fname_text = new System.Windows.Forms.TextBox();
            this.con_list = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.status_text = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.cases_btn = new System.Windows.Forms.Button();
            this.active_btn = new System.Windows.Forms.Button();
            this.lost_btn = new System.Windows.Forms.Button();
            this.deceased_btn = new System.Windows.Forms.Button();
            this.constituency_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(644, 26);
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
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "mps";
            // 
            // con_combo
            // 
            this.con_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.con_combo.FormattingEnabled = true;
            this.con_combo.Location = new System.Drawing.Point(128, 33);
            this.con_combo.Name = "con_combo";
            this.con_combo.Size = new System.Drawing.Size(121, 21);
            this.con_combo.TabIndex = 12;
            this.con_combo.SelectedIndexChanged += new System.EventHandler(this.con_combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Surname";
            // 
            // surname_text
            // 
            this.surname_text.Location = new System.Drawing.Point(128, 148);
            this.surname_text.Name = "surname_text";
            this.surname_text.Size = new System.Drawing.Size(100, 20);
            this.surname_text.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "First Name";
            // 
            // fname_text
            // 
            this.fname_text.Location = new System.Drawing.Point(128, 215);
            this.fname_text.Name = "fname_text";
            this.fname_text.Size = new System.Drawing.Size(100, 20);
            this.fname_text.TabIndex = 16;
            // 
            // con_list
            // 
            this.con_list.FormattingEnabled = true;
            this.con_list.Location = new System.Drawing.Point(475, 83);
            this.con_list.Name = "con_list";
            this.con_list.Size = new System.Drawing.Size(210, 160);
            this.con_list.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status";
            // 
            // status_text
            // 
            this.status_text.Location = new System.Drawing.Point(128, 276);
            this.status_text.Name = "status_text";
            this.status_text.ReadOnly = true;
            this.status_text.Size = new System.Drawing.Size(100, 20);
            this.status_text.TabIndex = 19;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(49, 344);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 20;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(197, 344);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 21;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(359, 344);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 22;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // cases_btn
            // 
            this.cases_btn.Location = new System.Drawing.Point(537, 344);
            this.cases_btn.Name = "cases_btn";
            this.cases_btn.Size = new System.Drawing.Size(75, 23);
            this.cases_btn.TabIndex = 23;
            this.cases_btn.Text = "View Cases";
            this.cases_btn.UseVisualStyleBackColor = true;
            this.cases_btn.Click += new System.EventHandler(this.cases_btn_Click);
            // 
            // active_btn
            // 
            this.active_btn.Location = new System.Drawing.Point(128, 405);
            this.active_btn.Name = "active_btn";
            this.active_btn.Size = new System.Drawing.Size(87, 23);
            this.active_btn.TabIndex = 24;
            this.active_btn.Text = "Set Active";
            this.active_btn.UseVisualStyleBackColor = true;
            this.active_btn.Click += new System.EventHandler(this.active_btn_Click);
            // 
            // lost_btn
            // 
            this.lost_btn.Location = new System.Drawing.Point(285, 405);
            this.lost_btn.Name = "lost_btn";
            this.lost_btn.Size = new System.Drawing.Size(123, 23);
            this.lost_btn.TabIndex = 25;
            this.lost_btn.Text = "Set Not Re-elected";
            this.lost_btn.UseVisualStyleBackColor = true;
            this.lost_btn.Click += new System.EventHandler(this.lost_btn_Click);
            // 
            // deceased_btn
            // 
            this.deceased_btn.Location = new System.Drawing.Point(475, 405);
            this.deceased_btn.Name = "deceased_btn";
            this.deceased_btn.Size = new System.Drawing.Size(137, 23);
            this.deceased_btn.TabIndex = 26;
            this.deceased_btn.Text = "Set Deceased";
            this.deceased_btn.UseVisualStyleBackColor = true;
            this.deceased_btn.Click += new System.EventHandler(this.deceased_btn_Click);
            // 
            // constituency_combo
            // 
            this.constituency_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.constituency_combo.FormattingEnabled = true;
            this.constituency_combo.Location = new System.Drawing.Point(128, 95);
            this.constituency_combo.Name = "constituency_combo";
            this.constituency_combo.Size = new System.Drawing.Size(121, 21);
            this.constituency_combo.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Constituency";
            // 
            // mps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.constituency_combo);
            this.Controls.Add(this.deceased_btn);
            this.Controls.Add(this.lost_btn);
            this.Controls.Add(this.active_btn);
            this.Controls.Add(this.cases_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.con_list);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.con_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home_btn);
            this.Name = "mps";
            this.Text = "mps";
            this.Load += new System.EventHandler(this.mps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox con_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surname_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fname_text;
        private System.Windows.Forms.ListBox con_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox status_text;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button cases_btn;
        private System.Windows.Forms.Button active_btn;
        private System.Windows.Forms.Button lost_btn;
        private System.Windows.Forms.Button deceased_btn;
        private System.Windows.Forms.ComboBox constituency_combo;
        private System.Windows.Forms.Label label5;
    }
}