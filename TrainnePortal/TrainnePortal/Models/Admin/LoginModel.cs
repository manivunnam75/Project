namespace TrainnePortal.Models.Admin
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password{ get; set; }
    }

    public class Credentials
    {
        public LoginModel Details(LoginModel loginModel)
        {
            LoginModel c1 = new LoginModel()
            {
              UserName = "Cognine",
                Password = "12345"

            };
            return c1;
        
        }
    }
}
