using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class PrekiuPuslapis : MantoBazinePuslapiu

    {
        public PrekiuPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement paspauskMygtukaKategorijos => driver.FindElement(By.Id("cat"));
        private IWebElement paspauskMygtukaPhones => driver.FindElement(By.LinkText("Phones"));
        private IWebElement paspauskMygtukaIphone632gb => driver.FindElement(By.CssSelector("#tbodyid > div:nth-child(1) > div > div > h4 > a"));
        private IWebElement paspauskMygtukaAdd => driver.FindElement(By.LinkText("Add to cart"));
        private IWebElement paspauskMygtukaCart => driver.FindElement(By.CssSelector("#navbarExample > ul > li:nth-child(4) > a"));
        private IWebElement paspauskMygtukaIstrinti => driver.FindElement(By.LinkText("Delete"));

        public void PaspauskKategorijosMygtuka()
        {
            paspauskMygtukaKategorijos.Click();
        }
        public void PaspauskTelefonaiMygtuka()
        {
            paspauskMygtukaPhones.Click();
        }
        public void PaspauskIphone6()
        {
            paspauskMygtukaIphone632gb.Click();
        }
        public void PridekTelefonaIkrepseli()
        {
            paspauskMygtukaAdd.Click();
        }
        public void PaspauskKrepselis()
        {
            paspauskMygtukaCart.Click();
        }
        public void PaspauskMygtukaIstrinti()
        {
            paspauskMygtukaIstrinti.Click();
        }





    }



}