namespace MVP.Views
{
    partial class UpdateView
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.moncalUpdate = new System.Windows.Forms.MonthCalendar();
            this.nUpdown_Score = new System.Windows.Forms.NumericUpDown();
            this.txtbox_UpdateLastName = new System.Windows.Forms.TextBox();
            this.txtbox_UpdateFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUpdown_Score)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(106, 174);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Green;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(25, 174);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // moncalUpdate
            // 
            this.moncalUpdate.Location = new System.Drawing.Point(191, 35);
            this.moncalUpdate.Name = "moncalUpdate";
            this.moncalUpdate.TabIndex = 9;
            // 
            // nUpdown_Score
            // 
            this.nUpdown_Score.Location = new System.Drawing.Point(25, 102);
            this.nUpdown_Score.Name = "nUpdown_Score";
            this.nUpdown_Score.Size = new System.Drawing.Size(120, 23);
            this.nUpdown_Score.TabIndex = 8;
            // 
            // txtbox_UpdateLastName
            // 
            this.txtbox_UpdateLastName.Location = new System.Drawing.Point(25, 64);
            this.txtbox_UpdateLastName.Name = "txtbox_UpdateLastName";
            this.txtbox_UpdateLastName.PlaceholderText = "LastName";
            this.txtbox_UpdateLastName.Size = new System.Drawing.Size(100, 23);
            this.txtbox_UpdateLastName.TabIndex = 7;
            // 
            // txtbox_UpdateFirstName
            // 
            this.txtbox_UpdateFirstName.Location = new System.Drawing.Point(25, 35);
            this.txtbox_UpdateFirstName.Name = "txtbox_UpdateFirstName";
            this.txtbox_UpdateFirstName.PlaceholderText = "FirstName";
            this.txtbox_UpdateFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtbox_UpdateFirstName.TabIndex = 6;
            // 
            // UpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 237);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.moncalUpdate);
            this.Controls.Add(this.nUpdown_Score);
            this.Controls.Add(this.txtbox_UpdateLastName);
            this.Controls.Add(this.txtbox_UpdateFirstName);
            this.Name = "UpdateView";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.nUpdown_Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btn_Cancel;
        public Button btn_Update;
        public MonthCalendar moncalUpdate;
        public NumericUpDown nUpdown_Score;
        public TextBox txtbox_UpdateLastName;
        public TextBox txtbox_UpdateFirstName;
    }
}