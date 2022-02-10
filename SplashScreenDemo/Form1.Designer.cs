
namespace SplashScreenDemo
{
    partial class SplashScreenForm
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
            this.components = new System.ComponentModel.Container();
            this.ProgressOuterPanel = new System.Windows.Forms.Panel();
            this.ProgressInnerPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressOuterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressOuterPanel
            // 
            this.ProgressOuterPanel.Controls.Add(this.ProgressInnerPanel);
            this.ProgressOuterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressOuterPanel.Location = new System.Drawing.Point(0, 390);
            this.ProgressOuterPanel.Name = "ProgressOuterPanel";
            this.ProgressOuterPanel.Size = new System.Drawing.Size(700, 10);
            this.ProgressOuterPanel.TabIndex = 0;
            // 
            // ProgressInnerPanel
            // 
            this.ProgressInnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(218)))), ((int)(((byte)(157)))));
            this.ProgressInnerPanel.Location = new System.Drawing.Point(0, 0);
            this.ProgressInnerPanel.Name = "ProgressInnerPanel";
            this.ProgressInnerPanel.Size = new System.Drawing.Size(0, 10);
            this.ProgressInnerPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressOuterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            this.ProgressOuterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProgressOuterPanel;
        private System.Windows.Forms.Panel ProgressInnerPanel;
        private System.Windows.Forms.Timer timer1;
    }
}

