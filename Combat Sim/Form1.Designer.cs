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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.numSpeedBlues = new System.Windows.Forms.NumericUpDown();
            this.numSpeedReds = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numRangeBlues = new System.Windows.Forms.NumericUpDown();
            this.numRangeReds = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numPosBlues = new System.Windows.Forms.NumericUpDown();
            this.numPosReds = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumReds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPowerBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPowerReds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHpBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHpReds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedReds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeReds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosBlues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosReds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blues";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "number";
            // 
            // numericNumReds
            // 
            this.numericNumReds.Location = new System.Drawing.Point(63, 29);
            this.numericNumReds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numericNumReds.Size = new System.Drawing.Size(105, 21);
            this.numericNumReds.TabIndex = 4;
            this.numericNumReds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericNumBlues
            // 
            this.numericNumBlues.Location = new System.Drawing.Point(283, 30);
            this.numericNumBlues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numericNumBlues.Size = new System.Drawing.Size(105, 21);
            this.numericNumBlues.TabIndex = 5;
            this.numericNumBlues.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numPowerBlues
            // 
            this.numPowerBlues.Location = new System.Drawing.Point(283, 96);
            this.numPowerBlues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numPowerBlues.Size = new System.Drawing.Size(105, 21);
            this.numPowerBlues.TabIndex = 9;
            this.numPowerBlues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPowerReds
            // 
            this.numPowerReds.Location = new System.Drawing.Point(63, 94);
            this.numPowerReds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numPowerReds.Size = new System.Drawing.Size(105, 21);
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
            this.label5.Location = new System.Drawing.Point(230, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "power";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "power";
            // 
            // numHpBlues
            // 
            this.numHpBlues.Location = new System.Drawing.Point(283, 62);
            this.numHpBlues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numHpBlues.Size = new System.Drawing.Size(105, 21);
            this.numHpBlues.TabIndex = 13;
            this.numHpBlues.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numHpReds
            // 
            this.numHpReds.Location = new System.Drawing.Point(63, 61);
            this.numHpReds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numHpReds.Size = new System.Drawing.Size(105, 21);
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
            this.label7.Location = new System.Drawing.Point(230, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "HP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "HP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 86);
            this.button1.TabIndex = 14;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 86);
            this.button2.TabIndex = 15;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(13, 287);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(584, 278);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(599, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Messages";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(603, 30);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 535);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // numSpeedBlues
            // 
            this.numSpeedBlues.Location = new System.Drawing.Point(283, 134);
            this.numSpeedBlues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSpeedBlues.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpeedBlues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeedBlues.Name = "numSpeedBlues";
            this.numSpeedBlues.Size = new System.Drawing.Size(105, 21);
            this.numSpeedBlues.TabIndex = 23;
            this.numSpeedBlues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSpeedReds
            // 
            this.numSpeedReds.Location = new System.Drawing.Point(63, 132);
            this.numSpeedReds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSpeedReds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpeedReds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeedReds.Name = "numSpeedReds";
            this.numSpeedReds.Size = new System.Drawing.Size(105, 21);
            this.numSpeedReds.TabIndex = 22;
            this.numSpeedReds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "speed";
            // 
            // numRangeBlues
            // 
            this.numRangeBlues.Location = new System.Drawing.Point(283, 169);
            this.numRangeBlues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numRangeBlues.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRangeBlues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRangeBlues.Name = "numRangeBlues";
            this.numRangeBlues.Size = new System.Drawing.Size(105, 21);
            this.numRangeBlues.TabIndex = 27;
            this.numRangeBlues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRangeReds
            // 
            this.numRangeReds.Location = new System.Drawing.Point(63, 167);
            this.numRangeReds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numRangeReds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRangeReds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRangeReds.Name = "numRangeReds";
            this.numRangeReds.Size = new System.Drawing.Size(105, 21);
            this.numRangeReds.TabIndex = 26;
            this.numRangeReds.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(230, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "range";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "range";
            // 
            // numPosBlues
            // 
            this.numPosBlues.Location = new System.Drawing.Point(283, 205);
            this.numPosBlues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPosBlues.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPosBlues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPosBlues.Name = "numPosBlues";
            this.numPosBlues.Size = new System.Drawing.Size(105, 21);
            this.numPosBlues.TabIndex = 31;
            this.numPosBlues.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numPosReds
            // 
            this.numPosReds.Location = new System.Drawing.Point(63, 203);
            this.numPosReds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPosReds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPosReds.Name = "numPosReds";
            this.numPosReds.Size = new System.Drawing.Size(105, 21);
            this.numPosReds.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 12);
            this.label14.TabIndex = 29;
            this.label14.Text = "position";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "position";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 576);
            this.Controls.Add(this.numPosBlues);
            this.Controls.Add(this.numPosReds);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numRangeBlues);
            this.Controls.Add(this.numRangeReds);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numSpeedBlues);
            this.Controls.Add(this.numSpeedReds);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Combat sim";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumReds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPowerBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPowerReds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHpBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHpReds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedReds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeReds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosBlues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosReds)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numSpeedBlues;
        private System.Windows.Forms.NumericUpDown numSpeedReds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numRangeBlues;
        private System.Windows.Forms.NumericUpDown numRangeReds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numPosBlues;
        private System.Windows.Forms.NumericUpDown numPosReds;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

