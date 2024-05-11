﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
    public class GoogleCloudPage
    {
        private IWebDriver _driver;

        public GoogleCloudPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "a[href='https://cloud.google.com/pricing/']")]
        public IWebElement PricingLink;

        [FindsBy(How = How.ClassName, Using = "mb2a7b")]
        public IWebElement SearchInput;

        //[FindsBy(How = How.CssSelector, Using = "div.gs-title a.gs-title")]
        //public IWebElement ResultBox;

        [FindsBy(How = How.ClassName, Using = "UywwFc-LgbsSe")]
        public IWebElement AddToEstimateBtn;

        [FindsBy(How = How.ClassName, Using = "d5NbRd-EScbFb-JIbuQc")]
        public IWebElement ComputeEngine;

        [FindsBy(How = How.Id, Using = "c11")]
        public IWebElement InstanceNumber;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow4']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]")]
        public IWebElement MachineType;

        [FindsBy(How = How.ClassName, Using = "glue-cookie-notification-bar__accept")]
        public IWebElement CookieBtnOk;

        [FindsBy(How = How.XPath, Using = "//button[@role='switch' and @aria-label='Add GPUs']")]
        public IWebElement AddGPUsButton; 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[1]")]
        public IWebElement GPUModel; 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]")]
        public IWebElement LocalSSD; 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[31]/div/div/div[2]/div/div/div[2]")]
        public IWebElement OneYearCommittment; 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ow4\"]/div/div/div/div/div/div/div[2]/div[1]/div/div[4]/div[2]/div[1]/span[1]/div[1]/a")]
        public IWebElement OpenDetailedView; 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[1]/div/div[1]/div[1]/h5")]
        public IWebElement PriceCalculation; 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[3]/span[2]/span[1]/span[2]")]
        public IWebElement MachineTypeSummary;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[4]/span[2]/span[1]/span[2]")]
        public IWebElement GPUModelSummary;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[5]/span/span[1]/span[2]")]
        public IWebElement LocalSSDSummary; 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[7]/span/span[1]/span[2]")]
        public IWebElement NumberOfInstancesSummary;





    }
}