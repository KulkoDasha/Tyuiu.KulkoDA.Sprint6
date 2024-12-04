using Tyuiu.KulkoDA.Sprint6.Task1.V25.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task1.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBoxStartValue_KDA.Text);
                int z = Convert.ToInt32(textBoxEndValue_KDA.Text);
                string strline;
                int len = ds.GetMassFunction(a, z).Length;
                double[] mass;
                mass = new double[len];
                mass = ds.GetMassFunction(a, z);
                textResult_KDA.Text = "";
                textResult_KDA.AppendText("+----------+----------+"+Environment.NewLine);
                textResult_KDA.AppendText("|     X    |    f(x)  |" + Environment.NewLine);
                textResult_KDA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strline = String.Format("|{0,5:d}    |  {1,5:f2}  |", a, mass[i]);
                    textResult_KDA.AppendText(strline+Environment.NewLine);
                    a++;
                }
                textResult_KDA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("ошибка", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск1 выполнила студентка группы ИИПб-24-2 Кулько Дарья Андреевна");
        }
    }
}
