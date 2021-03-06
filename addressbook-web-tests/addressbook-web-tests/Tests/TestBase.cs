﻿using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            //driver = new FirefoxDriver();
            //baseURL = "http://localhost/addressbook";

        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
