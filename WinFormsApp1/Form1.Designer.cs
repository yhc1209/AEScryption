
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_BROWSE = new System.Windows.Forms.Button();
            this.BTN_MAKEFILE = new System.Windows.Forms.Button();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.LBL_FILEPATH = new System.Windows.Forms.Label();
            this.LBL_SAVINGPATH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_BROWSE
            // 
            this.BTN_BROWSE.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_BROWSE.Location = new System.Drawing.Point(401, 26);
            this.BTN_BROWSE.Name = "BTN_BROWSE";
            this.BTN_BROWSE.Size = new System.Drawing.Size(86, 26);
            this.BTN_BROWSE.TabIndex = 0;
            this.BTN_BROWSE.Text = "選擇檔案";
            this.BTN_BROWSE.UseVisualStyleBackColor = true;
            this.BTN_BROWSE.Click += new System.EventHandler(this.BTN_BROWSE_Click);
            this.BTN_BROWSE.MouseLeave += new System.EventHandler(this.mouse_leaving);
            // 
            // BTN_MAKEFILE
            // 
            this.BTN_MAKEFILE.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_MAKEFILE.Location = new System.Drawing.Point(401, 67);
            this.BTN_MAKEFILE.Name = "BTN_MAKEFILE";
            this.BTN_MAKEFILE.Size = new System.Drawing.Size(86, 26);
            this.BTN_MAKEFILE.TabIndex = 1;
            this.BTN_MAKEFILE.Text = "加/解密";
            this.BTN_MAKEFILE.UseVisualStyleBackColor = true;
            this.BTN_MAKEFILE.Click += new System.EventHandler(this.BTN_MAKEFILE_Click);
            this.BTN_MAKEFILE.MouseLeave += new System.EventHandler(this.mouse_leaving);
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_STATUS.Location = new System.Drawing.Point(1, 143);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(44, 17);
            this.LBL_STATUS.TabIndex = 2;
            this.LBL_STATUS.Text = "label1";
            this.LBL_STATUS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_FILEPATH
            // 
            this.LBL_FILEPATH.AutoSize = true;
            this.LBL_FILEPATH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_FILEPATH.Location = new System.Drawing.Point(31, 29);
            this.LBL_FILEPATH.Name = "LBL_FILEPATH";
            this.LBL_FILEPATH.Size = new System.Drawing.Size(139, 15);
            this.LBL_FILEPATH.TabIndex = 3;
            this.LBL_FILEPATH.Text = "點擊右側按鈕以選擇檔案";
            this.LBL_FILEPATH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_SAVINGPATH
            // 
            this.LBL_SAVINGPATH.AutoSize = true;
            this.LBL_SAVINGPATH.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_SAVINGPATH.Location = new System.Drawing.Point(31, 70);
            this.LBL_SAVINGPATH.Name = "LBL_SAVINGPATH";
            this.LBL_SAVINGPATH.Size = new System.Drawing.Size(67, 16);
            this.LBL_SAVINGPATH.TabIndex = 4;
            this.LBL_SAVINGPATH.Text = "儲存路徑：";
            this.LBL_SAVINGPATH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(519, 160);
            this.Controls.Add(this.LBL_SAVINGPATH);
            this.Controls.Add(this.LBL_FILEPATH);
            this.Controls.Add(this.LBL_STATUS);
            this.Controls.Add(this.BTN_MAKEFILE);
            this.Controls.Add(this.BTN_BROWSE);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "檔案保護";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_BROWSE;
        private System.Windows.Forms.Button BTN_MAKEFILE;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Label LBL_FILEPATH;
        private System.Windows.Forms.Label LBL_SAVINGPATH;
    }
}

