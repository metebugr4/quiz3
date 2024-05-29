namespace WindowsFormsApp1
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
            this.readbtn = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            this.marketlstbx = new System.Windows.Forms.ListBox();
            this.itemcountlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readbtn
            // 
            this.readbtn.Location = new System.Drawing.Point(12, 36);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(110, 36);
            this.readbtn.TabIndex = 0;
            this.readbtn.Text = "Read All Data";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.Location = new System.Drawing.Point(21, 232);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(110, 36);
            this.reportbtn.TabIndex = 1;
            this.reportbtn.Text = "Report";
            this.reportbtn.UseVisualStyleBackColor = true;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // marketlstbx
            // 
            this.marketlstbx.FormattingEnabled = true;
            this.marketlstbx.Location = new System.Drawing.Point(370, 36);
            this.marketlstbx.Name = "marketlstbx";
            this.marketlstbx.Size = new System.Drawing.Size(211, 381);
            this.marketlstbx.TabIndex = 2;
            // 
            // itemcountlbl
            // 
            this.itemcountlbl.AutoSize = true;
            this.itemcountlbl.Location = new System.Drawing.Point(44, 110);
            this.itemcountlbl.Name = "itemcountlbl";
            this.itemcountlbl.Size = new System.Drawing.Size(0, 13);
            this.itemcountlbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemcountlbl);
            this.Controls.Add(this.marketlstbx);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.readbtn);
            this.Name = "Form1";
            this.Text = "Quiz3/202003001056/MeteBugraDikbas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readbtn;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.ListBox marketlstbx;
        private System.Windows.Forms.Label itemcountlbl;
    }
}

