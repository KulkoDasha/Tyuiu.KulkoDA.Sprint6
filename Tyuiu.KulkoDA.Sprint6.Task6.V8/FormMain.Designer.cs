namespace Tyuiu.KulkoDA.Sprint6.Task6.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxYsl_KDA = new GroupBox();
            textBoxYsl_KDA = new TextBox();
            buttonOpen_KDA = new Button();
            buttonDone_KDA = new Button();
            openFileDialog_KDA = new OpenFileDialog();
            toolTip = new ToolTip(components);
            buttonHelp_KDA = new Button();
            groupBoxInput_KDA = new GroupBox();
            groupBoxOutput_KDA = new GroupBox();
            textBoxIn_KDA = new TextBox();
            textBoxOut_KDA = new TextBox();
            groupBoxYsl_KDA.SuspendLayout();
            groupBoxInput_KDA.SuspendLayout();
            groupBoxOutput_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxYsl_KDA
            // 
            groupBoxYsl_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxYsl_KDA.Controls.Add(textBoxYsl_KDA);
            groupBoxYsl_KDA.Location = new Point(12, 58);
            groupBoxYsl_KDA.Name = "groupBoxYsl_KDA";
            groupBoxYsl_KDA.Size = new Size(705, 72);
            groupBoxYsl_KDA.TabIndex = 0;
            groupBoxYsl_KDA.TabStop = false;
            groupBoxYsl_KDA.Text = "Условие";
            // 
            // textBoxYsl_KDA
            // 
            textBoxYsl_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxYsl_KDA.BackColor = SystemColors.MenuBar;
            textBoxYsl_KDA.BorderStyle = BorderStyle.None;
            textBoxYsl_KDA.Location = new Point(6, 22);
            textBoxYsl_KDA.Multiline = true;
            textBoxYsl_KDA.Name = "textBoxYsl_KDA";
            textBoxYsl_KDA.Size = new Size(693, 43);
            textBoxYsl_KDA.TabIndex = 0;
            textBoxYsl_KDA.Text = resources.GetString("textBoxYsl_KDA.Text");
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KDA.Image = (Image)resources.GetObject("buttonOpen_KDA.Image");
            buttonOpen_KDA.Location = new Point(18, 7);
            buttonOpen_KDA.Name = "buttonOpen_KDA";
            buttonOpen_KDA.Size = new Size(58, 45);
            buttonOpen_KDA.TabIndex = 1;
            toolTip.SetToolTip(buttonOpen_KDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen_KDA.UseVisualStyleBackColor = true;
            buttonOpen_KDA.Click += buttonOpen_KDA_Click;
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.Image = (Image)resources.GetObject("buttonDone_KDA.Image");
            buttonDone_KDA.Location = new Point(96, 7);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(58, 45);
            buttonDone_KDA.TabIndex = 2;
            toolTip.SetToolTip(buttonDone_KDA, "Производит поиск в файле символов \"z\" и конкатенирует строки в которых находятся эти символы\r\n");
            buttonDone_KDA.UseVisualStyleBackColor = true;
            buttonDone_KDA.Click += buttonDone_KDA_Click;
            // 
            // openFileDialog_KDA
            // 
            openFileDialog_KDA.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_KDA
            // 
            buttonHelp_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDA.Image = (Image)resources.GetObject("buttonHelp_KDA.Image");
            buttonHelp_KDA.Location = new Point(653, 12);
            buttonHelp_KDA.Name = "buttonHelp_KDA";
            buttonHelp_KDA.Size = new Size(58, 45);
            buttonHelp_KDA.TabIndex = 3;
            buttonHelp_KDA.UseVisualStyleBackColor = true;
            buttonHelp_KDA.Click += buttonHelp_KDA_Click;
            // 
            // groupBoxInput_KDA
            // 
            groupBoxInput_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput_KDA.Controls.Add(textBoxIn_KDA);
            groupBoxInput_KDA.Location = new Point(12, 136);
            groupBoxInput_KDA.Name = "groupBoxInput_KDA";
            groupBoxInput_KDA.Size = new Size(336, 246);
            groupBoxInput_KDA.TabIndex = 4;
            groupBoxInput_KDA.TabStop = false;
            groupBoxInput_KDA.Text = "Ввод";
            // 
            // groupBoxOutput_KDA
            // 
            groupBoxOutput_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxOutput_KDA.Controls.Add(textBoxOut_KDA);
            groupBoxOutput_KDA.Location = new Point(381, 136);
            groupBoxOutput_KDA.Name = "groupBoxOutput_KDA";
            groupBoxOutput_KDA.Size = new Size(336, 246);
            groupBoxOutput_KDA.TabIndex = 5;
            groupBoxOutput_KDA.TabStop = false;
            groupBoxOutput_KDA.Text = "Вывод";
            // 
            // textBoxIn_KDA
            // 
            textBoxIn_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIn_KDA.BackColor = SystemColors.ControlLightLight;
            textBoxIn_KDA.BorderStyle = BorderStyle.FixedSingle;
            textBoxIn_KDA.Location = new Point(6, 19);
            textBoxIn_KDA.Multiline = true;
            textBoxIn_KDA.Name = "textBoxIn_KDA";
            textBoxIn_KDA.ReadOnly = true;
            textBoxIn_KDA.Size = new Size(324, 221);
            textBoxIn_KDA.TabIndex = 0;
            // 
            // textBoxOut_KDA
            // 
            textBoxOut_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxOut_KDA.BackColor = SystemColors.ControlLightLight;
            textBoxOut_KDA.BorderStyle = BorderStyle.FixedSingle;
            textBoxOut_KDA.Location = new Point(6, 19);
            textBoxOut_KDA.Multiline = true;
            textBoxOut_KDA.Name = "textBoxOut_KDA";
            textBoxOut_KDA.ReadOnly = true;
            textBoxOut_KDA.Size = new Size(327, 221);
            textBoxOut_KDA.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 394);
            Controls.Add(groupBoxOutput_KDA);
            Controls.Add(groupBoxInput_KDA);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(buttonDone_KDA);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(groupBoxYsl_KDA);
            Name = "FormMain";
            Text = "Form1";
            groupBoxYsl_KDA.ResumeLayout(false);
            groupBoxYsl_KDA.PerformLayout();
            groupBoxInput_KDA.ResumeLayout(false);
            groupBoxInput_KDA.PerformLayout();
            groupBoxOutput_KDA.ResumeLayout(false);
            groupBoxOutput_KDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxYsl_KDA;
        private TextBox textBoxYsl_KDA;
        private Button buttonOpen_KDA;
        private ToolTip toolTip;
        private Button buttonDone_KDA;
        private OpenFileDialog openFileDialog_KDA;
        private Button buttonHelp_KDA;
        private GroupBox groupBoxInput_KDA;
        private TextBox textBoxIn_KDA;
        private GroupBox groupBoxOutput_KDA;
        private TextBox textBoxOut_KDA;
    }
}
