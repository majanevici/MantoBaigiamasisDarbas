using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.Testai
{
    class MantoBazine
    {
        public IWebDriver driver;

        [SetUp]
        public void priesTesta()
        {
            PerKokiaNarsyklePaleisiTesta("chrome");
            //driver.Url = "https://www.demoblaze.com";
            driver.Url = "https://www.notarurumai.lt";
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            
        }
        public void PerKokiaNarsyklePaleisiTesta(string NarsyklesDriverPavadinimas)
        {
            if (NarsyklesDriverPavadinimas == "chrome")
            {
                driver = new ChromeDriver(GautiChromoPradinesKonfiguracijas());
            }
            if (NarsyklesDriverPavadinimas == "firefox")
            {
                driver = new FirefoxDriver(GautiFirefoxPradinesKonfiguracijas());
            }
        }
        public ChromeOptions GautiChromoPradinesKonfiguracijas()
        {
            ChromeOptions konfiguracijos = new ChromeOptions();
            konfiguracijos.AddArguments("--start-maximized");
            return konfiguracijos;
        }
        public FirefoxOptions GautiFirefoxPradinesKonfiguracijas()
        {
            FirefoxOptions konfiguracijosFF = new FirefoxOptions();
            konfiguracijosFF.AddArguments("start-maximized", "incognito", "-headless");
            return konfiguracijosFF;
        }
        [TearDown]
        public void poTesto()
        {
            driver.Quit();
        }
    }
}
