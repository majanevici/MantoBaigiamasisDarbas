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
        public void PriesTesta()
        {
            videoPuslapis = new VideoPuslapis(driver);
        }
        [Test]
        public void ArVideoVeikia()

        {
            videoPuslapis.IsjunkSlapukus();
            Thread.Sleep(2000);
            videoPuslapis.PaspauskVideoMedziaga();
            Thread.Sleep(2000);
            videoPuslapis.PasirinkVideo();
            Thread.Sleep(10000);
            videoPuslapis.PajudinkPeleKadAtsirastuX();
            Thread.Sleep(2000);
            videoPuslapis.UzdarykVideo();
            Thread.Sleep(2000);
        }
    }
}
