﻿using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;
using OpenQA.Selenium;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class PrekesUzsakymoTikrinimas : MantoBazine

    {
        private PrekiuUzsakymoPuslapis prekiuUzsakymoPuslapis;

        [SetUp]
        public void PriesTesta()
        {
            prekiuUzsakymoPuslapis = new PrekiuUzsakymoPuslapis(driver);
        }
        [Test]
        public void UzsakykPrekeNesekmingai()
        {
            prekiuUzsakymoPuslapis.PaspauskKategorijosMygtuka();
            prekiuUzsakymoPuslapis.PaspauskLaptopaiMygtuka();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.PaspauskSony();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.PridekKompaIkrepseli();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.PaspauskKrepselis();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.PaspauskUzsakyti();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.NurodykVarda();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykSali();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykMiesta();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykKredinesMenesi();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykKredinesMetus();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.GalutinisPatvirtinimas();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.PaspauskCloseMygtuka();
            Thread.Sleep(2000);
        }
        [Test]
        public void UzsakykPrekeSekmingai()
        {
            prekiuUzsakymoPuslapis.PaspauskKategorijosMygtuka();
            Thread.Sleep(3000);
            prekiuUzsakymoPuslapis.PaspauskLaptopaiMygtuka();
            Thread.Sleep(3000);
            prekiuUzsakymoPuslapis.PaspauskSony();
            Thread.Sleep(3000);
            prekiuUzsakymoPuslapis.PridekKompaIkrepseli();
            Thread.Sleep(3000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
            prekiuUzsakymoPuslapis.PaspauskKrepselis();
            Thread.Sleep(3000);
            prekiuUzsakymoPuslapis.PaspauskUzsakyti();
            Thread.Sleep(3000);
            prekiuUzsakymoPuslapis.NurodykVarda();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykSali();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykMiesta();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykKredinesNr();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykKredinesMenesi();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.NurodykKredinesMetus();
            Thread.Sleep(1000);
            prekiuUzsakymoPuslapis.GalutinisPatvirtinimas();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.PalyginkArSekmingaiUzsakytaPreke();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.PaspauskCloseMygtuka();
            Thread.Sleep(2000);
            prekiuUzsakymoPuslapis.PaspauskOkMygtuka();
            Thread.Sleep(2000);
        }
    }
}