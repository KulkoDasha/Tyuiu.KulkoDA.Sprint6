namespace Tyuiu.KulkoDA.Sprint6.Task2.V2
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
            Textysl_KDA = new GroupBox();
            textBoxYSL_KDA = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            textBoxStart_KDA = new TextBox();
            textBoxEnd_KDA = new TextBox();
            groupBoxInput_KDA = new GroupBox();
            textBoxZ = new TextBox();
            textBoxA = new TextBox();
            buttonQ_KDA = new Button();
            buttonDone_KDA = new Button();
            Textysl_KDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxInput_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // Textysl_KDA
            // 
            Textysl_KDA.Controls.Add(textBoxYSL_KDA);
            Textysl_KDA.Location = new Point(12, 12);
            Textysl_KDA.Name = "Textysl_KDA";
            Textysl_KDA.Size = new Size(455, 204);
            Textysl_KDA.TabIndex = 0;
            Textysl_KDA.TabStop = false;
            Textysl_KDA.Text = "Условие";
            // 
            // textBoxYSL_KDA
            // 
            textBoxYSL_KDA.BackColor = SystemColors.MenuBar;
            textBoxYSL_KDA.Location = new Point(3, 19);
            textBoxYSL_KDA.Multiline = true;
            textBoxYSL_KDA.Name = "textBoxYSL_KDA";
            textBoxYSL_KDA.Size = new Size(436, 155);
            textBoxYSL_KDA.TabIndex = 0;
            textBoxYSL_KDA.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в DataGridView.\r\n\r\n.  ";
            textBoxYSL_KDA.TextChanged += this.textBoxYSL_KDA_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(473, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(121, 288);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // textBoxStart_KDA
            // 
            textBoxStart_KDA.Location = new Point(28, 270);
            textBoxStart_KDA.Name = "textBoxStart_KDA";
            textBoxStart_KDA.Size = new Size(109, 23);
            textBoxStart_KDA.TabIndex = 1;
            // 
            // textBoxEnd_KDA
            // 
            textBoxEnd_KDA.Location = new Point(155, 270);
            textBoxEnd_KDA.Name = "textBoxEnd_KDA";
            textBoxEnd_KDA.Size = new Size(109, 23);
            textBoxEnd_KDA.TabIndex = 2;
            // 
            // groupBoxInput_KDA
            // 
            groupBoxInput_KDA.Controls.Add(textBoxZ);
            groupBoxInput_KDA.Controls.Add(textBoxA);
            groupBoxInput_KDA.Location = new Point(12, 222);
            groupBoxInput_KDA.Name = "groupBoxInput_KDA";
            groupBoxInput_KDA.Size = new Size(273, 87);
            groupBoxInput_KDA.TabIndex = 3;
            groupBoxInput_KDA.TabStop = false;
            groupBoxInput_KDA.Text = "Ввод данных";
            // 
            // textBoxZ
            // 
            textBoxZ.BackColor = SystemColors.MenuBar;
            textBoxZ.BorderStyle = BorderStyle.None;
            textBoxZ.Location = new Point(143, 19);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(109, 16);
            textBoxZ.TabIndex = 1;
            textBoxZ.Text = "Конец шага:";
            // 
            // textBoxA
            // 
            textBoxA.BackColor = SystemColors.MenuBar;
            textBoxA.BorderStyle = BorderStyle.None;
            textBoxA.Location = new Point(16, 19);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(109, 16);
            textBoxA.TabIndex = 0;
            textBoxA.Text = "Старт шага:";
            // 
            // buttonQ_KDA
            // 
            buttonQ_KDA.BackColor = Color.FromArgb(255, 192, 192);
            buttonQ_KDA.Location = new Point(293, 263);
            buttonQ_KDA.Name = "buttonQ_KDA";
            buttonQ_KDA.Size = new Size(66, 43);
            buttonQ_KDA.TabIndex = 4;
            buttonQ_KDA.Text = "Справка";
            buttonQ_KDA.UseVisualStyleBackColor = false;
            buttonQ_KDA.Click += button_KDA_Click;
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.BackColor = SystemColors.ActiveCaption;
            buttonDone_KDA.Location = new Point(376, 263);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(91, 43);
            buttonDone_KDA.TabIndex = 5;
            buttonDone_KDA.Text = "Выполнить";
            buttonDone_KDA.UseVisualStyleBackColor = false;
            buttonDone_KDA.Click += buttonDone_KDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 337);
            Controls.Add(buttonDone_KDA);
            Controls.Add(buttonQ_KDA);
            Controls.Add(textBoxEnd_KDA);
            Controls.Add(textBoxStart_KDA);
            Controls.Add(dataGridView1);
            Controls.Add(Textysl_KDA);
            Controls.Add(groupBoxInput_KDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 2 | Кулько.Д.А";
            Textysl_KDA.ResumeLayout(false);
            Textysl_KDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxInput_KDA.ResumeLayout(false);
            groupBoxInput_KDA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Textysl_KDA;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox textBoxYSL_KDA;
        private TextBox textBoxStart_KDA;
        private TextBox textBoxEnd_KDA;
        private GroupBox groupBoxInput_KDA;
        private TextBox textBoxZ;
        private TextBox textBoxA;
        private Button buttonQ_KDA;
        private Button buttonDone_KDA;
    }
}
