using NUnit.Framework;
using AutoPaskaitos.MantoBaigiamasisProjektas.Testai;
using AutoPaskaitos.MantoBaigiamasisProjektas.MantoPuslapiai;
using System.Threading;

namespace MantoBaigiamasisProjektas.MantoTestai
{
    class KalbosKeitimas : MantoBazine

    {
        private KalbosPuslapis kalbosPuslapis;

        [SetUp]
        public void PakeiskKalba()
        {
            kalbosPuslapis = new KalbosPuslapis(driver);
        }
        [Test]
        public void PakeiskKalbaIAnglu()

        {
            kalbosPuslapis.IsskleiskKalbas();
            Thread.Sleep(2000);
            kalbosPuslapis.PasirinkKalba();
            Thread.Sleep(2000);
            kalbosPuslapis.PalyginkKalba();
            Thread.Sleep(2000);
        }
    }
}
