
namespace AirHeatModel_Sim
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numMV = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numTi = new System.Windows.Forms.NumericUpDown();
            this.numSP = new System.Windows.Forms.NumericUpDown();
            this.numKp = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radAut = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Temperature Un-Filtered";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Temperature Filtered";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1113, 443);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // numMV
            // 
            this.numMV.Location = new System.Drawing.Point(127, 49);
            this.numMV.Name = "numMV";
            this.numMV.Size = new System.Drawing.Size(120, 20);
            this.numMV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAN Control Signal [V]";
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(7, 19);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(60, 17);
            this.radMan.TabIndex = 4;
            this.radMan.TabStop = true;
            this.radMan.Text = "Manual";
            this.radMan.UseVisualStyleBackColor = true;
            this.radMan.Click += new System.EventHandler(this.radMan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numMV);
            this.groupBox1.Location = new System.Drawing.Point(12, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numTi);
            this.groupBox2.Controls.Add(this.numSP);
            this.groupBox2.Controls.Add(this.numKp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radAut);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 545);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 133);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // numTi
            // 
            this.numTi.Location = new System.Drawing.Point(127, 102);
            this.numTi.Name = "numTi";
            this.numTi.Size = new System.Drawing.Size(120, 20);
            this.numTi.TabIndex = 9;
            // 
            // numSP
            // 
            this.numSP.Location = new System.Drawing.Point(127, 50);
            this.numSP.Name = "numSP";
            this.numSP.Size = new System.Drawing.Size(120, 20);
            this.numSP.TabIndex = 5;
            // 
            // numKp
            // 
            this.numKp.Location = new System.Drawing.Point(127, 76);
            this.numKp.Name = "numKp";
            this.numKp.Size = new System.Drawing.Size(120, 20);
            this.numKp.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ti (integral):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kp (gain):";
            // 
            // radAut
            // 
            this.radAut.AutoSize = true;
            this.radAut.Location = new System.Drawing.Point(7, 19);
            this.radAut.Name = "radAut";
            this.radAut.Size = new System.Drawing.Size(47, 17);
            this.radAut.TabIndex = 4;
            this.radAut.TabStop = true;
            this.radAut.Text = "Auto";
            this.radAut.UseVisualStyleBackColor = true;
            this.radAut.Click += new System.EventHandler(this.radAut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AUTO SP [degrees C]";
            // 
            // txtPV
            // 
            this.txtPV.BackColor = System.Drawing.Color.White;
            this.txtPV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPV.Location = new System.Drawing.Point(930, 382);
            this.txtPV.Name = "txtPV";
            this.txtPV.ReadOnly = true;
            this.txtPV.Size = new System.Drawing.Size(77, 38);
            this.txtPV.TabIndex = 7;
            this.txtPV.Text = "20,0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(876, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "PV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1000, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "°C";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(297, 465);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Control Signal";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(827, 212);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1072, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "[V]";
            // 
            // txtMV
            // 
            this.txtMV.BackColor = System.Drawing.Color.White;
            this.txtMV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMV.Location = new System.Drawing.Point(1003, 618);
            this.txtMV.Name = "txtMV";
            this.txtMV.ReadOnly = true;
            this.txtMV.Size = new System.Drawing.Size(77, 38);
            this.txtMV.TabIndex = 12;
            this.txtMV.Text = "20,0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(946, 622);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 31);
            this.label9.TabIndex = 13;
            this.label9.Text = "MV:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 688);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPV);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Control System Air Heater";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numMV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radAut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSP;
        private System.Windows.Forms.NumericUpDown numKp;
        private System.Windows.Forms.NumericUpDown numTi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMV;
        private System.Windows.Forms.Label label9;
    }
}

