using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class KalbosPuslapis : MantoBazinePuslapiu

    {
        public KalbosPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement kalbuIsskleidimiMygtukas => driver.FindElement(By.CssSelector("#mm-0 > div.header_container > header > div > div > div.langs > div > div.current_lang_cont > span > span.icon-triangle-left.icon-down"));
        private IWebElement kalbosPasirinkimoMygtukas=> driver.FindElement(By.LinkText("English"));
        private IWebElement pakeistosKalbosPaptikrinimas => driver.FindElement(By.CssSelector("#mm-0 > div.header_container > header > div > nav > ul > li:nth-child(2) > a"));

        public void IsskleiskKalbas()
        {
            kalbuIsskleidimiMygtukas.Click();
        }

        public void PasirinkKalba()
        {
            kalbosPasirinkimoMygtukas.Click();
        }
        public void PalyginkKalba()
        {
            Assert.AreEqual("NOTARIES", pakeistosKalbosPaptikrinimas.Text);

        }









    }

}
