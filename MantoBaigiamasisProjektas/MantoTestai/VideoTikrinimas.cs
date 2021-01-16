using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;
using OpenQA.Selenium;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class VideoTikrinimas : MantoBazine

    {
        private VideoPuslapis videoPuslapis;

        [SetUp]
        public void PaleiskVideo()
        {
            videoPuslapis = new VideoPuslapis(driver);
        }
        [Test]
        public void ArVideoVeikia()

        {
            videoPuslapis.PaspauskVideoMedziaga();
            Thread.Sleep(2000);
            videoPuslapis.PasirinkVideo();
            Thread.Sleep(10000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 100)");
            Thread.Sleep(1000);
            videoPuslapis.UzdarykVideo();
            Thread.Sleep(5000);
        }
    }
}
