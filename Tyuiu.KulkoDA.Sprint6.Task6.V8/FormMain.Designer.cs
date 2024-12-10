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
            groupBoxYsl_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxYsl_KDA
            // 
            groupBoxYsl_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxYsl_KDA.Controls.Add(textBoxYsl_KDA);
            groupBoxYsl_KDA.Location = new Point(12, 47);
            groupBoxYsl_KDA.Name = "groupBoxYsl_KDA";
            groupBoxYsl_KDA.Size = new Size(705, 100);
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
            textBoxYsl_KDA.Size = new Size(693, 61);
            textBoxYsl_KDA.TabIndex = 0;
            textBoxYsl_KDA.Text = resources.GetString("textBoxYsl_KDA.Text");
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KDA.Location = new Point(18, 18);
            buttonOpen_KDA.Name = "buttonOpen_KDA";
            buttonOpen_KDA.Size = new Size(75, 23);
            buttonOpen_KDA.TabIndex = 1;
            buttonOpen_KDA.Text = "button1";
            toolTip.SetToolTip(buttonOpen_KDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen_KDA.UseVisualStyleBackColor = true;
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.Location = new Point(112, 18);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(75, 23);
            buttonDone_KDA.TabIndex = 2;
            buttonDone_KDA.Text = "button2";
            toolTip.SetToolTip(buttonDone_KDA, "Производит поиск в файле символов \"z\" и конкатенирует строки в которых находятся эти символы\r\n");
            buttonDone_KDA.UseVisualStyleBackColor = true;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 394);
            Controls.Add(buttonDone_KDA);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(groupBoxYsl_KDA);
            Name = "FormMain";
            Text = "Form1";
            groupBoxYsl_KDA.ResumeLayout(false);
            groupBoxYsl_KDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxYsl_KDA;
        private TextBox textBoxYsl_KDA;
        private Button buttonOpen_KDA;
        private ToolTip toolTip;
        private Button buttonDone_KDA;
        private OpenFileDialog openFileDialog_KDA;
    }
}
