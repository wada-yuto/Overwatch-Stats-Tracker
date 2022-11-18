
namespace ApexDatabaseApplication
{
    partial class RankTeamHighestWinFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uxCharacerComboBox = new System.Windows.Forms.ComboBox();
            this.Execute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(27, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rank team with highest win percentage on \r\na specific map";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.uxCharacerComboBox);
            this.panel3.Controls.Add(this.Execute);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(34, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 261);
            this.panel3.TabIndex = 6;
            // 
            // uxCharacerComboBox
            // 
            this.uxCharacerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.uxCharacerComboBox.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCharacerComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.uxCharacerComboBox.FormattingEnabled = true;
            this.uxCharacerComboBox.Items.AddRange(new object[] {
            "Busan",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis",
            "Circuit Royal",
            "Dorado",
            "Havana",
            "Junkertown",
            "Rialto",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Blizzard World",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Midtown",
            "Numbani",
            "Paraiso",
            "Colosseo",
            "Esperanca",
            "New Queen Street",
            "Ayutthaya",
            "Black Forest",
            "Castillo",
            "Chateau Guillard",
            "Ecopoint: Antarctica",
            "Kanezaka",
            "Malevento",
            "Necropolis",
            "Petra",
            "Workshop",
            "Hanamura",
            "Horizon Lunar Colony",
            "Paris",
            "Temple of Anubis",
            "Volskaya Industries"});
            this.uxCharacerComboBox.Location = new System.Drawing.Point(10, 53);
            this.uxCharacerComboBox.Name = "uxCharacerComboBox";
            this.uxCharacerComboBox.Size = new System.Drawing.Size(422, 38);
            this.uxCharacerComboBox.TabIndex = 10;
            this.uxCharacerComboBox.Text = "Maps";
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Execute.Location = new System.Drawing.Point(410, 194);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(226, 64);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Find";
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
            this.label2.Size = new System.Drawing.Size(191, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a map";
            // 
            // uxDataView
            // 
            this.uxDataView.AllowUserToOrderColumns = true;
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Location = new System.Drawing.Point(34, 346);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(639, 186);
            this.uxDataView.TabIndex = 7;
            // 
            // RankTeamHighestWinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(752, 556);
            this.Controls.Add(this.uxDataView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Name = "RankTeamHighestWinFrm";
            this.Text = "Rank Team With Highest Win Percentage";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uxCharacerComboBox;
        private System.Windows.Forms.DataGridView uxDataView;
    }
}