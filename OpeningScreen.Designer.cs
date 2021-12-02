namespace Animation
{
    partial class OpeningScreen
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
            this.screenPanel = new System.Windows.Forms.Panel();
            this.creditsLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.screenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenPanel
            // 
            this.screenPanel.BackgroundImage = global::Animation.Properties.Resources.opening_screen;
            this.screenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenPanel.Controls.Add(this.creditsLbl);
            this.screenPanel.Controls.Add(this.startBtn);
            this.screenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenPanel.Location = new System.Drawing.Point(0, 0);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(800, 450);
            this.screenPanel.TabIndex = 0;
            // 
            // creditsLbl
            // 
            this.creditsLbl.BackColor = System.Drawing.Color.Transparent;
            this.creditsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLbl.Location = new System.Drawing.Point(579, 198);
            this.creditsLbl.Name = "creditsLbl";
            this.creditsLbl.Size = new System.Drawing.Size(218, 127);
            this.creditsLbl.TabIndex = 1;
            this.creditsLbl.Text = "Made by Yishai Kahalani && David Ohayon";
            this.creditsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(83, 249);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(181, 122);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.Start);
            this.startBtn.MouseEnter += new System.EventHandler(this.StartBtn_MouseEnter);
            this.startBtn.MouseLeave += new System.EventHandler(this.StartBtn_MouseLeave);
            // 
            // OpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.screenPanel);
            this.Name = "OpeningScreen";
            this.Text = "OpeningScreen";
            this.Load += new System.EventHandler(this.OpeningScreen_Load);
            this.screenPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenPanel;
        private System.Windows.Forms.Label creditsLbl;
        private System.Windows.Forms.Button startBtn;
    }
}