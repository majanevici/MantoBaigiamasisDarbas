using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class NotaruRumaiPuslapis : MantoBazinePuslapiu

    {
        public NotaruRumaiPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement slapukai => driver.FindElement(By.CssSelector("#mm-0 > div.cookie_container.ng-scope > div > div > div.cookies_checkboxes > button"));
        private IWebElement naujienosMygtukas => driver.FindElement(By.CssSelector("#mm-0 > div.header_container > header > div > nav > ul > li:nth-child(1) > a"));
        
        public void IsjunkSlapukus()
        {
            slapukai.Click();
        }
        public void IsskleiskNaujienas()
        {
            naujienosMygtukas.Click();
        }
        public void PalyginkURL()
        {
            Assert.AreEqual("https://www.notarurumai.lt/naujienos/1", driver.Url);
        }
    }
}
