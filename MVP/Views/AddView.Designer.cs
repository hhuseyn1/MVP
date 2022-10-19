namespace MVP.Views
{
    partial class AddView
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
            this.txtbox_SaveFirstName = new System.Windows.Forms.TextBox();
            this.txtbox_SaveLastName = new System.Windows.Forms.TextBox();
            this.nUpdown_Score = new System.Windows.Forms.NumericUpDown();
            this.moncal = new System.Windows.Forms.MonthCalendar();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpdown_Score)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_SaveFirstName
            // 
            this.txtbox_SaveFirstName.Location = new System.Drawing.Point(24, 33);
            this.txtbox_SaveFirstName.Name = "txtbox_SaveFirstName";
            this.txtbox_SaveFirstName.PlaceholderText = "FirstName";
            this.txtbox_SaveFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtbox_SaveFirstName.TabIndex = 0;
            // 
            // txtbox_SaveLastName
            // 
            this.txtbox_SaveLastName.Location = new System.Drawing.Point(24, 62);
            this.txtbox_SaveLastName.Name = "txtbox_SaveLastName";
            this.txtbox_SaveLastName.PlaceholderText = "LastName";
            this.txtbox_SaveLastName.Size = new System.Drawing.Size(100, 23);
            this.txtbox_SaveLastName.TabIndex = 1;
            // 
            // nUpdown_Score
            // 
            this.nUpdown_Score.Location = new System.Drawing.Point(24, 100);
            this.nUpdown_Score.Name = "nUpdown_Score";
            this.nUpdown_Score.Size = new System.Drawing.Size(120, 23);
            this.nUpdown_Score.TabIndex = 2;
            // 
            // moncal
            // 
            this.moncal.Location = new System.Drawing.Point(190, 33);
            this.moncal.Name = "moncal";
            this.moncal.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Green;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(24, 172);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(105, 172);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 237);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.moncal);
            this.Controls.Add(this.nUpdown_Score);
            this.Controls.Add(this.txtbox_SaveLastName);
            this.Controls.Add(this.txtbox_SaveFirstName);
            this.Name = "AddView";
            this.Text = "AddView";
            ((System.ComponentModel.ISupportInitialize)(this.nUpdown_Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbox_SaveFirstName;
        private TextBox txtbox_SaveLastName;
        private NumericUpDown nUpdown_Score;
        private MonthCalendar moncal;
        private Button btn_Save;
        private Button btn_Cancel;
    }
}