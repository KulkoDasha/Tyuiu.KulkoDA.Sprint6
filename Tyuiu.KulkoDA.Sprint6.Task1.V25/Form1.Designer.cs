namespace Tyuiu.KulkoDA.Sprint6.Task1.V25
{
    partial class Form1
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
            groupBoxYslovie_KDA = new GroupBox();
            pictureBox1 = new PictureBox();
            textYslovie_KDA = new TextBox();
            groupBoxDone_KDA = new GroupBox();
            groupBoxResult_KDA = new GroupBox();
            vScrollBar1 = new VScrollBar();
            textResult_KDA = new TextBox();
            groupBoxInput_KDA = new GroupBox();
            textEnd_KDA = new TextBox();
            textBox1 = new TextBox();
            textStart_KDA = new TextBox();
            textBoxEndValue_KDA = new TextBox();
            textBoxStartValue_KDA = new TextBox();
            buttonHelp_KDA = new Button();
            buttonDone_KDA = new Button();
            groupBoxYslovie_KDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxDone_KDA.SuspendLayout();
            groupBoxResult_KDA.SuspendLayout();
            groupBoxInput_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxYslovie_KDA
            // 
            groupBoxYslovie_KDA.Controls.Add(pictureBox1);
            groupBoxYslovie_KDA.Controls.Add(textYslovie_KDA);
            groupBoxYslovie_KDA.Location = new Point(15, 9);
            groupBoxYslovie_KDA.Name = "groupBoxYslovie_KDA";
            groupBoxYslovie_KDA.Size = new Size(432, 228);
            groupBoxYslovie_KDA.TabIndex = 0;
            groupBoxYslovie_KDA.TabStop = false;
            groupBoxYslovie_KDA.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Без_названия__1_;
            pictureBox1.Location = new Point(12, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 42);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textYslovie_KDA
            // 
            textYslovie_KDA.BackColor = SystemColors.MenuBar;
            textYslovie_KDA.BorderStyle = BorderStyle.None;
            textYslovie_KDA.Location = new Point(12, 28);
            textYslovie_KDA.Multiline = true;
            textYslovie_KDA.Name = "textYslovie_KDA";
            textYslovie_KDA.Size = new Size(402, 184);
            textYslovie_KDA.TabIndex = 0;
            textYslovie_KDA.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в таблицу.\r\n\r\n\r\n";
            // 
            // groupBoxDone_KDA
            // 
            groupBoxDone_KDA.Controls.Add(groupBoxResult_KDA);
            groupBoxDone_KDA.Location = new Point(453, 9);
            groupBoxDone_KDA.Name = "groupBoxDone_KDA";
            groupBoxDone_KDA.Size = new Size(179, 330);
            groupBoxDone_KDA.TabIndex = 1;
            groupBoxDone_KDA.TabStop = false;
            groupBoxDone_KDA.Text = "Вывод данных";
            // 
            // groupBoxResult_KDA
            // 
            groupBoxResult_KDA.Controls.Add(vScrollBar1);
            groupBoxResult_KDA.Controls.Add(textResult_KDA);
            groupBoxResult_KDA.Location = new Point(11, 22);
            groupBoxResult_KDA.Name = "groupBoxResult_KDA";
            groupBoxResult_KDA.Size = new Size(162, 305);
            groupBoxResult_KDA.TabIndex = 0;
            groupBoxResult_KDA.TabStop = false;
            groupBoxResult_KDA.Text = "Результат:";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(148, 22);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 277);
            vScrollBar1.TabIndex = 5;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // textResult_KDA
            // 
            textResult_KDA.Location = new Point(6, 22);
            textResult_KDA.Multiline = true;
            textResult_KDA.Name = "textResult_KDA";
            textResult_KDA.Size = new Size(139, 277);
            textResult_KDA.TabIndex = 0;
            // 
            // groupBoxInput_KDA
            // 
            groupBoxInput_KDA.Controls.Add(textEnd_KDA);
            groupBoxInput_KDA.Controls.Add(textBox1);
            groupBoxInput_KDA.Controls.Add(textStart_KDA);
            groupBoxInput_KDA.Controls.Add(textBoxEndValue_KDA);
            groupBoxInput_KDA.Controls.Add(textBoxStartValue_KDA);
            groupBoxInput_KDA.Location = new Point(15, 243);
            groupBoxInput_KDA.Name = "groupBoxInput_KDA";
            groupBoxInput_KDA.Size = new Size(248, 96);
            groupBoxInput_KDA.TabIndex = 2;
            groupBoxInput_KDA.TabStop = false;
            groupBoxInput_KDA.Text = "Ввод данных";
            // 
            // textEnd_KDA
            // 
            textEnd_KDA.BackColor = SystemColors.MenuBar;
            textEnd_KDA.BorderStyle = BorderStyle.None;
            textEnd_KDA.Location = new Point(138, 42);
            textEnd_KDA.Name = "textEnd_KDA";
            textEnd_KDA.Size = new Size(85, 16);
            textEnd_KDA.TabIndex = 3;
            textEnd_KDA.Text = "Конец шага:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(17, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 16);
            textBox1.TabIndex = 2;
            textBox1.Text = "Старт шага:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textStart_KDA
            // 
            textStart_KDA.BackColor = SystemColors.MenuBar;
            textStart_KDA.BorderStyle = BorderStyle.None;
            textStart_KDA.Location = new Point(17, 42);
            textStart_KDA.Name = "textStart_KDA";
            textStart_KDA.Size = new Size(85, 16);
            textStart_KDA.TabIndex = 0;
            // 
            // textBoxEndValue_KDA
            // 
            textBoxEndValue_KDA.Location = new Point(138, 64);
            textBoxEndValue_KDA.Name = "textBoxEndValue_KDA";
            textBoxEndValue_KDA.Size = new Size(92, 23);
            textBoxEndValue_KDA.TabIndex = 1;
            // 
            // textBoxStartValue_KDA
            // 
            textBoxStartValue_KDA.Location = new Point(17, 64);
            textBoxStartValue_KDA.Name = "textBoxStartValue_KDA";
            textBoxStartValue_KDA.Size = new Size(94, 23);
            textBoxStartValue_KDA.TabIndex = 0;
            // 
            // buttonHelp_KDA
            // 
            buttonHelp_KDA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_KDA.ForeColor = SystemColors.ControlText;
            buttonHelp_KDA.Location = new Point(269, 296);
            buttonHelp_KDA.Name = "buttonHelp_KDA";
            buttonHelp_KDA.Size = new Size(81, 43);
            buttonHelp_KDA.TabIndex = 3;
            buttonHelp_KDA.Text = "Справка";
            buttonHelp_KDA.UseVisualStyleBackColor = false;
            buttonHelp_KDA.Click += buttonHelp_KDA_Click;
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.BackColor = Color.LightCoral;
            buttonDone_KDA.Location = new Point(356, 296);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(91, 43);
            buttonDone_KDA.TabIndex = 4;
            buttonDone_KDA.Text = "Выполнить";
            buttonDone_KDA.UseVisualStyleBackColor = false;
            buttonDone_KDA.Click += buttonDone_KDA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 363);
            Controls.Add(buttonDone_KDA);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(groupBoxInput_KDA);
            Controls.Add(groupBoxDone_KDA);
            Controls.Add(groupBoxYslovie_KDA);
            Name = "Form1";
            Text = "Form1";
            groupBoxYslovie_KDA.ResumeLayout(false);
            groupBoxYslovie_KDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxDone_KDA.ResumeLayout(false);
            groupBoxResult_KDA.ResumeLayout(false);
            groupBoxResult_KDA.PerformLayout();
            groupBoxInput_KDA.ResumeLayout(false);
            groupBoxInput_KDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxYslovie_KDA;
        private GroupBox groupBoxDone_KDA;
        private GroupBox groupBoxInput_KDA;
        private Button buttonHelp_KDA;
        private Button buttonDone_KDA;
        private TextBox textBoxEndValue_KDA;
        private TextBox textBoxStartValue_KDA;
        private TextBox textBox1;
        private TextBox textStart_KDA;
        private TextBox textEnd_KDA;
        private TextBox textYslovie_KDA;
        private PictureBox pictureBox1;
        private GroupBox groupBoxResult_KDA;
        private VScrollBar vScrollBar1;
        private TextBox textResult_KDA;
    }
}
