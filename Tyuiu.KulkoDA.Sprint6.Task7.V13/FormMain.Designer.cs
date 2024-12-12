namespace Tyuiu.KulkoDA.Sprint6.Task7.V13
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
            buttonOpen_KDA = new Button();
            buttonDone_KDA = new Button();
            buttonHelp_KDA = new Button();
            groupBoxYsl_KDA = new GroupBox();
            textBoxYsl_KDA = new TextBox();
            groupBoxIn_KDA = new GroupBox();
            dataGridViewIn_KDA = new DataGridView();
            groupBoxOut_KDA = new GroupBox();
            dataGridViewOut_KDA = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            buttonSave_KDA = new Button();
            saveFileDialog1 = new SaveFileDialog();
            groupBoxYsl_KDA.SuspendLayout();
            groupBoxIn_KDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KDA).BeginInit();
            groupBoxOut_KDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KDA).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KDA.Image = (Image)resources.GetObject("buttonOpen_KDA.Image");
            buttonOpen_KDA.Location = new Point(18, 12);
            buttonOpen_KDA.Name = "buttonOpen_KDA";
            buttonOpen_KDA.Size = new Size(58, 45);
            buttonOpen_KDA.TabIndex = 2;
            toolTip1.SetToolTip(buttonOpen_KDA, "Открыть файл\r\nВыберите нужный файл для обработки в формате csv\r\n\r\n");
            buttonOpen_KDA.UseVisualStyleBackColor = true;
            buttonOpen_KDA.Click += buttonOpen_KDA_Click;
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.Enabled = false;
            buttonDone_KDA.Image = (Image)resources.GetObject("buttonDone_KDA.Image");
            buttonDone_KDA.Location = new Point(91, 12);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(58, 45);
            buttonDone_KDA.TabIndex = 3;
            toolTip1.SetToolTip(buttonDone_KDA, "Выполнить обработку данных");
            buttonDone_KDA.UseVisualStyleBackColor = true;
            buttonDone_KDA.Click += buttonDone_KDA_Click;
            // 
            // buttonHelp_KDA
            // 
            buttonHelp_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDA.Image = (Image)resources.GetObject("buttonHelp_KDA.Image");
            buttonHelp_KDA.Location = new Point(710, 12);
            buttonHelp_KDA.Name = "buttonHelp_KDA";
            buttonHelp_KDA.Size = new Size(58, 45);
            buttonHelp_KDA.TabIndex = 4;
            toolTip1.SetToolTip(buttonHelp_KDA, "Сведения о программе");
            buttonHelp_KDA.UseVisualStyleBackColor = true;
            buttonHelp_KDA.Click += buttonHelp_KDA_Click;
            // 
            // groupBoxYsl_KDA
            // 
            groupBoxYsl_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxYsl_KDA.Controls.Add(textBoxYsl_KDA);
            groupBoxYsl_KDA.Location = new Point(12, 63);
            groupBoxYsl_KDA.Name = "groupBoxYsl_KDA";
            groupBoxYsl_KDA.Size = new Size(776, 84);
            groupBoxYsl_KDA.TabIndex = 5;
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
            textBoxYsl_KDA.Size = new Size(764, 56);
            textBoxYsl_KDA.TabIndex = 0;
            textBoxYsl_KDA.Text = resources.GetString("textBoxYsl_KDA.Text");
            // 
            // groupBoxIn_KDA
            // 
            groupBoxIn_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxIn_KDA.Controls.Add(dataGridViewIn_KDA);
            groupBoxIn_KDA.Location = new Point(12, 153);
            groupBoxIn_KDA.Name = "groupBoxIn_KDA";
            groupBoxIn_KDA.Size = new Size(386, 285);
            groupBoxIn_KDA.TabIndex = 6;
            groupBoxIn_KDA.TabStop = false;
            groupBoxIn_KDA.Text = "Ввод:";
            // 
            // dataGridViewIn_KDA
            // 
            dataGridViewIn_KDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KDA.ColumnHeadersVisible = false;
            dataGridViewIn_KDA.Location = new Point(6, 22);
            dataGridViewIn_KDA.Name = "dataGridViewIn_KDA";
            dataGridViewIn_KDA.RowHeadersVisible = false;
            dataGridViewIn_KDA.Size = new Size(374, 257);
            dataGridViewIn_KDA.TabIndex = 0;
            // 
            // groupBoxOut_KDA
            // 
            groupBoxOut_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxOut_KDA.Controls.Add(dataGridViewOut_KDA);
            groupBoxOut_KDA.Location = new Point(404, 153);
            groupBoxOut_KDA.Name = "groupBoxOut_KDA";
            groupBoxOut_KDA.Size = new Size(384, 285);
            groupBoxOut_KDA.TabIndex = 7;
            groupBoxOut_KDA.TabStop = false;
            groupBoxOut_KDA.Text = "Вывод:";
            // 
            // dataGridViewOut_KDA
            // 
            dataGridViewOut_KDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KDA.ColumnHeadersVisible = false;
            dataGridViewOut_KDA.Location = new Point(6, 22);
            dataGridViewOut_KDA.Name = "dataGridViewOut_KDA";
            dataGridViewOut_KDA.RowHeadersVisible = false;
            dataGridViewOut_KDA.Size = new Size(372, 257);
            dataGridViewOut_KDA.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // buttonSave_KDA
            // 
            buttonSave_KDA.Enabled = false;
            buttonSave_KDA.Image = (Image)resources.GetObject("buttonSave_KDA.Image");
            buttonSave_KDA.Location = new Point(164, 12);
            buttonSave_KDA.Name = "buttonSave_KDA";
            buttonSave_KDA.Size = new Size(58, 45);
            buttonSave_KDA.TabIndex = 8;
            toolTip1.SetToolTip(buttonSave_KDA, "Сохранить обработанные данные в файл формата csv\r\n");
            buttonSave_KDA.UseVisualStyleBackColor = true;
            buttonSave_KDA.Click += buttonSave_KDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave_KDA);
            Controls.Add(groupBoxOut_KDA);
            Controls.Add(groupBoxIn_KDA);
            Controls.Add(groupBoxYsl_KDA);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(buttonDone_KDA);
            Controls.Add(buttonOpen_KDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 13 | Кулько.Д.А";
            groupBoxYsl_KDA.ResumeLayout(false);
            groupBoxYsl_KDA.PerformLayout();
            groupBoxIn_KDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KDA).EndInit();
            groupBoxOut_KDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen_KDA;
        private Button buttonDone_KDA;
        private Button buttonHelp_KDA;
        private GroupBox groupBoxYsl_KDA;
        private TextBox textBoxYsl_KDA;
        private GroupBox groupBoxIn_KDA;
        private DataGridView dataGridViewIn_KDA;
        private GroupBox groupBoxOut_KDA;
        private DataGridView dataGridViewOut_KDA;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private Button buttonSave_KDA;
        private SaveFileDialog saveFileDialog1;
    }
}
