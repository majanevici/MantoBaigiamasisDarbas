using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class NotaroBuveinesTikrinimas : MantoBazine

    {
        private NotaroBuveinesPuslapis notaroBuveinesPuslapis;

        [SetUp]
        public void PriesTesta()
        {
            notaroBuveinesPuslapis = new NotaroBuveinesPuslapis(driver);
        }
        [Test]
        public void SuraskNotaroBiuraGoogle()

        {
            notaroBuveinesPuslapis.IsjunkSlapukus();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.PaspauskPaieskosLaukas();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.IveskNotara();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.PaspauskIeskoti();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.PaspauskAntNotaro();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.PalyginkArTasBiuras();
            Thread.Sleep(2000);
            notaroBuveinesPuslapis.SuraskBiuraGoogle();
            Thread.Sleep(3000);
        }
    }
}
