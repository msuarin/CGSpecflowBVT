using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGSpecFlowBVT.PageIDs
{
    public class LoginIDs
    {
        //Logged out page
        public string loggedOutMessage = @"//*[@id='Label1' and text()='You are now logged out.']";
        public string loginLink = @"//*[@id='HyperLink2']";
        public string returnToApplication = @"//*[@id='HyperLink1']";

        //Log in page
        public string userInputBox = @"//*[@id='UserId_TextBox1']";
        public string passwordInputBox = @"//*[@id='Password_TextBox1']";
        public string logInBtn = @"//*[@id='Button1']";

        //Logged in user display name and link
        public string loggedInUserLink = @"//form[contains(@id, 'form2')]/div[2]/div/ul[contains(@id, 'userMenu')]/li/a";
    }
}
