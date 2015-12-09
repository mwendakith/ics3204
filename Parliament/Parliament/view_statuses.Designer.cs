namespace Parliament
{
    partial class view_statuses
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
            this.status_list = new System.Windows.Forms.ListBox();
            this.statuses_combo = new System.Windows.Forms.ComboBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status_list
            // 
            this.status_list.FormattingEnabled = true;
            this.status_list.Location = new System.Drawing.Point(201, 114);
            this.status_list.Name = "status_list";
            this.status_list.Size = new System.Drawing.Size(120, 95);
            this.status_list.TabIndex = 0;
            // 
            // statuses_combo
            // 
            this.statuses_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statuses_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statuses_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuses_combo.FormattingEnabled = true;
            this.statuses_combo.Location = new System.Drawing.Point(201, 61);
            this.statuses_combo.Name = "statuses_combo";
            this.statuses_combo.Size = new System.Drawing.Size(121, 21);
            this.statuses_combo.TabIndex = 1;
            this.statuses_combo.SelectedIndexChanged += new System.EventHandler(this.statuses_combo_SelectedIndexChanged);
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(398, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(75, 23);
            this.home_btn.TabIndex = 10;
            this.home_btn.Text = "Home";
            this.home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // view_statuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 383);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.statuses_combo);
            this.Controls.Add(this.status_list);
            this.Name = "view_statuses";
            this.Text = "view_statuses";
            this.Load += new System.EventHandler(this.view_statuses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox status_list;
        private System.Windows.Forms.ComboBox statuses_combo;
        private System.Windows.Forms.Button home_btn;
    }
}