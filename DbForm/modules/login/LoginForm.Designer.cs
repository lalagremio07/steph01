namespace DbForm.modules.Login
{
    partial class LoginForm
    {
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnRegister;
        private Label lblUserName;
        private Label lblPassword;
        private Button btnLogin;


        public void DrawForm()
        {

            this.txtUserName = new TextBox();
             this.txtPassword = new TextBox();
              this.lblUserName = new Label();
              this.lblPassword = new Label();
              this.btnRegister = new Button();
              this.btnLogin = new Button();



            this.lblUserName.Text = "UserName";
            this.lblPassword.Text = "Password";
            this.btnRegister.Text = "Register";
            this. btnLogin.Text = "Login";


            this.btnLogin.Location= new Point(120,110);
            this.btnLogin.Size = new Size(60,30);
            this.btnLogin.Click += click_login;


            this.txtUserName.Location = new Point(50,30);
            this.lblUserName.Location = new Point(50,10);
            this.txtUserName.Size = new Size(200,20);

            this.lblPassword.Location = new Point(50,60);
            this.txtPassword.Location = new Point(50,80);
            this.txtPassword.Size = new Size(200,20);

            this.txtPassword.PasswordChar = '*';
            this.Text = "Login Form";

            this.btnRegister.Location = new Point(120,140);
            this.btnRegister.Size = new Size(60,30);
            this.btnRegister.Click += click_register;


            this.ClientSize = new Size(300,170);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);

            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);

            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);


            
        }
    }
}
