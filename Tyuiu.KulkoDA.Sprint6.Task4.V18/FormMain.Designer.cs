namespace Tyuiu.KulkoDA.Sprint6.Task4.V18
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxDone = new TextBox();
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            groupBoxInput = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(231, 90);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(612, 395);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // textBoxDone
            // 
            textBoxDone.Location = new Point(12, 90);
            textBoxDone.Multiline = true;
            textBoxDone.Name = "textBoxDone";
            textBoxDone.Size = new Size(201, 395);
            textBoxDone.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(26, 44);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(142, 44);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(100, 23);
            textBoxEnd.TabIndex = 3;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(192, 192, 255);
            buttonDone.Location = new Point(583, 26);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(78, 58);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(255, 192, 192);
            buttonSave.Location = new Point(667, 26);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(78, 58);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(255, 224, 192);
            buttonHelp.Location = new Point(751, 26);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(78, 58);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBox2);
            groupBoxInput.Controls.Add(textBox1);
            groupBoxInput.Controls.Add(textBoxEnd);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Location = new Point(320, 11);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(257, 73);
            groupBoxInput.TabIndex = 7;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(142, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 9;
            textBox2.Text = "Конец";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(26, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 8;
            textBox1.Text = "Начало";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 497);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(textBoxDone);
            Controls.Add(chart1);
            Controls.Add(groupBoxInput);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox textBoxDone;
        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonHelp;
        private GroupBox groupBoxInput;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
