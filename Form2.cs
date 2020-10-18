using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oop_6115261002_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butDDisplay_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=ice_cream";
                string Query = "select * from ice_cream_detail;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;


                DataTable dTable = new DataTable();


                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;






                // MyConn2.Close(); 


            }


            catch (Exception ex)
            {






                MessageBox.Show(ex.Message);


            }


        }

        private void butDAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=ice_cream";

                string Query = "insert into ice_cream_detail(d_ID,d_Cup,d_S,d_M,d_L,d_XL,d_XXL) " +
                    "values('" + this.txtDID.Text + "','" + this.txtDCup.Text + "','" + this.radioDS.Checked + "','" + this.radioDM.Checked + "','" + this.radioDL.Checked + "','" + this.radioDXL.Checked + "','" + this.radioXXL.Checked + "');";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }


        }

        private void butDEdit_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=ice_cream";


                string Query = "update ice_cream_detail set d_ID='" + this.txtDID.Text + "',d_Cup='" + this.txtDCup.Text + "''" + this.radioDS.Checked + "','" + this.radioDM.Checked + "','" + this.radioDL.Checked + "','" + this.radioDXL.Checked + "','" + this.radioXXL.Checked + "');";
      


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Updated");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();//Connection closed here 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }


        }

        private void butDDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=ice_cream";

                string Query = "delete from ice_cream_detail where d_ID'" + this.txtDID.Text + "',d_Cup'" + this.txtDCup.Text + "''" + this.radioDS.Checked + "','" + this.radioDM.Checked + "','" + this.radioDL.Checked + "','" + this.radioDXL.Checked + "','" + this.radioXXL.Checked + "');";
            

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Deleted");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }


        }

        private void butDNext_Click(object sender, EventArgs e)
        {
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }

        }
    }
}
