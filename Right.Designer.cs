namespace Animation
{
    partial class Right
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
            this.form_panel = new System.Windows.Forms.Panel();
            this.GoLeftBtn = new System.Windows.Forms.Button();
            this.kiki = new System.Windows.Forms.PictureBox();
            this.form_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiki)).BeginInit();
            this.SuspendLayout();
            // 
            // form_panel
            // 
            this.form_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(217)))));
            this.form_panel.BackgroundImage = global::Animation.Properties.Resources.noon_background;
            this.form_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.form_panel.Controls.Add(this.GoLeftBtn);
            this.form_panel.Controls.Add(this.kiki);
            this.form_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_panel.Location = new System.Drawing.Point(0, 0);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(1156, 515);
            this.form_panel.TabIndex = 1;
            // 
            // GoLeftBtn
            // 
            this.GoLeftBtn.BackColor = System.Drawing.Color.Transparent;
            this.GoLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoLeftBtn.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.GoLeftBtn.Location = new System.Drawing.Point(26, 248);
            this.GoLeftBtn.Name = "GoLeftBtn";
            this.GoLeftBtn.Size = new System.Drawing.Size(106, 60);
            this.GoLeftBtn.TabIndex = 8;
            this.GoLeftBtn.Text = "Left ?";
            this.GoLeftBtn.UseVisualStyleBackColor = false;
            this.GoLeftBtn.Click += new System.EventHandler(this.GoLeft);
            this.GoLeftBtn.MouseEnter += new System.EventHandler(this.GoLeftBtn_MouseEnter);
            this.GoLeftBtn.MouseLeave += new System.EventHandler(this.GoLeftBtn_MouseLeave);
            // 
            // kiki
            // 
            this.kiki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.kiki.Image = global::Animation.Properties.Resources.kiki;
            this.kiki.Location = new System.Drawing.Point(470, 39);
            this.kiki.Name = "kiki";
            this.kiki.Size = new System.Drawing.Size(154, 96);
            this.kiki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kiki.TabIndex = 1;
            this.kiki.TabStop = false;
            // 
            // Right
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 515);
            this.Controls.Add(this.form_panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1172, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1172, 554);
            this.Name = "Right";
            this.Text = "Right";
            this.Load += new System.EventHandler(this.Right_Load);
            this.form_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kiki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.PictureBox kiki;
        private System.Windows.Forms.Button GoLeftBtn;
    }
}