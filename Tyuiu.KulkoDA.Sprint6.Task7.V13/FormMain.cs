using Tyuiu.KulkoDA.Sprint6.Task7.V13.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;
        public static int[,] LoadFromData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n','\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] result = new int[rows, columns];
            for(int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for(int j = 0; j < columns; j++)
                {
                    result[i,j] = Convert.ToInt32(line_r[j]);
                }
            } 
            return result;
        }

        private void buttonOpen_KDA_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues =LoadFromData(openFilePath);
            dataGridViewIn_KDA.ColumnCount = columns;
            dataGridViewIn_KDA.RowCount = rows;
            dataGridViewOut_KDA.ColumnCount = columns;
            dataGridViewOut_KDA.RowCount = rows;
            for(int i = 0; i < columns; i++)
            {
                dataGridViewIn_KDA.Width = 25;
                dataGridViewOut_KDA.Width = 25;
            }
            for(int i = 0;i < rows; i++)
            {
                for(int j = 0; j < columns;j++)
                {
                    dataGridViewIn_KDA.Rows[i].Cells[j].Value = arrayValues[i,j];
                }
            }
            arrayValues =ds.GetMatrix(openFilePath);
            buttonDone_KDA.Enabled = true;
        }

        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        
    }
}
