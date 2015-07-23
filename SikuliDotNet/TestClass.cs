using System;
using NUnit.Framework;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Sikuli4Net.sikuli_UTIL;
using Sikuli4Net.sikuli_REST;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace SikuliTesting
{
    [TestFixture]
    public class Sikuli
    {
        static IWebDriver driver;

        APILauncher launcher = new APILauncher(true);

        [TestFixtureSetUp]
        public void ClassInitialize()
        {

            launcher.Start();
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://accounts.google.com/ServiceLogin?service=mail&continue=https://mail.google.com/mail/#identifier");
        }

        [TestFixtureTearDown]
        public void ClassCleanup()
        {
            driver.Quit();
            launcher.Stop();
        }


        [Test]
        public void LogInTest()
        {
            //Screen
            Screen loginPage = new Screen();

            //Pattern

            Pattern nextButton = new Pattern(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\nextButton.png"));
            Pattern userNameInput = new Pattern(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\emailInput.png"));

            Pattern userPassInput = new Pattern(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\passwordInput.png"));
            Pattern signInButton = new Pattern(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\signInButton.png"));

            //Waiting until the user name input is present
            loginPage.Wait(userNameInput);

            //Setting user name and password
            loginPage.Type(userNameInput, "automatedtestms@gmail.com", KeyModifier.NONE);

            //Clicking on the Next button
            loginPage.Click(nextButton);

            //Waiting until the password input is present
            loginPage.Wait(userPassInput);

            //Setting user name and password
            loginPage.Type(userPassInput, "123456789abcd!", KeyModifier.NONE);

            //Clicking on the "Sign in" button
            loginPage.Click(signInButton);
            
            //Drag and drop

            //Screen
            Screen gmailPage = new Screen();
            
            Pattern moreIcon = new Pattern(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\moreApp.png"));
            Pattern driveIcon = new Pattern(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\driveIcon.png"));

            Pattern trashOption = new Pattern(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\trashOption.png"));
            Pattern pdfFile = new Pattern(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\pdfFile.png"));

            //Clicking on the more icon
            gmailPage.Wait(moreIcon);
            gmailPage.Click(moreIcon);

            //Waiting Drive icon
            gmailPage.Wait(driveIcon);

            //Clicking on the Drive Icon
            gmailPage.Click(driveIcon);

            //Waiting elements
            gmailPage.Wait(pdfFile,40);
            gmailPage.Wait(trashOption);
            gmailPage.DragDrop(pdfFile, trashOption);
            
        }

       
    }
}
