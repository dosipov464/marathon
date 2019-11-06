using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g284_l09_Khvashchevskii_PushkarevDataSet.PLANET' table. You can move, or remove it, as needed.
            this.pLANETTableAdapter.Fill(this.g284_l09_Khvashchevskii_PushkarevDataSet.PLANET);

        }

        private void pLANETBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pLANETBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.g284_l09_Khvashchevskii_PushkarevDataSet);

        }

        private void pLANETDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=127.0.0.1;Initial Catalog=g284_l09_Khvashchevskii_Pushkarev;User ID=student;Password=student"
            SqlConnection con = new SqlConnection(str);
            string sql = "SELECT" PlanetName, DistanceFromSun FROM pLANETBindingNavigator;";
            SqlCommand cmd = new SqlCommend(sql, con);
            SqlDsataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())

        }
    }
}
