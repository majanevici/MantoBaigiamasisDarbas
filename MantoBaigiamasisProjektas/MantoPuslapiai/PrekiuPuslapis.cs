using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class PrekiuPuslapis : MantoBazinePuslapiu

    {
        public PrekiuPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement mygtukasKategorijos => driver.FindElement(By.Id("cat"));
        private IWebElement mygtukasPhones => driver.FindElement(By.LinkText("Phones"));
        private IWebElement mygtukasIphone632gb => driver.FindElement(By.CssSelector("#tbodyid > div:nth-child(1) > div > div > h4 > a"));
        private IWebElement mygtukasAdd => driver.FindElement(By.LinkText("Add to cart"));
        private IWebElement mygtukasCart => driver.FindElement(By.CssSelector("#navbarExample > ul > li:nth-child(4) > a"));
        private IWebElement mygtukasIstrinti => driver.FindElement(By.LinkText("Delete"));

        public void PaspauskKategorijosMygtuka()
        {
            mygtukasKategorijos.Click();
        }
        public void PaspauskTelefonaiMygtuka()
        {
            mygtukasPhones.Click();
        }
        public void PaspauskIphone6()
        {
            mygtukasIphone632gb.Click();
        }
        public void PridekTelefonaIkrepseli()
        {
            mygtukasAdd.Click();
        }
        public void PaspauskKrepselis()
        {
            mygtukasCart.Click();
        }
        public void PaspauskMygtukaIstrinti()
        {
            mygtukasIstrinti.Click();
        }
    }
}