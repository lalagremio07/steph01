using System.Windows.Forms;
using DbForm.modules.Login;
using MySql.Data.MySqlClient;

namespace DbForm.modules.Register
{
    public partial class RegisterForm : Form
    {

        private string ConnectionString = "Server=localhost;Database=csharpprogram;User ID=root;Password=;";
        public RegisterForm()
        {
            DrawForm();
        }

        public void click_register(object? sender, EventArgs e)
        {
            String UserName = this.txtUserName.Text.Trim();
            String Password = this.txtPassword.Text.Trim();

            if (UserName.Length <5)
            {
                MessageBox.Show("Enter valid Username!");

            }else if (Password.Length < 8)
            {
                MessageBox.Show("Password should be less than 8!");
            }
            else
            {
                bool isInserted = this.Register(UserName, Password);
                String msg = "Failed to Register";
                if (isInserted){ 
                msg = "You are now registered";
            }
            MessageBox.Show(msg);
            }
        }
        

        public void click_login(object? sender, EventArgs e)
        {
           this.Close();
        }

        
        public bool Register(string username, string password)
        {
            using MySqlConnection  connection= new MySqlConnection(this.ConnectionString);
            string InsertQuery = "Insert Into users (username,password) VALUES (@user,@pass)";
            using MySqlCommand cmd = new MySqlCommand(InsertQuery,connection);

            cmd.Parameters.AddWithValue("@user",username);
            cmd.Parameters.AddWithValue("@pass",password);

            connection.Open();
            bool isSuccess = cmd.ExecuteNonQuery() >0;
            return isSuccess;
            
        }
        
        }
    }
