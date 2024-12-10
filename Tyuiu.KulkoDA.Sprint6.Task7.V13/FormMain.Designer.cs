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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpen_KDA = new Button();
            buttonDone_KDA = new Button();
            buttonHelp_KDA = new Button();
            groupBoxYsl_KDA = new GroupBox();
            textBoxYsl_KDA = new TextBox();
            groupBoxYsl_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KDA.Image = (Image)resources.GetObject("buttonOpen_KDA.Image");
            buttonOpen_KDA.Location = new Point(35, 12);
            buttonOpen_KDA.Name = "buttonOpen_KDA";
            buttonOpen_KDA.Size = new Size(58, 45);
            buttonOpen_KDA.TabIndex = 2;
            buttonOpen_KDA.UseVisualStyleBackColor = true;
            // 
            // buttonDone_KDA
            // 
            buttonDone_KDA.Enabled = false;
            buttonDone_KDA.Image = (Image)resources.GetObject("buttonDone_KDA.Image");
            buttonDone_KDA.Location = new Point(115, 12);
            buttonDone_KDA.Name = "buttonDone_KDA";
            buttonDone_KDA.Size = new Size(58, 45);
            buttonDone_KDA.TabIndex = 3;
            buttonDone_KDA.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_KDA
            // 
            buttonHelp_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDA.Image = (Image)resources.GetObject("buttonHelp_KDA.Image");
            buttonHelp_KDA.Location = new Point(710, 12);
            buttonHelp_KDA.Name = "buttonHelp_KDA";
            buttonHelp_KDA.Size = new Size(58, 45);
            buttonHelp_KDA.TabIndex = 4;
            buttonHelp_KDA.UseVisualStyleBackColor = true;
            // 
            // groupBoxYsl_KDA
            // 
            groupBoxYsl_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxYsl_KDA.Controls.Add(textBoxYsl_KDA);
            groupBoxYsl_KDA.Location = new Point(35, 63);
            groupBoxYsl_KDA.Name = "groupBoxYsl_KDA";
            groupBoxYsl_KDA.Size = new Size(753, 84);
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
            textBoxYsl_KDA.Size = new Size(741, 56);
            textBoxYsl_KDA.TabIndex = 0;
            textBoxYsl_KDA.Text = resources.GetString("textBoxYsl_KDA.Text");
            textBoxYsl_KDA.TextChanged += this.textBoxYsl_KDA_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxYsl_KDA);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(buttonDone_KDA);
            Controls.Add(buttonOpen_KDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 13 | Кулько.Д.А";
            groupBoxYsl_KDA.ResumeLayout(false);
            groupBoxYsl_KDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen_KDA;
        private Button buttonDone_KDA;
        private Button buttonHelp_KDA;
        private GroupBox groupBoxYsl_KDA;
        private TextBox textBoxYsl_KDA;
    }
}
