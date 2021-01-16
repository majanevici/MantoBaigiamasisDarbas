using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
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
            /*
             URL "https://www.demoblaze.com" naudojamas su siais testais:PrekesPridejimoTikrinimas,PrekesUzsakymoTikrinimas,
             PrisijungimoTikrinimas.
             URL "https://www.notarurumai.lt" naudojamas sus siais testais: KalbosKeitimoTikrinimas,NotaroBuveinesTikrinimas,
             UrlTikrinimas, VideoTikrinimas.
             */
            driver.Url = "https://www.demoblaze.com";
            //driver.Url = "https://www.notarurumai.lt";
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }
        public void PalaukKolAtsirasElementasIrUzdarykJi()
        {
            WebDriverWait palauk = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            palauk.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".fancybox-button--close path")));
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
            konfiguracijos.AddArgument("--start-fullscreen");
            return konfiguracijos;
        }
        public FirefoxOptions GautiFirefoxPradinesKonfiguracijas()
        {
            FirefoxOptions konfiguracijosFF = new FirefoxOptions();
            konfiguracijosFF.AddArguments("-headless");
            return konfiguracijosFF;
        }
        

        [TearDown]
        public void poTesto()
        {
            driver.Quit();
        }
    }
}
