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
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }


        string SchoolName = SelectSchool_frm.school;
        string SchoolID = "";
        string Username = "";
        string Password = "";
        string Privillage = "";
        string UserID = "";
        bool exists = false;



        private void Login_btn_Click(object sender, EventArgs e)
        {
            // we need to verify that the person signing in has access..
            string verifyQuery = "SELECT user_id,password,privillage from users_tbl where username = '"+Username_txbx.Text.Trim()+"'";
            using (MySqlConnection verifyCon = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConfigString"].ToString()))
            using (MySqlCommand VerifyCom = verifyCon.CreateCommand())
            {
                VerifyCom.CommandText = verifyQuery;
                verifyCon.Open();
                
                
                using (MySqlDataReader VerifyRead = VerifyCom.ExecuteReader())
                {

                    while(VerifyRead.Read())
                    {

                        UserID = VerifyRead["user_id"].ToString();
                        Password = VerifyRead["password"].ToString();
                        Privillage = VerifyRead["privillage"].ToString();

                        exists = true;



                    }

                }

                verifyCon.Close();

            }


            if (password_txbx.Text == Password)
            {


                MessageBox.Show("Login Successful!", "Notice");


            }
            else
            {

                MessageBox.Show("Either your password or username is incorrect | Please Try Again","Notice");
            }



        }

        private void Login_frm_Load(object sender, EventArgs e)
        {
            // we need to get the school id for the school..

            string getIdQuery = " SELECT SchoolID from schoolname_tbl where schoolname = '" + SchoolName + "'";
            using (MySqlConnection GetIdCon = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConfigString"].ToString()))
            using (MySqlCommand GetIdCom = GetIdCon.CreateCommand())
            {


                GetIdCom.CommandText = getIdQuery;
                GetIdCon.Open();

                using (MySqlDataReader GetIdReader = GetIdCom.ExecuteReader())
                {

                    while (GetIdReader.Read())
                    {

                        SchoolID = GetIdReader["SchoolID"].ToString();


                    }


                }

                GetIdCon.Close();



            }










        }
    }
}
