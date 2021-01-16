using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class PrekiuUzsakymoPuslapis : MantoBazinePuslapiu

    {
        public PrekiuUzsakymoPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement paspauskMygtukaKategorijos => driver.FindElement(By.Id("cat"));
        private IWebElement paspauskMygtukaLaptops => driver.FindElement(By.LinkText("Laptops"));
        private IWebElement paspauskMygtukaSonyVaio => driver.FindElement(By.CssSelector("#tbodyid > div:nth-child(1) > div > div > h4 > a"));
        private IWebElement paspauskMygtukaAdd => driver.FindElement(By.LinkText("Add to cart"));
        private IWebElement paspauskMygtukaCart => driver.FindElement(By.CssSelector("#navbarExample > ul > li:nth-child(4) > a"));
        private IWebElement paspauskMygtukaOrder => driver.FindElement(By.CssSelector("#page-wrapper > div > div.col-lg-1 > button"));
        private IWebElement iveskVarda => driver.FindElement(By.Id("name"));
        private IWebElement iveskSali => driver.FindElement(By.Id("country"));
        private IWebElement iveskMiesta => driver.FindElement(By.Id("city"));
        private IWebElement iveskKreditinesKortelesNr => driver.FindElement(By.Id("card"));
        private IWebElement iveskKreditinesKortelesGaliojimoMenesi => driver.FindElement(By.Id("month"));
        private IWebElement iveskKreditinesKortelesGaliojimoMetus => driver.FindElement(By.Id("year"));
        private IWebElement paspauskPatvirtinimoMygtuka => driver.FindElement(By.CssSelector("#orderModal > div > div > div.modal-footer > button.btn.btn-primary"));
        private IWebElement paspauskMygtukaUzdaryti => driver.FindElement(By.CssSelector("#orderModal > div > div > div.modal-footer > button.btn.btn-secondary"));
        private IWebElement paspauskMygtukaOK => driver.FindElement(By.CssSelector("body > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button"));
    

        public void PaspauskKategorijosMygtuka()
        {
            paspauskMygtukaKategorijos.Click();
        }
        public void PaspauskLaptopaiMygtuka()
        {
            paspauskMygtukaLaptops.Click();
        }
        public void PaspauskSony()
        {
            paspauskMygtukaSonyVaio.Click();
        }
        public void PridekKompaIkrepseli()
        {
            paspauskMygtukaAdd.Click();
        }
        public void PaspauskKrepselis()
        {
            paspauskMygtukaCart.Click();
        }
        public void PaspauskUzsakyti()
        {
            paspauskMygtukaOrder.Click();
        }
        public void NurodykVarda()
        {
            iveskVarda.SendKeys("Mantas");
        }
        public void NurodykSali()
        {
            iveskSali.SendKeys("Lietuva");
        }
        public void NurodykMiesta()
        {
            iveskMiesta.SendKeys("Vilnius");
        }
        public void NurodykKredinesNr()
        {
            iveskKreditinesKortelesNr.SendKeys("LT24263625365264562");
        }
        public void NurodykKredinesMenesi()
        {
            iveskKreditinesKortelesGaliojimoMenesi.SendKeys("Sausis");
        }
        public void NurodykKredinesMetus()
        {
            iveskKreditinesKortelesGaliojimoMetus.SendKeys("2024");
        }
        public void GalutinisPatvirtinimas()
        {
            paspauskPatvirtinimoMygtuka.Click();
        }
        public void PaspauskCloseMygtuka()
        {
            paspauskMygtukaUzdaryti.Click();
        }
        public void PaspauskOkMygtuka()
        {
            paspauskMygtukaOK.Click();
        }
      
        







    }



}
