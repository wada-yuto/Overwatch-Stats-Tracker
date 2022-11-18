namespace ApexDatabaseApplication
{
    partial class UpdateTournamentWinner
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.uxWinner = new System.Windows.Forms.ComboBox();
            this.uxTournamentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxT2CB = new System.Windows.Forms.ComboBox();
            this.uxT1CB = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.uxT1CB);
            this.panel3.Controls.Add(this.uxT2CB);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.uxWinner);
            this.panel3.Controls.Add(this.uxTournamentComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Execute);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(39, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 432);
            this.panel3.TabIndex = 9;
            // 
            // uxWinner
            // 
            this.uxWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.uxWinner.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWinner.ForeColor = System.Drawing.SystemColors.Info;
            this.uxWinner.FormattingEnabled = true;
            this.uxWinner.Items.AddRange(new object[] {
            "Atlanta Reign ",
            "Boston Uprising",
            "Chengdu Hunters",
            "Dallas Fuel",
            "Florida Mayhem",
            "Guangzhou Charge",
            "Hangzhou Spark",
            "Houston Outlaws",
            "London Spitfire",
            "Los Angeles Gladitors",
            "Los Angeles Valiant",
            "New York Excelsior",
            "Paris Eternal",
            "Philadelphia Fusion",
            "San Francisco Shock",
            "Seoul Dynasty",
            "Shanghai Dragons",
            "Toronto Defiant",
            "Vancouver Titans",
            "Washington Justice"});
            this.uxWinner.Location = new System.Drawing.Point(3, 320);
            this.uxWinner.Name = "uxWinner";
            this.uxWinner.Size = new System.Drawing.Size(422, 38);
            this.uxWinner.TabIndex = 12;
            this.uxWinner.Text = "Teams";
            // 
            // uxTournamentComboBox
            // 
            this.uxTournamentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.uxTournamentComboBox.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTournamentComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.uxTournamentComboBox.FormattingEnabled = true;
            this.uxTournamentComboBox.Items.AddRange(new object[] {
            "254",
            "255",
            "256"});
            this.uxTournamentComboBox.Location = new System.Drawing.Point(10, 91);
            this.uxTournamentComboBox.Name = "uxTournamentComboBox";
            this.uxTournamentComboBox.Size = new System.Drawing.Size(422, 38);
            this.uxTournamentComboBox.TabIndex = 11;
            this.uxTournamentComboBox.Text = "Tournaments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(4, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Winning Team";
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Execute.Location = new System.Drawing.Point(474, 352);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(206, 77);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Update Winner";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 80);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Tournament You want\r\nTo Update\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Update Tournament Winner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Team 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(3, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Team 2:";
            // 
            // uxT2CB
            // 
            this.uxT2CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.uxT2CB.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxT2CB.ForeColor = System.Drawing.SystemColors.Info;
            this.uxT2CB.FormattingEnabled = true;
            this.uxT2CB.Items.AddRange(new object[] {
            "Atlanta Reign ",
            "Boston Uprising",
            "Chengdu Hunters",
            "Dallas Fuel",
            "Florida Mayhem",
            "Guangzhou Charge",
            "Hangzhou Spark",
            "Houston Outlaws",
            "London Spitfire",
            "Los Angeles Gladitors",
            "Los Angeles Valiant",
            "New York Excelsior",
            "Paris Eternal",
            "Philadelphia Fusion",
            "San Francisco Shock",
            "Seoul Dynasty",
            "Shanghai Dragons",
            "Toronto Defiant",
            "Vancouver Titans",
            "Washington Justice"});
            this.uxT2CB.Location = new System.Drawing.Point(120, 208);
            this.uxT2CB.Name = "uxT2CB";
            this.uxT2CB.Size = new System.Drawing.Size(422, 38);
            this.uxT2CB.TabIndex = 15;
            this.uxT2CB.Text = "Teams";
            // 
            // uxT1CB
            // 
            this.uxT1CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.uxT1CB.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxT1CB.ForeColor = System.Drawing.SystemColors.Info;
            this.uxT1CB.FormattingEnabled = true;
            this.uxT1CB.Items.AddRange(new object[] {
            "Atlanta Reign ",
            "Boston Uprising",
            "Chengdu Hunters",
            "Dallas Fuel",
            "Florida Mayhem",
            "Guangzhou Charge",
            "Hangzhou Spark",
            "Houston Outlaws",
            "London Spitfire",
            "Los Angeles Gladitors",
            "Los Angeles Valiant",
            "New York Excelsior",
            "Paris Eternal",
            "Philadelphia Fusion",
            "San Francisco Shock",
            "Seoul Dynasty",
            "Shanghai Dragons",
            "Toronto Defiant",
            "Vancouver Titans",
            "Washington Justice"});
            this.uxT1CB.Location = new System.Drawing.Point(120, 149);
            this.uxT1CB.Name = "uxT1CB";
            this.uxT1CB.Size = new System.Drawing.Size(422, 38);
            this.uxT1CB.TabIndex = 16;
            this.uxT1CB.Text = "Teams";
            // 
            // UpdateTournamentWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(752, 581);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Name = "UpdateTournamentWinner";
            this.Text = "UpdateTournamentWinner";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxWinner;
        private System.Windows.Forms.ComboBox uxTournamentComboBox;
        private System.Windows.Forms.ComboBox uxT1CB;
        private System.Windows.Forms.ComboBox uxT2CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}