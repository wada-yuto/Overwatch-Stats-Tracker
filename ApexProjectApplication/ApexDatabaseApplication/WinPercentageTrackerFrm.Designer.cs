
namespace ApexDatabaseApplication
{
    partial class WinPercentageTrackerFrm
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
            this.uxCharacerComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.uxCharacerComboBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Execute);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(34, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 295);
            this.panel3.TabIndex = 4;
            // 
            // uxCharacerComboBox
            // 
            this.uxCharacerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.uxCharacerComboBox.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCharacerComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.uxCharacerComboBox.FormattingEnabled = true;
            this.uxCharacerComboBox.Items.AddRange(new object[] {
            "Ana",
            "Ashe",
            "Baptiste",
            "Bastion",
            "Brgitte",
            "Cassidy",
            "Doomfist",
            "D.va",
            "Echo",
            "Genji",
            "Hanzo",
            "Junker Queen",
            "Junkrat",
            "Kiriko",
            "Lucio",
            "Mei",
            "Mercy",
            "Moira",
            "Orisa",
            "Pharah",
            "Reaper",
            "Reinhardt",
            "Roadhog",
            "Sigma",
            "Soldier:76",
            "Sombra",
            "Symmetra",
            "Torbijorn",
            "Tracer",
            "Widowmaker",
            "WInston",
            "Wrecking Ball",
            "Zarya",
            "Zenyatta"});
            this.uxCharacerComboBox.Location = new System.Drawing.Point(10, 93);
            this.uxCharacerComboBox.Name = "uxCharacerComboBox";
            this.uxCharacerComboBox.Size = new System.Drawing.Size(422, 38);
            this.uxCharacerComboBox.TabIndex = 9;
            this.uxCharacerComboBox.Text = "Characters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(5, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = "This function takes in a character name, \r\nand returns the win percentage for tha" +
    "t character\r\n";
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Execute.Location = new System.Drawing.Point(461, 198);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(206, 77);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Find!";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 80);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select the Character you want to find \r\nwin percentage for:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Character win percentage tracker";
            // 
            // uxDataView
            // 
            this.uxDataView.AllowUserToOrderColumns = true;
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Location = new System.Drawing.Point(35, 364);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(682, 186);
            this.uxDataView.TabIndex = 5;
            // 
            // WinPercentageTrackerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(752, 581);
            this.Controls.Add(this.uxDataView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Name = "WinPercentageTrackerFrm";
            this.Text = "Tournament winner tracker";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView uxDataView;
        private System.Windows.Forms.ComboBox uxCharacerComboBox;
    }
}