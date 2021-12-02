namespace Animation
{
    partial class Animation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animation));
            this.form_panel = new System.Windows.Forms.Panel();
            this.GoLeftBtn = new System.Windows.Forms.Button();
            this.cloud_4 = new System.Windows.Forms.PictureBox();
            this.cloud_3 = new System.Windows.Forms.PictureBox();
            this.cloud_1 = new System.Windows.Forms.PictureBox();
            this.cloud_2 = new System.Windows.Forms.PictureBox();
            this.kiki = new System.Windows.Forms.PictureBox();
            this.GoRightBtn = new System.Windows.Forms.Button();
            this.form_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiki)).BeginInit();
            this.SuspendLayout();
            // 
            // form_panel
            // 
            this.form_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.form_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("form_panel.BackgroundImage")));
            this.form_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.form_panel.Controls.Add(this.GoRightBtn);
            this.form_panel.Controls.Add(this.GoLeftBtn);
            this.form_panel.Controls.Add(this.cloud_4);
            this.form_panel.Controls.Add(this.cloud_3);
            this.form_panel.Controls.Add(this.cloud_1);
            this.form_panel.Controls.Add(this.cloud_2);
            this.form_panel.Controls.Add(this.kiki);
            this.form_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_panel.Location = new System.Drawing.Point(0, 0);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(1156, 515);
            this.form_panel.TabIndex = 1;
            this.form_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.OverlappingImages);
            // 
            // GoLeftBtn
            // 
            this.GoLeftBtn.BackColor = System.Drawing.Color.Transparent;
            this.GoLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoLeftBtn.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.GoLeftBtn.Location = new System.Drawing.Point(34, 243);
            this.GoLeftBtn.Name = "GoLeftBtn";
            this.GoLeftBtn.Size = new System.Drawing.Size(106, 60);
            this.GoLeftBtn.TabIndex = 7;
            this.GoLeftBtn.Text = "Left ?";
            this.GoLeftBtn.UseVisualStyleBackColor = false;
            this.GoLeftBtn.Click += new System.EventHandler(this.GoLeft);
            this.GoLeftBtn.MouseEnter += new System.EventHandler(this.GoLeftBtn_MouseEnter);
            this.GoLeftBtn.MouseLeave += new System.EventHandler(this.GoLeftBtn_MouseLeave);
            // 
            // cloud_4
            // 
            this.cloud_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.cloud_4.Image = global::Animation.Properties.Resources.cloud_4;
            this.cloud_4.Location = new System.Drawing.Point(660, 106);
            this.cloud_4.Name = "cloud_4";
            this.cloud_4.Size = new System.Drawing.Size(147, 72);
            this.cloud_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud_4.TabIndex = 4;
            this.cloud_4.TabStop = false;
            // 
            // cloud_3
            // 
            this.cloud_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.cloud_3.Image = global::Animation.Properties.Resources.cloud_3;
            this.cloud_3.Location = new System.Drawing.Point(839, 12);
            this.cloud_3.Name = "cloud_3";
            this.cloud_3.Size = new System.Drawing.Size(191, 92);
            this.cloud_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud_3.TabIndex = 3;
            this.cloud_3.TabStop = false;
            // 
            // cloud_1
            // 
            this.cloud_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cloud_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.cloud_1.Image = global::Animation.Properties.Resources.cloud_1;
            this.cloud_1.Location = new System.Drawing.Point(891, 119);
            this.cloud_1.Name = "cloud_1";
            this.cloud_1.Size = new System.Drawing.Size(240, 85);
            this.cloud_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud_1.TabIndex = 1;
            this.cloud_1.TabStop = false;
            // 
            // cloud_2
            // 
            this.cloud_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.cloud_2.Image = global::Animation.Properties.Resources.cloud_2;
            this.cloud_2.Location = new System.Drawing.Point(379, 52);
            this.cloud_2.Name = "cloud_2";
            this.cloud_2.Size = new System.Drawing.Size(338, 91);
            this.cloud_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud_2.TabIndex = 2;
            this.cloud_2.TabStop = false;
            // 
            // kiki
            // 
            this.kiki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kiki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(40)))), ((int)(((byte)(77)))));
            this.kiki.Image = global::Animation.Properties.Resources.kiki;
            this.kiki.Location = new System.Drawing.Point(439, 181);
            this.kiki.Name = "kiki";
            this.kiki.Size = new System.Drawing.Size(154, 96);
            this.kiki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kiki.TabIndex = 0;
            this.kiki.TabStop = false;
            // 
            // GoRightBtn
            // 
            this.GoRightBtn.BackColor = System.Drawing.Color.Transparent;
            this.GoRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoRightBtn.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.GoRightBtn.Location = new System.Drawing.Point(1004, 243);
            this.GoRightBtn.Name = "GoRightBtn";
            this.GoRightBtn.Size = new System.Drawing.Size(127, 60);
            this.GoRightBtn.TabIndex = 9;
            this.GoRightBtn.Text = "Right ?";
            this.GoRightBtn.UseVisualStyleBackColor = false;
            this.GoRightBtn.Click += new System.EventHandler(this.GoRight);
            this.GoRightBtn.MouseEnter += new System.EventHandler(this.GoRightBtn_MouseEnter);
            this.GoRightBtn.MouseLeave += new System.EventHandler(this.GoRightBtn_MouseLeave);
            // 
            // Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1156, 515);
            this.Controls.Add(this.form_panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1172, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1172, 554);
            this.Name = "Animation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation";
            this.Load += new System.EventHandler(this.Animation_Load);
            this.form_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cloud_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kiki;
        private System.Windows.Forms.PictureBox cloud_2;
        private System.Windows.Forms.PictureBox cloud_1;
        private System.Windows.Forms.PictureBox cloud_3;
        private System.Windows.Forms.PictureBox cloud_4;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.Button GoLeftBtn;
        private System.Windows.Forms.Button GoRightBtn;
    }
}

