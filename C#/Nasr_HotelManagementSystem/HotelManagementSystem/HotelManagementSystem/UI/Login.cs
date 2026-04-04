using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Context.LoginManager;
using HotelManagementSystem.Context.FrontendReservation;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Dapper;
using Microsoft.Data.SqlClient;

namespace HotelManagementSystem.UI
{

    public partial class Login : MetroForm
    {
        LoginManagerContext LoginManagerContext = new LoginManagerContext();
        FrontendReservationContext FrontendReservationContext = new FrontendReservationContext();
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifier("frontend".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    this.Hide();
                    Frontend hotel_management = new Frontend();
                    hotel_management.Show();
                }
                else if (verifier("kitchen".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    this.Hide();
                    Kitchen kitchen_management = new Kitchen();
                    kitchen_management.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = false;
            }

        }

        public bool verifier(string tableName, string username, string password)
        {

             using DbConnection conn = new SqlConnection(LoginManagerContext.Database.GetDbConnection().ConnectionString);
            //using LoginManagerContext context = new();

            //context.Database.EnsureCreated();
            //context.Frontends.Load();
            //context.Kitchens.Load();
            // using from sql
            if (tableName == "frontend")
            {
                return conn.Query<dynamic>(@"SELECT * FROM Frontends WHERE UserName = @User AND Password = @Pass", new { User = username, Pass = password }).Any();
            }
            else if (tableName == "kitchen")
            {
                return conn.Query<dynamic>(@"SELECT * FROM dbo.Kitchens WHERE Username = @Username AND Password = @Password", new { Username = username, Password = password }).Any();
            }

            return false;
            //bool success = false;
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.loginConnectionString);
            //string sql = "SELECT* FROM "  +tableName+ " WHERE user_name=@userName AND pass_word=@password";
            //try
            //{
            //    SqlCommand sqlCommand = new SqlCommand(sql, connection);
            //    sqlCommand.CommandText = sql;
            //    SqlParameter UsernameParametar = new SqlParameter("@username", SqlDbType.VarChar);
            //    SqlParameter PassParametar = new SqlParameter("@password", SqlDbType.VarChar);
            //    sqlCommand.Parameters.Add(UsernameParametar);
            //    sqlCommand.Parameters.Add(PassParametar);
            //    UsernameParametar.Value = username;
            //    PassParametar.Value = password;
            //    connection.Open();
            //    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            //    if (sqlReader.HasRows)
            //        success = true;
            //    connection.Close();
            //}
            //catch (Exception e)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            //}
            //return success;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LicenseCallButton_Click(object sender, EventArgs e)
        {
            License open_license = new License();
            open_license.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
