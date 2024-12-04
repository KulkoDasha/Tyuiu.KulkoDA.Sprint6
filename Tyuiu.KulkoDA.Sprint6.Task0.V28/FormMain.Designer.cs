namespace Tyuiu.KulkoDA.Sprint6.Task0.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            GroupBoxuslovie_KDA = new GroupBox();
            textYslovie = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxResult_KDA = new TextBox();
            TextBoxVarX = new TextBox();
            groupBoxVvoddannyx_KDA = new GroupBox();
            textBoxX_KDA = new TextBox();
            groupBoxOutput_KDA = new GroupBox();
            textBoxRes_KDA = new TextBox();
            buttonDone_KDA = new Button();
            buttonHelp = new Button();
            GroupBoxuslovie_KDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxVvoddannyx_KDA.SuspendLayout();
            groupBoxOutput_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxuslovie_KDA
            // 
            GroupBoxuslovie_KDA.Controls.Add(textYslovie);
            GroupBoxuslovie_KDA.Controls.Add(pictureBox1);
            GroupBoxuslovie_KDA.Location = new Point(12, 12);
            GroupBoxuslovie_KDA.Name = "GroupBoxuslovie_KDA";
            GroupBoxuslovie_KDA.Size = new Size(474, 174);
            GroupBoxuslovie_KDA.TabIndex = 0;
            GroupBoxuslovie_KDA.TabStop = false;
            GroupBoxuslovie_KDA.Text = "Условие";
            GroupBoxuslovie_KDA.Enter += groupBox1_Enter;
            // 
            // textYslovie
            // 
            textYslovie.BackColor = SystemColors.MenuBar;
            textYslovie.BorderStyle = BorderStyle.None;
            textYslovie.Location = new Point(18, 27);
            textYslovie.Multiline = true;
            textYslovie.Name = "textYslovie";
            textYslovie.Size = new Size(134, 129);
            textYslovie.TabIndex = 1;
            textYslovie.Tag = "";
            textYslovie.Text = "Вычислить выражение по формуле";
            textYslovie.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 36);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxResult_KDA
            // 
            textBoxResult_KDA.Location = new Point(21, 57);
            textBoxResult_KDA.Name = "textBoxResult_KDA";
            textBoxResult_KDA.ReadOnly = true;
            textBoxResult_KDA.Size = new Size(100, 23);
            textBoxResult_KDA.TabIndex = 1;
            textBoxResult_KDA.KeyPress += TextBoxVarX_Keypress;
            // 
            // TextBoxVarX
            // 
            TextBoxVarX.Location = new Point(21, 57);
            TextBoxVarX.Name = "TextBoxVarX";
            TextBoxVarX.Size = new Size(100, 23);
            TextBoxVarX.TabIndex = 0;
            // 
            // groupBoxVvoddannyx_KDA
            // 
            groupBoxVvoddannyx_KDA.Controls.Add(textBoxX_KDA);
            groupBoxVvoddannyx_KDA.Controls.Add(TextBoxVarX);
            groupBoxVvoddannyx_KDA.Location = new Point(12, 192);
            groupBoxVvoddannyx_KDA.Name = "groupBoxVvoddannyx_KDA";
            groupBoxVvoddannyx_KDA.Size = new Size(312, 100);
            groupBoxVvoddannyx_KDA.TabIndex = 2;
            groupBoxVvoddannyx_KDA.TabStop = false;
            groupBoxVvoddannyx_KDA.Text = "Ввод данных";
            // 
            // textBoxX_KDA
            // 
            textBoxX_KDA.BackColor = SystemColors.Menu;
            textBoxX_KDA.BorderStyle = BorderStyle.None;
            textBoxX_KDA.Location = new Point(21, 35);
            textBoxX_KDA.Name = "textBoxX_KDA";
            textBoxX_KDA.Size = new Size(94, 16);
            textBoxX_KDA.TabIndex = 0;
            textBoxX_KDA.Text = "Переменная X:";
            // 
            // groupBoxOutput_KDA
            // 
            groupBoxOutput_KDA.Controls.Add(textBoxRes_KDA);
            groupBoxOutput_KDA.Controls.Add(textBoxResult_KDA);
            groupBoxOutput_KDA.Location = new Point(330, 192);
            groupBoxOutput_KDA.Name = "groupBoxOutput_KDA";
            groupBoxOutput_KDA.Size = new Size(156, 100);
            groupBoxOutput_KDA.TabIndex = 2;
            groupBoxOutput_KDA.TabStop = false;
            groupBoxOutput_KDA.Text = "Ввод данных";
            // 
            // textBoxRes_KDA
            // 
            textBoxRes_KDA.BackColor = SystemColors.Menu;
            textBoxRes_KDA.BorderStyle = BorderStyle.None;
            textBoxRes_KDA.Location = new Point(21, 35);
            textBoxRes_KDA.Name = "textBoxRes_KDA";
            textBoxRes_KDA.Size = new Size(94, 16);
            textBoxRes_KDA.TabIndex = 1;
            textBoxRes_KDA.Text = "Результат:";
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.Location = new Point(374, 301);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(112, 23);
            buttonDone_KDA.TabIndex = 3;
            buttonDone_KDA.Text = "Выполнить";
            buttonDone_KDA.UseVisualStyleBackColor = true;
            buttonDone_KDA.Click += buttonDone_KDA_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(330, 301);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(31, 23);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 336);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone_KDA);
            Controls.Add(groupBoxOutput_KDA);
            Controls.Add(GroupBoxuslovie_KDA);
            Controls.Add(groupBoxVvoddannyx_KDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 28 | Кулько.Д.А";
            Load += FormMain_Load;
            GroupBoxuslovie_KDA.ResumeLayout(false);
            GroupBoxuslovie_KDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxVvoddannyx_KDA.ResumeLayout(false);
            groupBoxVvoddannyx_KDA.PerformLayout();
            groupBoxOutput_KDA.ResumeLayout(false);
            groupBoxOutput_KDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxuslovie_KDA;
        private TextBox TextBoxVarX;
        private TextBox textBoxResult_KDA;
        private GroupBox groupBoxVvoddannyx_KDA;
        private GroupBox groupBoxOutput_KDA;
        private Button buttonDone_KDA;
        private Button buttonHelp;
        private TextBox textBoxX_KDA;
        private TextBox textBoxRes_KDA;
        private PictureBox pictureBox1;
        private TextBox textYslovie;
    }
}
