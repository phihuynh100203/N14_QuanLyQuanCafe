
namespace LTCSDL
{
    partial class LienHe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLinkGit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLinkGit);
            this.groupBox1.Location = new System.Drawing.Point(24, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Github";
            // 
            // lbLinkGit
            // 
            this.lbLinkGit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLinkGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinkGit.ForeColor = System.Drawing.Color.Blue;
            this.lbLinkGit.Location = new System.Drawing.Point(3, 22);
            this.lbLinkGit.Name = "lbLinkGit";
            this.lbLinkGit.Size = new System.Drawing.Size(747, 90);
            this.lbLinkGit.TabIndex = 0;
            this.lbLinkGit.Text = "https://github.com/phihuynh100203/N14_QuanLyQuanCafe";
            this.lbLinkGit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLinkGit.Click += new System.EventHandler(this.lbLinkGit_Click);
            // 
            // LienHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "LienHe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LienHe";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLinkGit;
    }
}