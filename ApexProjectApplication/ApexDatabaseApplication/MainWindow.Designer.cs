
namespace ApexDatabaseApplication
{
    partial class uxMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxMainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxQ4 = new System.Windows.Forms.Button();
            this.uxQ3 = new System.Windows.Forms.Button();
            this.uxQ2 = new System.Windows.Forms.Button();
            this.uxQ1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uxLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.uxQ4);
            this.panel1.Controls.Add(this.uxQ3);
            this.panel1.Controls.Add(this.uxQ2);
            this.panel1.Controls.Add(this.uxQ1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 577);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // uxQ4
            // 
            this.uxQ4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxQ4.FlatAppearance.BorderSize = 0;
            this.uxQ4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxQ4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxQ4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uxQ4.Location = new System.Drawing.Point(0, 340);
            this.uxQ4.Name = "uxQ4";
            this.uxQ4.Size = new System.Drawing.Size(200, 70);
            this.uxQ4.TabIndex = 1;
            this.uxQ4.Text = "Query 4";
            this.uxQ4.UseVisualStyleBackColor = true;
            this.uxQ4.Click += new System.EventHandler(this.uxQ4_Click);
            // 
            // uxQ3
            // 
            this.uxQ3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxQ3.FlatAppearance.BorderSize = 0;
            this.uxQ3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxQ3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxQ3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uxQ3.Location = new System.Drawing.Point(0, 270);
            this.uxQ3.Name = "uxQ3";
            this.uxQ3.Size = new System.Drawing.Size(200, 70);
            this.uxQ3.TabIndex = 1;
            this.uxQ3.Text = "Query 3";
            this.uxQ3.UseVisualStyleBackColor = true;
            this.uxQ3.Click += new System.EventHandler(this.uxQ3_Click);
            // 
            // uxQ2
            // 
            this.uxQ2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxQ2.FlatAppearance.BorderSize = 0;
            this.uxQ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxQ2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxQ2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uxQ2.Location = new System.Drawing.Point(0, 200);
            this.uxQ2.Name = "uxQ2";
            this.uxQ2.Size = new System.Drawing.Size(200, 70);
            this.uxQ2.TabIndex = 1;
            this.uxQ2.Text = "Character Tracker";
            this.uxQ2.UseVisualStyleBackColor = true;
            this.uxQ2.Click += new System.EventHandler(this.uxQ2_Click);
            // 
            // uxQ1
            // 
            this.uxQ1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxQ1.FlatAppearance.BorderSize = 0;
            this.uxQ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxQ1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxQ1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uxQ1.Location = new System.Drawing.Point(0, 130);
            this.uxQ1.Name = "uxQ1";
            this.uxQ1.Size = new System.Drawing.Size(200, 70);
            this.uxQ1.TabIndex = 1;
            this.uxQ1.Text = "Find tournament winner";
            this.uxQ1.UseVisualStyleBackColor = true;
            this.uxQ1.Click += new System.EventHandler(this.uxQ1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 130);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-58, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uxLoader
            // 
            this.uxLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxLoader.Location = new System.Drawing.Point(200, 3);
            this.uxLoader.Name = "uxLoader";
            this.uxLoader.Size = new System.Drawing.Size(751, 574);
            this.uxLoader.TabIndex = 1;
            // 
            // uxMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.uxLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "uxMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apex Stat Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uxQ4;
        private System.Windows.Forms.Button uxQ3;
        private System.Windows.Forms.Button uxQ2;
        private System.Windows.Forms.Button uxQ1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel uxLoader;
    }
}

