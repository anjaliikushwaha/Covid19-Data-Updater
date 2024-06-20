namespace covid19
{
    partial class showreport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showreport));
            this.label1 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecovered = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDeath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVaccine = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblTodayNew = new System.Windows.Forms.Label();
            this.lblTodayRecovered = new System.Windows.Forms.Label();
            this.lblTodayDeath = new System.Windows.Forms.Label();
            this.lblTodayVaccine = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "COVID-19  WORLDOMETER ";
            // 
            // cbState
            // 
            this.cbState.Enabled = false;
            this.cbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.FormattingEnabled = true;
            this.cbState.ItemHeight = 16;
            this.cbState.Items.AddRange(new object[] {
            "ALL"});
            this.cbState.Location = new System.Drawing.Point(320, 92);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(185, 24);
            this.cbState.TabIndex = 4;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.ItemHeight = 16;
            this.cbCountry.Items.AddRange(new object[] {
            "ALL"});
            this.cbCountry.Location = new System.Drawing.Point(113, 92);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(185, 24);
            this.cbCountry.TabIndex = 3;
            this.cbCountry.Tag = "";
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(75, 201);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 31);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Cases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(249, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recovered";
            // 
            // lblRecovered
            // 
            this.lblRecovered.AutoSize = true;
            this.lblRecovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecovered.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRecovered.Location = new System.Drawing.Point(249, 201);
            this.lblRecovered.Name = "lblRecovered";
            this.lblRecovered.Size = new System.Drawing.Size(29, 31);
            this.lblRecovered.TabIndex = 7;
            this.lblRecovered.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(410, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Deaths";
            // 
            // lblDeath
            // 
            this.lblDeath.AutoSize = true;
            this.lblDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeath.ForeColor = System.Drawing.Color.Red;
            this.lblDeath.Location = new System.Drawing.Point(410, 201);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(29, 31);
            this.lblDeath.TabIndex = 9;
            this.lblDeath.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vaccinated";
            // 
            // lblVaccine
            // 
            this.lblVaccine.AutoSize = true;
            this.lblVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccine.Location = new System.Drawing.Point(74, 300);
            this.lblVaccine.Name = "lblVaccine";
            this.lblVaccine.Size = new System.Drawing.Size(29, 31);
            this.lblVaccine.TabIndex = 11;
            this.lblVaccine.Text = "0";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCountry.Location = new System.Drawing.Point(77, 143);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(95, 17);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "WORLDWIDE";
            // 
            // lblTodayNew
            // 
            this.lblTodayNew.AutoSize = true;
            this.lblTodayNew.BackColor = System.Drawing.SystemColors.Control;
            this.lblTodayNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayNew.Location = new System.Drawing.Point(74, 234);
            this.lblTodayNew.Name = "lblTodayNew";
            this.lblTodayNew.Size = new System.Drawing.Size(71, 15);
            this.lblTodayNew.TabIndex = 14;
            this.lblTodayNew.Text = "Total Cases";
            // 
            // lblTodayRecovered
            // 
            this.lblTodayRecovered.AutoSize = true;
            this.lblTodayRecovered.BackColor = System.Drawing.SystemColors.Control;
            this.lblTodayRecovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayRecovered.Location = new System.Drawing.Point(248, 234);
            this.lblTodayRecovered.Name = "lblTodayRecovered";
            this.lblTodayRecovered.Size = new System.Drawing.Size(71, 15);
            this.lblTodayRecovered.TabIndex = 15;
            this.lblTodayRecovered.Text = "Total Cases";
            // 
            // lblTodayDeath
            // 
            this.lblTodayDeath.AutoSize = true;
            this.lblTodayDeath.BackColor = System.Drawing.SystemColors.Control;
            this.lblTodayDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDeath.Location = new System.Drawing.Point(409, 234);
            this.lblTodayDeath.Name = "lblTodayDeath";
            this.lblTodayDeath.Size = new System.Drawing.Size(71, 15);
            this.lblTodayDeath.TabIndex = 16;
            this.lblTodayDeath.Text = "Total Cases";
            // 
            // lblTodayVaccine
            // 
            this.lblTodayVaccine.AutoSize = true;
            this.lblTodayVaccine.BackColor = System.Drawing.SystemColors.Control;
            this.lblTodayVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayVaccine.Location = new System.Drawing.Point(72, 333);
            this.lblTodayVaccine.Name = "lblTodayVaccine";
            this.lblTodayVaccine.Size = new System.Drawing.Size(71, 15);
            this.lblTodayVaccine.TabIndex = 17;
            this.lblTodayVaccine.Text = "Total Cases";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(587, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(196, 262);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(434, 222);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // showreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 496);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTodayVaccine);
            this.Controls.Add(this.lblTodayDeath);
            this.Controls.Add(this.lblTodayRecovered);
            this.Controls.Add(this.lblTodayNew);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblVaccine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDeath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecovered);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "showreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showreport";
            this.Load += new System.EventHandler(this.showreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecovered;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDeath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVaccine;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTodayNew;
        private System.Windows.Forms.Label lblTodayRecovered;
        private System.Windows.Forms.Label lblTodayDeath;
        private System.Windows.Forms.Label lblTodayVaccine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}