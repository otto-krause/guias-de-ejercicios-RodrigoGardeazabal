using System;
using System.Collections.Generic;
using NUnit.Framework;
using Ejercicio;
using System.Linq;
namespace Testing
{
    public class Tests
    {
        Zero zero;
        Arma SableDeLuz;
        Arma BlasterGastado;
        Arma Katana;
        Maverick Roberto;
        Maverick Carlos;
        List<Maverick> mavericks;
        [SetUp]
        public void Setup()
        {
            SableDeLuz = new Sable(100,1);
            BlasterGastado = new Blaster(300,70);
            Katana = new Sable(55,2);
            zero = new Zero(new List<Arma>{SableDeLuz,BlasterGastado,Katana});
            Roberto = new Maverick(SableDeLuz,20);
            Carlos = new Maverick(Katana,100);
            mavericks = new List<Maverick>{Roberto,Carlos};
        }

        [Test]
        public void TestElPoderDelSableDeLuzEsDe200()
        {
            Assert.AreEqual(200,SableDeLuz.poder());
        }
        [Test]
        public void TestElPoderDelBlasterGastadoEsDe230()
        {
            Assert.AreEqual(230,BlasterGastado.poder());
        }
        [Test]
        public void TestElPoderDeLaKatanaEsDe220()
        {
            Assert.AreEqual(220,Katana.poder());
        }
        [Test]
        public void TestElArmaMasPoderosaDeZeroEsElBlasterGastadoYElPoderDeZeroEs230()
        {
            Assert.AreEqual(BlasterGastado,zero.laMasPolentosa());
            Assert.AreEqual(230,zero.PoderDeZero);
        }
        [Test]
        public void TestZeroPuedeVencerARoberto()
        {
            Assert.AreEqual(true,zero.loPuedeVencer(Roberto));
        }
        [Test]
        public void TestZeroNoPuedeVencerACarlos()
        {
            Assert.AreEqual(false,zero.loPuedeVencer(Carlos));
        }
        [Test]
        public void TestZeroNoPuedeVencerALosMavericks()
        {
            Assert.AreEqual(false,zero.losPuedeVencer(mavericks));
        }
    }
}