using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class NotaroBuveinesPuslapis : MantoBazinePuslapiu

    {
        public NotaroBuveinesPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement slapukai => driver.FindElement(By.CssSelector("#mm-0 > div.cookie_container.ng-scope > div > div > div.cookies_checkboxes > button"));
        private IWebElement paspauskAntIvedimoLauko => driver.FindElement(By.CssSelector(".search_cont:nth-child(1) .ng-pristine > .ng-pristine"));
        private IWebElement notaroIvedimas => driver.FindElement(By.CssSelector("#mm-0 > div.header_container > header > div > div > div.search_cont > div > div > form > input"));
        private IWebElement paieskosMygtukas => driver.FindElement(By.CssSelector("#mm-0 > div.header_container > header > div > div > div.search_cont > div > div > form > button > span"));
        private IWebElement surastoNotaroMygtukas => driver.FindElement(By.CssSelector("#mm-0 > div.index_container.container-fluid.global_container > div > main > div > div.search_results > a:nth-child(2) > div > div.item-top > span.title > span"));
        private IWebElement biuroLaukelis => driver.FindElement(By.Id("contacts"));
        private IWebElement navigacijosMygtukas => driver.FindElement(By.CssSelector("#mm-0 > div.index_container.container-fluid.global_container > div > main > div > div.office_single > div.office_single_main > div.contacts-block > a.btn"));

        public void IsjunkSlapukus()
        {
            slapukai.Click();
        }
        public void PaspauskPaieskosLaukas()
        {
            paspauskAntIvedimoLauko.Click();
        }
        public void IveskNotara()
        {
            notaroIvedimas.SendKeys("Ramūnas Trečiokas");
        }
        public void PaspauskIeskoti()
        {
            paieskosMygtukas.Click();
        }
        public void PaspauskAntNotaro()
        {
            surastoNotaroMygtukas.Click();
        }
        public void PalyginkArTasBiuras()
        {
            Assert.AreEqual("Vilniaus miesto 26-asis notarų biuras", biuroLaukelis.Text);
        }
        public void SuraskBiuraGoogle()
        {
            navigacijosMygtukas.Click();
        }
    }
}