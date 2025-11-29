
using DbForm.modules.Register;
using MySql.Data.MySqlClient;

namespace DbForm.modules.Login
{
    public partial class LoginForm : Form
    {

        private string ConnectionString = "Server=localhost;Database=csharpprogram;User ID=root;Password=;";
        public LoginForm()
        {
            DrawForm();
        }
            public void click_register(object? sender, EventArgs e)
        {
           this.Hide();
           using (RegisterForm form = new RegisterForm())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        public void click_login(object? sender, EventArgs e)
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
                bool isInserted = this.Login(UserName, Password);
                String msg = "Failed to Login";
                if (isInserted){ 
                msg = "Welcome " + UserName;
            }
            MessageBox.Show(msg);
            
        }
        }
        public bool  Login(string username, string password)
        {
            using MySqlConnection  connection= new MySqlConnection(this.ConnectionString);
            string InsertQuery = "SELECT * FROM `users` WHERE username = @user AND password = @pass";
            using MySqlCommand cmd = new MySqlCommand(InsertQuery,connection);

            cmd.Parameters.AddWithValue("@user",username);
            cmd.Parameters.AddWithValue("@pass",password);
                      connection.Open();
            using MySqlDataReader reader = cmd.ExecuteReader();

  
            bool isSuccess = reader.Read();
            return isSuccess;

            
        }
        
        }
    }
