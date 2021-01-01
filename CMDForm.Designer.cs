
namespace LCPLauncher
{
    partial class CMDForm
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
            this.tbCMDProcess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCMDProcess
            // 
            this.tbCMDProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCMDProcess.Font = new System.Drawing.Font("Audiowide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMDProcess.Location = new System.Drawing.Point(0, 0);
            this.tbCMDProcess.Multiline = true;
            this.tbCMDProcess.Name = "tbCMDProcess";
            this.tbCMDProcess.ReadOnly = true;
            this.tbCMDProcess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCMDProcess.Size = new System.Drawing.Size(711, 297);
            this.tbCMDProcess.TabIndex = 0;
            // 
            // CMDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(711, 297);
            this.Controls.Add(this.tbCMDProcess);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CMDForm";
            this.Text = "LCP Launcher - CMD Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CMDForm_FormClosing);
            this.Load += new System.EventHandler(this.CMDForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCMDProcess;
    }
}