namespace GameRR_Simple
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.ShootAt = new System.Windows.Forms.Button();
            this.ShootHd = new System.Windows.Forms.Button();
            this.PLyAgn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(22, 419);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(149, 72);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Spin
            // 
            this.Spin.Enabled = false;
            this.Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.Location = new System.Drawing.Point(190, 419);
            this.Spin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(149, 72);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // ShootAt
            // 
            this.ShootAt.Enabled = false;
            this.ShootAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAt.Location = new System.Drawing.Point(359, 419);
            this.ShootAt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShootAt.Name = "ShootAt";
            this.ShootAt.Size = new System.Drawing.Size(204, 72);
            this.ShootAt.TabIndex = 2;
            this.ShootAt.Text = "Shoot At head";
            this.ShootAt.UseVisualStyleBackColor = true;
            this.ShootAt.Click += new System.EventHandler(this.ShootAt_Click);
            // 
            // ShootHd
            // 
            this.ShootHd.Enabled = false;
            this.ShootHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootHd.Location = new System.Drawing.Point(582, 419);
            this.ShootHd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShootHd.Name = "ShootHd";
            this.ShootHd.Size = new System.Drawing.Size(212, 72);
            this.ShootHd.TabIndex = 3;
            this.ShootHd.Text = "Shoot Away";
            this.ShootHd.UseVisualStyleBackColor = true;
            this.ShootHd.Click += new System.EventHandler(this.ShootHd_Click);
            // 
            // PLyAgn
            // 
            this.PLyAgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLyAgn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PLyAgn.Location = new System.Drawing.Point(818, 419);
            this.PLyAgn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PLyAgn.Name = "PLyAgn";
            this.PLyAgn.Size = new System.Drawing.Size(149, 72);
            this.PLyAgn.TabIndex = 4;
            this.PLyAgn.Text = "Try again";
            this.PLyAgn.UseVisualStyleBackColor = true;
            this.PLyAgn.Click += new System.EventHandler(this.PLyAgn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(117, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PLyAgn);
            this.Controls.Add(this.ShootHd);
            this.Controls.Add(this.ShootAt);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button ShootAt;
        private System.Windows.Forms.Button ShootHd;
        private System.Windows.Forms.Button PLyAgn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

