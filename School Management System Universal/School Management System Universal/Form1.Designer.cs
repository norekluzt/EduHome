namespace School_Management_System_Universal
{
    partial class SelectSchool_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSchool_frm));
            this.Continue_btn = new System.Windows.Forms.Button();
            this.SchoolName_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Continue_btn
            // 
            this.Continue_btn.BackColor = System.Drawing.Color.Transparent;
            this.Continue_btn.BackgroundImage = global::School_Management_System_Universal.Properties.Resources.icons8_forward_button_64px;
            this.Continue_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Continue_btn.FlatAppearance.BorderSize = 0;
            this.Continue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue_btn.Location = new System.Drawing.Point(765, 112);
            this.Continue_btn.Name = "Continue_btn";
            this.Continue_btn.Size = new System.Drawing.Size(45, 33);
            this.Continue_btn.TabIndex = 0;
            this.Continue_btn.UseVisualStyleBackColor = false;
            this.Continue_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SchoolName_cmbx
            // 
            this.SchoolName_cmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolName_cmbx.FormattingEnabled = true;
            this.SchoolName_cmbx.Location = new System.Drawing.Point(25, 112);
            this.SchoolName_cmbx.Name = "SchoolName_cmbx";
            this.SchoolName_cmbx.Size = new System.Drawing.Size(734, 33);
            this.SchoolName_cmbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Select the school of which you are enrolled on.";
            // 
            // SelectSchool_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::School_Management_System_Universal.Properties.Resources.Strt_bg;
            this.ClientSize = new System.Drawing.Size(831, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SchoolName_cmbx);
            this.Controls.Add(this.Continue_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectSchool_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System Universal";
            this.Load += new System.EventHandler(this.SelectSchool_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Continue_btn;
        private System.Windows.Forms.ComboBox SchoolName_cmbx;
        private System.Windows.Forms.Label label1;
    }
}

