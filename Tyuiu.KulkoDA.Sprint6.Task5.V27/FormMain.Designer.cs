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
            groupBoxYsl_KDA = new GroupBox();
            groupBoxOutPut_KDA = new GroupBox();
            textBoxDone_KDA = new TextBox();
            buttonDone_KDA = new Button();
            buttonOpen_KDA = new Button();
            buttonHelp_KDA = new Button();
            groupBoxOutPut_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxYsl_KDA
            // 
            groupBoxYsl_KDA.Location = new Point(3, 12);
            groupBoxYsl_KDA.Name = "groupBoxYsl_KDA";
            groupBoxYsl_KDA.Size = new Size(418, 82);
            groupBoxYsl_KDA.TabIndex = 0;
            groupBoxYsl_KDA.TabStop = false;
            groupBoxYsl_KDA.Text = "Условие:";
            // 
            // groupBoxOutPut_KDA
            // 
            groupBoxOutPut_KDA.Controls.Add(textBoxDone_KDA);
            groupBoxOutPut_KDA.Location = new Point(3, 100);
            groupBoxOutPut_KDA.Name = "groupBoxOutPut_KDA";
            groupBoxOutPut_KDA.Size = new Size(159, 347);
            groupBoxOutPut_KDA.TabIndex = 0;
            groupBoxOutPut_KDA.TabStop = false;
            groupBoxOutPut_KDA.Text = "Вывод данных:";
            // 
            // textBoxDone_KDA
            // 
            textBoxDone_KDA.BackColor = SystemColors.GrayText;
            textBoxDone_KDA.BorderStyle = BorderStyle.FixedSingle;
            textBoxDone_KDA.Location = new Point(3, 19);
            textBoxDone_KDA.Multiline = true;
            textBoxDone_KDA.Name = "textBoxDone_KDA";
            textBoxDone_KDA.Size = new Size(150, 322);
            textBoxDone_KDA.TabIndex = 0;
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
            buttonHelp_KDA.Click += this.buttonHelp_KDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(buttonDone_KDA);
            Controls.Add(groupBoxOutPut_KDA);
            Controls.Add(groupBoxYsl_KDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 27 | Кулько.Д.А";
            groupBoxOutPut_KDA.ResumeLayout(false);
            groupBoxOutPut_KDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxYsl_KDA;
        private GroupBox groupBoxOutPut_KDA;
        private TextBox textBoxDone_KDA;
        private Button buttonDone_KDA;
        private Button buttonOpen_KDA;
        private Button buttonHelp_KDA;
    }
}
