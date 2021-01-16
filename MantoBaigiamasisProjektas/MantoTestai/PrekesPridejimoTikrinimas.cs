using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class PrekesPridejimoTikrinimas : MantoBazine

    {
        private PrekiuPuslapis prekiuPuslapis;

        [SetUp]
        public void PriesTesta()
        {
            prekiuPuslapis = new PrekiuPuslapis(driver);
        }
        [Test]
        public void PridekPreke()
        {
            prekiuPuslapis.PaspauskKategorijosMygtuka();
            Thread.Sleep(2000);
            prekiuPuslapis.PaspauskTelefonaiMygtuka();
            Thread.Sleep(2000);
            prekiuPuslapis.PaspauskIphone6();
            Thread.Sleep(2000);
            prekiuPuslapis.PridekTelefonaIkrepseli();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            prekiuPuslapis.PaspauskKrepselis();
            Thread.Sleep(2000);
            prekiuPuslapis.PaspauskMygtukaIstrinti();
            Thread.Sleep(2000);
        }
    }
}