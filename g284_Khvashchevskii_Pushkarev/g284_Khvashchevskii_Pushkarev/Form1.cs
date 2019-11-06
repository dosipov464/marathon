using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g284_Khvashchevskii_Pushkarev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g284_l009_Khvashchevskii_PushkarevDataSet.Planet' table. You can move, or remove it, as needed.
            this.planetTableAdapter.Fill(this.g284_l009_Khvashchevskii_PushkarevDataSet.Planet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = "Data Source=127.0.0.1;Initial Catalog=g284_l009_Khvashchevskii_Pushkarev;User ID=student;Password=student";

            SqlConnection con = new SqlConection(str); //Создание подключение к бд
            con.Open();

            string sql = "SELECET PlanetName, DistanceFromSun FROM Planet;";  //Выполнение запроса на выборку данных
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read());  //Чтение результата
            string name = rdr.GetString(0);
            double dist = rdr.GetDOUBLE(1);

            MessageBox.Show(name + "; " + dist.ToString());

        }
        rdr.Close();
        con.Close();
    }
            rdr.Close();
        con.Close();
}

