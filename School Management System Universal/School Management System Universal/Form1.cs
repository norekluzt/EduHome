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
using System.Configuration;



namespace School_Management_System_Universal
{
    public partial class SelectSchool_frm : Form
    {
        public SelectSchool_frm()
        {
            InitializeComponent();
        }

        public static string school = "";


        private void button1_Click(object sender, EventArgs e)
        {
            if (SchoolName_cmbx.Text == "")
            {
                MessageBox.Show("Please Select a Valid School from the list ","Notice");
            }
            else
            {



               school = SchoolName_cmbx.SelectedItem.ToString();
                this.Hide();
             
                Login_frm login_Frm = new Login_frm();
                login_Frm.ShowDialog();


            }


        }

        private void SelectSchool_frm_Load(object sender, EventArgs e)
        {

            // We need to load all the schools available on the database
            //
            string getSchoolQuery = "SELECT SchoolName FROM schoolname_tbl";
            using (MySqlConnection GetSchoolCon = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConfigString"].ToString()))
            using (MySqlCommand GetSchoolCom = GetSchoolCon.CreateCommand())
            {

                GetSchoolCom.CommandText = getSchoolQuery;
                GetSchoolCon.Open();

                using (MySqlDataReader GetSchoolReader = GetSchoolCom.ExecuteReader())
                {

                    while (GetSchoolReader.Read())
                    {
                        SchoolName_cmbx.Items.Add(GetSchoolReader["SchoolName"].ToString());
                    }


                }




                GetSchoolCon.Close();

            }






        }
    }
}
