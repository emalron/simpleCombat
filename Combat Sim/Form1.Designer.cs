namespace Combat_Sim
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNumReds = new System.Windows.Forms.NumericUpDown();
            this.numericNumBlues = new System.Windows.Forms.NumericUpDown();
            this.numPowerBlues = new System.Windows.Forms.NumericUpDown();
            this.numPowerReds = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numHpBlues = new System.Windows.Forms.NumericUpDown();
            this.numHpReds = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumReds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPowerBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPowerReds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHpBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHpReds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blues";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "number";
            // 
            // numericNumReds
            // 
            this.numericNumReds.Location = new System.Drawing.Point(72, 36);
            this.numericNumReds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericNumReds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumReds.Name = "numericNumReds";
            this.numericNumReds.Size = new System.Drawing.Size(120, 25);
            this.numericNumReds.TabIndex = 4;
            this.numericNumReds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericNumBlues
            // 
            this.numericNumBlues.Location = new System.Drawing.Point(323, 38);
            this.numericNumBlues.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericNumBlues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumBlues.Name = "numericNumBlues";
            this.numericNumBlues.Size = new System.Drawing.Size(120, 25);
            this.numericNumBlues.TabIndex = 5;
            this.numericNumBlues.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numPowerBlues
            // 
            this.numPowerBlues.Location = new System.Drawing.Point(323, 120);
            this.numPowerBlues.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPowerBlues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPowerBlues.Name = "numPowerBlues";
            this.numPowerBlues.Size = new System.Drawing.Size(120, 25);
            this.numPowerBlues.TabIndex = 9;
            this.numPowerBlues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPowerReds
            // 
            this.numPowerReds.Location = new System.Drawing.Point(72, 118);
            this.numPowerReds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPowerReds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPowerReds.Name = "numPowerReds";
            this.numPowerReds.Size = new System.Drawing.Size(120, 25);
            this.numPowerReds.TabIndex = 8;
            this.numPowerReds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "power";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "power";
            // 
            // numHpBlues
            // 
            this.numHpBlues.Location = new System.Drawing.Point(323, 78);
            this.numHpBlues.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHpBlues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHpBlues.Name = "numHpBlues";
            this.numHpBlues.Size = new System.Drawing.Size(120, 25);
            this.numHpBlues.TabIndex = 13;
            this.numHpBlues.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numHpReds
            // 
            this.numHpReds.Location = new System.Drawing.Point(72, 76);
            this.numHpReds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHpReds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHpReds.Name = "numHpReds";
            this.numHpReds.Size = new System.Drawing.Size(120, 25);
            this.numHpReds.TabIndex = 12;
            this.numHpReds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "HP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "HP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 107);
            this.button1.TabIndex = 14;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 107);
            this.button2.TabIndex = 15;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(15, 165);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(667, 347);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(685, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Messages";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(688, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 474);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 524);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numHpBlues);
            this.Controls.Add(this.numHpReds);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numPowerBlues);
            this.Controls.Add(this.numPowerReds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericNumBlues);
            this.Controls.Add(this.numericNumReds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Combat sim";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumReds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPowerBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPowerReds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHpBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHpReds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericNumReds;
        private System.Windows.Forms.NumericUpDown numericNumBlues;
        private System.Windows.Forms.NumericUpDown numPowerBlues;
        private System.Windows.Forms.NumericUpDown numPowerReds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numHpBlues;
        private System.Windows.Forms.NumericUpDown numHpReds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

