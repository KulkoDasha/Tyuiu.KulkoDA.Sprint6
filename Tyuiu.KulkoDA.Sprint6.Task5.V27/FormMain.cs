using Tyuiu.KulkoDA.Sprint6.Task5.V27.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutFileTask5V27.txt";
        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {
            dataGridView_KDA.ColumnCount = 2;
            dataGridView_KDA.Columns[0].Width = 20;
            dataGridView_KDA.Columns[1].Width = 50;
            chart_KDA.Series[0].Points.Clear();
        }

        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-24-2 Кулько Дарья Андреевна");
        }

        private void buttonOpen_KDA_Click(object sender, EventArgs e)
        {

        }
    }
}
