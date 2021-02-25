using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridgeDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FridgeDB.Properties.Settings.FridgeConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFridgeTable();
        }

        private void PopulateFridgeTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FoodType", connection))
            {
                DataTable foodTable = new DataTable();
                adapter.Fill(foodTable);

                listFood.DisplayMember = "TypeName";
                listFood.ValueMember = "Id";
                listFood.DataSource = foodTable;
            }
        }

        private void listFoods(object sender, EventArgs e)
        {
            PopulateFridgeTable();
        }

        private void PopulateFoodNames()
        {
            string query = "SELECT FoodInTheFridge.Name FROM FoodInTheFridge INNER JOIN FoodType ON FoodType.Id = FoodInTheFridge.TypeId WHERE FoodType.Id = @TypeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", listFood.SelectedValue);
                DataTable foodNameTable = new DataTable();
                adapter.Fill(foodNameTable);

                listFoodNames.DisplayMember = "Name";
                listFoodNames.ValueMember = "Id";
                listFoodNames.DataSource = foodNameTable;
            }
        }

        private void listFoodNames_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFoodNames();
        }
    }
}
