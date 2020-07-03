using System.ComponentModel;

namespace SourceCode.Vista
{
    partial class FormInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FormInterface));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.userCtrLogin4 = new SourceCode.Vista.UserCtrLogin();
            this.userCtrLogin3 = new SourceCode.Vista.UserCtrLogin();
            this.userCtrLogin2 = new SourceCode.Vista.UserCtrLogin();
            this.userCtrLogin1 = new SourceCode.Vista.UserCtrLogin();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Controls.Add(this.userCtrLogin4);
            this.MainPanel.Controls.Add(this.userCtrLogin3);
            this.MainPanel.Controls.Add(this.userCtrLogin2);
            this.MainPanel.Controls.Add(this.userCtrLogin1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1026, 709);
            this.MainPanel.TabIndex = 0;
            // 
            // userCtrLogin4
            // 
            this.userCtrLogin4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCtrLogin4.BackColor = System.Drawing.Color.Transparent;
            this.userCtrLogin4.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("userCtrLogin4.BackgroundImage")));
            this.userCtrLogin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userCtrLogin4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userCtrLogin4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrLogin4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.userCtrLogin4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.userCtrLogin4.Location = new System.Drawing.Point(0, 0);
            this.userCtrLogin4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userCtrLogin4.Name = "userCtrLogin4";
            this.userCtrLogin4.Size = new System.Drawing.Size(1026, 709);
            this.userCtrLogin4.TabIndex = 3;
            // 
            // userCtrLogin3
            // 
            this.userCtrLogin3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCtrLogin3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrLogin3.Location = new System.Drawing.Point(0, 0);
            this.userCtrLogin3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userCtrLogin3.Name = "userCtrLogin3";
            this.userCtrLogin3.Size = new System.Drawing.Size(1026, 709);
            this.userCtrLogin3.TabIndex = 2;
            // 
            // userCtrLogin2
            // 
            this.userCtrLogin2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCtrLogin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrLogin2.Location = new System.Drawing.Point(0, 0);
            this.userCtrLogin2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userCtrLogin2.Name = "userCtrLogin2";
            this.userCtrLogin2.Size = new System.Drawing.Size(1026, 709);
            this.userCtrLogin2.TabIndex = 1;
            // 
            // userCtrLogin1
            // 
            this.userCtrLogin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCtrLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrLogin1.Location = new System.Drawing.Point(0, 0);
            this.userCtrLogin1.Margin = new System.Windows.Forms.Padding(6);
            this.userCtrLogin1.Name = "userCtrLogin1";
            this.userCtrLogin1.Size = new System.Drawing.Size(1026, 709);
            this.userCtrLogin1.TabIndex = 0;
            this.userCtrLogin1.Load += new System.EventHandler(this.userCtrLogin1_Load);
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1026, 709);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration System";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel MainPanel;
        private SourceCode.Vista.UserCtrLogin userCtrLogin1;

        #endregion

        private SourceCode.Vista.UserCtrLogin userCtrLogin2;
        private SourceCode.Vista.UserCtrLogin userCtrLogin3;
        private SourceCode.Vista.UserCtrLogin userCtrLogin4;
    }
}