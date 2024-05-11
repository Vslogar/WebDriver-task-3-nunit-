using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using PageObjectModel.Source.Pages;
using SeleniumExtras.PageObjects;
using System;

namespace WebDriver_task_3_nunit_
{
    namespace PageObjectModel.Tests
    {
        public class HomeTests
        {
            private IWebDriver _driver;

            [SetUp]
            public void Setup()
            {

                _driver = new ChromeDriver();
                _driver.Manage().Window.Maximize();
                _driver.Navigate().GoToUrl("https://cloud.google.com/");
            }


            [Test]

            public void GoogleCloudCreation()
            {
                GoogleCloudPage googleCloudPage = new GoogleCloudPage(_driver);

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                googleCloudPage.PricingLink.Click();

                googleCloudPage.SearchInput.Click();
                googleCloudPage.SearchInput.SendKeys("Google Cloud Platform Pricing Calculator" + Keys.Enter);

                var links = _driver.FindElements(By.CssSelector("div.gs-title a.gs-title"));
                IWebElement specificLink = links.FirstOrDefault(link => link.Text == "Google Cloud Pricing Calculator");

                if (specificLink != null)
                {
                    // Element is found, you can now interact with it
                    specificLink.Click();
                }
                else
                { 
                    Assert.Fail();
                }


                googleCloudPage.AddToEstimateBtn.Click();

                googleCloudPage.ComputeEngine.Click();

                googleCloudPage.CookieBtnOk.Click();

                googleCloudPage.InstanceNumber.Clear();
                googleCloudPage.InstanceNumber.SendKeys("4");

                googleCloudPage.MachineType.Click();
                _driver.FindElement(By.XPath("//li[@data-value='n1-standard-8']")).Click();

                googleCloudPage.AddGPUsButton.Click();

                googleCloudPage.GPUModel.Click();
                _driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[2]/ul/li[3]")).Click();
                Thread.Sleep(1000);

                googleCloudPage.LocalSSD.Click();
                _driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]")).Click();
                Thread.Sleep(1000);


                googleCloudPage.OneYearCommittment.Click();
         
                googleCloudPage.OpenDetailedView.Click();
                
                string mainWindowHandle = _driver.CurrentWindowHandle;
                

                List<string> allWindowHandles = new List<string>(_driver.WindowHandles);

                // Iterate over all window handles and switch to the new one
                foreach (string windowHandle in allWindowHandles)
                {
                    if (windowHandle != mainWindowHandle)
                    {
                        _driver.SwitchTo().Window(windowHandle);
                        break;
                    }
                }

                Assert.Multiple(() =>
                {
                    Assert.That(googleCloudPage.PriceCalculation.Text, Is.EqualTo("Total estimated cost"));
                    Assert.That(googleCloudPage.MachineTypeSummary.Text.Contains("n1-standard-8"));
                    Assert.That(googleCloudPage.GPUModelSummary.Text, Is.EqualTo("NVIDIA Tesla V100"));
                    Assert.That(googleCloudPage.LocalSSDSummary.Text, Is.EqualTo("2x375 GB"));
                    Assert.That(googleCloudPage.NumberOfInstancesSummary.Text, Is.EqualTo("4"));
                });
            }

            [TearDown]
            public void Cleanup()
            {
                _driver.Quit();
            }
        }
    }
}