using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai
{
    class VideoPuslapis : MantoBazinePuslapiu

    {
        public VideoPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement slapukai => driver.FindElement(By.CssSelector("#mm-0 > div.cookie_container.ng-scope > div > div > div.cookies_checkboxes > button"));
        private IWebElement videoMygtukas => driver.FindElement(By.CssSelector("#mm-0 > div.header_container > header > div > nav > ul > li:nth-child(4) > a"));
        private IWebElement videoBiblioteka=> driver.FindElement(By.CssSelector("#mm-0 > div.index_container.container-fluid.global_container > div > main > div > div.youtube_list > a:nth-child(1) > div > img"));
        private IWebElement isjunkVideo => driver.FindElement(By.CssSelector(".fancybox-button--close path"));

        public void IsjunkSlapukus()
        {
            slapukai.Click();
        }
        public void PaspauskVideoMedziaga()
        {
            videoMygtukas.Click();
        }
        public void PasirinkVideo()
        {
            videoBiblioteka.Click();
        }
        public void PajudinkPeleKadAtsirastuX()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 100)");
        }
        public void UzdarykVideo()
        {
            isjunkVideo.Click();
        }
        
    }
}