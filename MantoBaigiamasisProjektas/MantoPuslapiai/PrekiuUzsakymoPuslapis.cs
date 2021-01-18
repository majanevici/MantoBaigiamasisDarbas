using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class PrekiuUzsakymoPuslapis : MantoBazinePuslapiu

    {
        public PrekiuUzsakymoPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement mygtukasKategorijos => driver.FindElement(By.Id("cat"));
        private IWebElement mygtukasLaptops => driver.FindElement(By.LinkText("Laptops"));
        private IWebElement mygtukasSonyVaio => driver.FindElement(By.CssSelector("#tbodyid > div:nth-child(1) > div > div > h4 > a"));
        private IWebElement mygtukasAdd => driver.FindElement(By.LinkText("Add to cart"));
        private IWebElement mygtukasCart => driver.FindElement(By.CssSelector("#navbarExample > ul > li:nth-child(4) > a"));
        private IWebElement mygtukasOrder => driver.FindElement(By.CssSelector("#page-wrapper > div > div.col-lg-1 > button"));
        private IWebElement vardas => driver.FindElement(By.Id("name"));
        private IWebElement salis => driver.FindElement(By.Id("country"));
        private IWebElement miestas => driver.FindElement(By.Id("city"));
        private IWebElement kreditinesKortelesNr => driver.FindElement(By.Id("card"));
        private IWebElement kreditinesKortelesGaliojimoMenesis => driver.FindElement(By.Id("month"));
        private IWebElement kreditinesKortelesGaliojimoMetai => driver.FindElement(By.Id("year"));
        private IWebElement patvirtinimoMygtukas => driver.FindElement(By.CssSelector("#orderModal > div > div > div.modal-footer > button.btn.btn-primary"));
        private IWebElement mygtukasUzdaryti => driver.FindElement(By.CssSelector("#orderModal > div > div > div.modal-footer > button.btn.btn-secondary"));
        private IWebElement mygtukasOK => driver.FindElement(By.CssSelector("body > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button"));
    
        public void PaspauskKategorijosMygtuka()
        {
            mygtukasKategorijos.Click();
        }
        public void PaspauskLaptopaiMygtuka()
        {
            mygtukasLaptops.Click();
        }
        public void PaspauskSony()
        {
            mygtukasSonyVaio.Click();
        }
        public void PridekKompaIkrepseli()
        {
            mygtukasAdd.Click();
        }
        public void PaspauskKrepselis()
        {
            mygtukasCart.Click();
        }
        public void PaspauskUzsakyti()
        {
            mygtukasOrder.Click();
        }
        public void NurodykVarda()
        {
            vardas.SendKeys("Mantas");
        }
        public void NurodykSali()
        {
            salis.SendKeys("Lietuva");
        }
        public void NurodykMiesta()
        {
            miestas.SendKeys("Vilnius");
        }
        public void NurodykKredinesNr()
        {
            kreditinesKortelesNr.SendKeys("LT24263625365264562");
        }
        public void NurodykKredinesMenesi()
        {
            kreditinesKortelesGaliojimoMenesis.SendKeys("Sausis");
        }
        public void NurodykKredinesMetus()
        {
            kreditinesKortelesGaliojimoMetai.SendKeys("2024");
        }
        public void GalutinisPatvirtinimas()
        {
            patvirtinimoMygtukas.Click();
        }
        public void PaspauskCloseMygtuka()
        {
            mygtukasUzdaryti.Click();
        }
        public void PaspauskOkMygtuka()
        {
            mygtukasOK.Click();
        }
        public void PalyginkArSekmingaiUzsakytaPreke()
        {
            Assert.AreEqual("Thank you for your purchase!", driver.FindElement(By.CssSelector("h2:nth-child(6)")).Text);
        }
    }
}
