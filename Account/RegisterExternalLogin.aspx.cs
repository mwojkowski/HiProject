using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using HolyInnocents.Models;

namespace HolyInnocents.Account
{
    public partial class RegisterExternalLogin : System.Web.UI.Page
    {
        protected string ProviderName
        {
            get { return (string)ViewState["ProviderName"] ?? String.Empty; }
            private set { ViewState["ProviderName"] = value; }
        }

        protected string ProviderAccountKey
        {
            get { return (string)ViewState["ProviderAccountKey"] ?? String.Empty; }
            private set { ViewState["ProviderAccountKey"] = value; }
        }

        protected void Page_Load()
        {
            // Process the result from an auth provider in the request
            ProviderName = IdentityHelper.GetProviderNameFromRequest(Request);
            if (String.IsNullOrEmpty(ProviderName))
            {
                Response.Redirect("~/Account/Login");
            }
            if (!IsPostBack)
            {
                var manager = new UserManager();
                var LoginInfo = Context.GetOwinContext().Authentication.GetExternalLoginInfo();
                if (LoginInfo == null)
                {
                    Response.Redirect("~/Account/Login");
                }
                var user = manager.Find(LoginInfo.Login);
                if (user != null)
                {
                    IdentityHelper.SignIn(manager, user, isPersistent: false);
                    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
                else if (User.Identity.IsAuthenticated)
                {
                    // Apply Xsrf check when linking
                    var verifiedLoginInfo = Context.GetOwinContext().Authentication.GetExternalLoginInfo(IdentityHelper.XsrfKey, User.Identity.GetUserId());
                    if (verifiedLoginInfo == null)
                    {
                        Response.Redirect("~/Account/Login");
                    }

                    var result = manager.AddLogin(User.Identity.GetUserId(), verifiedLoginInfo.Login);
                    if (result.Succeeded)
                    {
                        IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                    }
                    else
                    {
                        AddErrors(result);
                        return;
                    }
                }
                else
                {
                    userName.Text = LoginInfo.DefaultUserName;
                }
            }
        }        
        
        protected void Login_Click(object sender, EventArgs e)
        {
            CreateAndLoginUser();
        }

        private void CreateAndLoginUser()
        {
            if (!IsValid)
            {
                return;
            }
            var manager = new UserManager();
            var user = new ApplicationUser() { UserName = userName.Text };
            IdentityResult result = manager.Create(user);
            if (result.Succeeded)
            {
                var LoginInfo = Context.GetOwinContext().Authentication.GetExternalLoginInfo();
                if (LoginInfo == null)
                {
                    Response.Redirect("~/Account/Login");
                    return;
                }
                result = manager.AddLogin(user.Id, LoginInfo.Login);
                if (result.Succeeded)
                {
                    IdentityHelper.SignIn(manager, user, isPersistent: false);
                    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                    return;
                }
            }
            AddErrors(result);
        }

        private void AddErrors(IdentityResult result) 
        {
            foreach (var error in result.Errors) 
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}