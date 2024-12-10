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
            double[] mass = new double[ds.len];
            mass =ds.LoadFromDataFile(path);
            for(int i=0; i<mass.Length; i++)
            {
                dataGridView_KDA.Rows.Add(Convert.ToString(i), Convert.ToString(mass[i]));
                chart_KDA.Series[0].Points.AddXY(i,mass[i]);
            }
        }

        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-24-2 Кулько Дарья Андреевна");
        }

        private void buttonOpen_KDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
