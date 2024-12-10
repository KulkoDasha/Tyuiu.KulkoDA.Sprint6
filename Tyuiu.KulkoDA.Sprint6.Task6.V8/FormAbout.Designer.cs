namespace Tyuiu.KulkoDA.Sprint6.Task6.V8
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_KDA = new PictureBox();
            textBoxabout_KDA = new TextBox();
            buttonAbout_KDA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KDA
            // 
            pictureBoxAvatar_KDA.Image = (Image)resources.GetObject("pictureBoxAvatar_KDA.Image");
            pictureBoxAvatar_KDA.InitialImage = null;
            pictureBoxAvatar_KDA.Location = new Point(12, 8);
            pictureBoxAvatar_KDA.Name = "pictureBoxAvatar_KDA";
            pictureBoxAvatar_KDA.Size = new Size(116, 148);
            pictureBoxAvatar_KDA.TabIndex = 0;
            pictureBoxAvatar_KDA.TabStop = false;
            // 
            // textBoxabout_KDA
            // 
            textBoxabout_KDA.BackColor = SystemColors.MenuBar;
            textBoxabout_KDA.BorderStyle = BorderStyle.None;
            textBoxabout_KDA.Location = new Point(134, 12);
            textBoxabout_KDA.Multiline = true;
            textBoxabout_KDA.Name = "textBoxabout_KDA";
            textBoxabout_KDA.ReadOnly = true;
            textBoxabout_KDA.Size = new Size(241, 114);
            textBoxabout_KDA.TabIndex = 1;
            textBoxabout_KDA.Text = "Разработчик: Кулько.Д.А\r\nгруппа ИИПб-24-2\r\n\r\nТюменский индустриальный университет 2024\r\nВысшая школа цифровых технологий 2024\r\n\r\n";
            // 
            // buttonAbout_KDA
            // 
            buttonAbout_KDA.Location = new Point(318, 133);
            buttonAbout_KDA.Name = "buttonAbout_KDA";
            buttonAbout_KDA.Size = new Size(75, 23);
            buttonAbout_KDA.TabIndex = 2;
            buttonAbout_KDA.Text = "Ок";
            buttonAbout_KDA.UseVisualStyleBackColor = true;
            buttonAbout_KDA.Click += buttonAbout_KDA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 168);
            Controls.Add(buttonAbout_KDA);
            Controls.Add(textBoxabout_KDA);
            Controls.Add(pictureBoxAvatar_KDA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_KDA;
        private TextBox textBoxabout_KDA;
        private Button buttonAbout_KDA;
    }
}