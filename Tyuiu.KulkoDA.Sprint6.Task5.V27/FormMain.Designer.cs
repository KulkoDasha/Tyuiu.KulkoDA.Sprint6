namespace Tyuiu.KulkoDA.Sprint6.Task5.V27
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
            groupBoxYsl_KDA = new GroupBox();
            textBoxYsl_KDA = new TextBox();
            groupBoxOutPut_KDA = new GroupBox();
            dataGridView_KDA = new DataGridView();
            buttonDone_KDA = new Button();
            buttonOpen_KDA = new Button();
            buttonHelp_KDA = new Button();
            chart_KDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxYsl_KDA.SuspendLayout();
            groupBoxOutPut_KDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_KDA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxYsl_KDA
            // 
            groupBoxYsl_KDA.Controls.Add(textBoxYsl_KDA);
            groupBoxYsl_KDA.Location = new Point(3, 12);
            groupBoxYsl_KDA.Name = "groupBoxYsl_KDA";
            groupBoxYsl_KDA.Size = new Size(418, 82);
            groupBoxYsl_KDA.TabIndex = 0;
            groupBoxYsl_KDA.TabStop = false;
            groupBoxYsl_KDA.Text = "Условие:";
            // 
            // textBoxYsl_KDA
            // 
            textBoxYsl_KDA.BackColor = SystemColors.MenuBar;
            textBoxYsl_KDA.BorderStyle = BorderStyle.None;
            textBoxYsl_KDA.Location = new Point(6, 22);
            textBoxYsl_KDA.Multiline = true;
            textBoxYsl_KDA.Name = "textBoxYsl_KDA";
            textBoxYsl_KDA.Size = new Size(406, 54);
            textBoxYsl_KDA.TabIndex = 4;
            textBoxYsl_KDA.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView. Вывести все числа не кратные 5. Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutPut_KDA
            // 
            groupBoxOutPut_KDA.Controls.Add(dataGridView_KDA);
            groupBoxOutPut_KDA.Location = new Point(3, 100);
            groupBoxOutPut_KDA.Name = "groupBoxOutPut_KDA";
            groupBoxOutPut_KDA.Size = new Size(159, 347);
            groupBoxOutPut_KDA.TabIndex = 0;
            groupBoxOutPut_KDA.TabStop = false;
            groupBoxOutPut_KDA.Text = "Вывод данных:";
            // 
            // dataGridView_KDA
            // 
            dataGridView_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView_KDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_KDA.Location = new Point(3, 19);
            dataGridView_KDA.Name = "dataGridView_KDA";
            dataGridView_KDA.Size = new Size(150, 322);
            dataGridView_KDA.TabIndex = 0;
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.BackColor = Color.LightCoral;
            buttonDone_KDA.Location = new Point(462, 36);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(86, 49);
            buttonDone_KDA.TabIndex = 1;
            buttonDone_KDA.Text = "Выполнить";
            buttonDone_KDA.UseVisualStyleBackColor = false;
            buttonDone_KDA.Click += buttonDone_KDA_Click;
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KDA.BackColor = Color.YellowGreen;
            buttonOpen_KDA.Location = new Point(568, 36);
            buttonOpen_KDA.Name = "buttonOpen_KDA";
            buttonOpen_KDA.Size = new Size(86, 49);
            buttonOpen_KDA.TabIndex = 2;
            buttonOpen_KDA.Text = "Открыть файл";
            buttonOpen_KDA.UseVisualStyleBackColor = false;
            buttonOpen_KDA.Click += buttonOpen_KDA_Click;
            // 
            // buttonHelp_KDA
            // 
            buttonHelp_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDA.BackColor = Color.PeachPuff;
            buttonHelp_KDA.Location = new Point(674, 36);
            buttonHelp_KDA.Name = "buttonHelp_KDA";
            buttonHelp_KDA.Size = new Size(86, 49);
            buttonHelp_KDA.TabIndex = 3;
            buttonHelp_KDA.Text = "Справка";
            buttonHelp_KDA.UseVisualStyleBackColor = false;
            buttonHelp_KDA.Click += buttonHelp_KDA_Click;
            // 
            // chart_KDA
            // 
            chart_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart_KDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_KDA.Legends.Add(legend1);
            chart_KDA.Location = new Point(168, 100);
            chart_KDA.Name = "chart_KDA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_KDA.Series.Add(series1);
            chart_KDA.Size = new Size(620, 347);
            chart_KDA.TabIndex = 4;
            chart_KDA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart_KDA);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(buttonDone_KDA);
            Controls.Add(groupBoxOutPut_KDA);
            Controls.Add(groupBoxYsl_KDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 27 | Кулько.Д.А";
            groupBoxYsl_KDA.ResumeLayout(false);
            groupBoxYsl_KDA.PerformLayout();
            groupBoxOutPut_KDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_KDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_KDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxYsl_KDA;
        private GroupBox groupBoxOutPut_KDA;
        private Button buttonDone_KDA;
        private Button buttonOpen_KDA;
        private Button buttonHelp_KDA;
        private TextBox textBoxYsl_KDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KDA;
        private DataGridView dataGridView_KDA;
    }
}
