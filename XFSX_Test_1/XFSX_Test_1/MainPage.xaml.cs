using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace XFSX_Test_1
{
    public partial class MainPage : TabbedPage
    {
        private PlatformRelatedCalls platformRelatedCalls;
        private Functions functions;
        private RestService restService;
        public MainPage()
        {
            InitializeComponent();
            restService = new RestService();
            LoginConfig();
            RegisterConfig();
            platformRelatedCalls = new PlatformRelatedCalls();
            functions = new Functions();
        }
        public async void LoginConfig()
        {
            List<User> users = await restService.RefreshDataAsync();
            TapGestureRecognizer tgrNotRegistered = new TapGestureRecognizer();
            tgrNotRegistered.Tapped += OnClick;
            lblNotRegistered.GestureRecognizers.Add(tgrNotRegistered);
            btnLogin.Clicked += OnClick;
            if (users.Count > 0)
            {
                txtLoginUsername.Text = users[1].Username;
            }
        }
        public void RegisterConfig()
        {
            btnRegister.Clicked += OnClick;
        }
        public void OnClick(object element, EventArgs args)
        {
            if (element.Equals(btnLogin))
            {
                string username, password;
                username = txtLoginUsername.Text;
                password = txtLoginPassword.Text;
                if (!functions.IsNullOrEmpty(username))
                {
                    if (!functions.IsNullOrEmpty(password))
                    {
                        //Database Connection
                        platformRelatedCalls.showToast("Database Connection");
                    }
                    else
                    {
                        platformRelatedCalls.showToast("Password is required!!");
                    }
                }else
                {
                    platformRelatedCalls.showToast("Username is required!!");
                }                
            }
            else if (element.Equals(lblNotRegistered))
            {
                this.CurrentPage = cpRegister;
            }
            else if (element.Equals(btnRegister))
            {
                string username, password, confirmpassword, fname, lname;
                username = txtRegisterUsername.Text;
                password = txtRegisterPassword.Text;
                confirmpassword = txtRegisterConfirmPassword.Text;
                fname = txtRegisterFirstName.Text;
                lname = txtRegisterLastName.Text;
                if (!functions.IsNullOrEmpty(username) && !functions.IsNullOrEmpty(password) 
                    && !functions.IsNullOrEmpty(fname) && !functions.IsNullOrEmpty(lname))
                {
                    if (password.Equals(confirmpassword))
                    {
                        //Database Connection
                        platformRelatedCalls.showToast("Database Connection");
                    }
                    else
                    {
                        platformRelatedCalls.showToast("Passwords don't match!!");
                    }
                }else
                {
                    platformRelatedCalls.showToast("All fields are required!!");
                }
            }
        }
    }
}