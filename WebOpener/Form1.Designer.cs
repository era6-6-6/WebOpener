
namespace WebOpener
{
    partial class WebOpener
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
            this.pageTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountLbl = new System.Windows.Forms.Label();
            this.OpenPageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pageTxt
            // 
            this.pageTxt.Location = new System.Drawing.Point(88, 63);
            this.pageTxt.Name = "pageTxt";
            this.pageTxt.Size = new System.Drawing.Size(313, 23);
            this.pageTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "WebPage:";
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CountLbl.Location = new System.Drawing.Point(23, 140);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(38, 15);
            this.CountLbl.TabIndex = 2;
            this.CountLbl.Text = "label2";
            // 
            // OpenPageBtn
            // 
            this.OpenPageBtn.Location = new System.Drawing.Point(407, 63);
            this.OpenPageBtn.Name = "OpenPageBtn";
            this.OpenPageBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenPageBtn.TabIndex = 3;
            this.OpenPageBtn.Text = "Navigate";
            this.OpenPageBtn.UseVisualStyleBackColor = true;
            this.OpenPageBtn.Click += new System.EventHandler(this.OpenPageBtn_Click);
            // 
            // WebOpener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 164);
            this.Controls.Add(this.OpenPageBtn);
            this.Controls.Add(this.CountLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pageTxt);
            this.Name = "WebOpener";
            this.Text = "WebOpener";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pageTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.Button OpenPageBtn;
    }
}

