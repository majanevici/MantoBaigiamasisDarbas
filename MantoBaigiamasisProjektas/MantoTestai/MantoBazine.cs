using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.Testai
{
    class MantoBazine
    {
        public IWebDriver driver;

        [SetUp]
        public void priesTesta()
        {
            driver = new ChromeDriver();
            //driver.Url = "https://www.demoblaze.com";
            driver.Url = "https://www.notarurumai.lt";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
        }
        [TearDown]
        public void poTesto()
        {
            driver.Quit();
        }
    }
}
