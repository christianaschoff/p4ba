using System;
using Xunit;
using Contract;
using Model;
using Rules;

namespace Test
{
    public class KostenrechnerTests
    {
        [Fact]
        public void BerechneJahresgehalt_1000_12000()
        {
            //Arrange
            IMitarbeiter mitarbeiterStub = ErstelleMitarbeiter(1000);
            IKostenrechner kostenrechner = new Kostenrechner();

            //Act
            double result = kostenrechner.BerechneJahresgehalt(mitarbeiterStub);


            //Assert
            Assert.Equal(12000, result);
        }

        [Fact]
        public void BerechneJahresgehalt_0_0()
        {
            //Arrange
            IMitarbeiter mitarbeiterStub = ErstelleMitarbeiter(0);
            IKostenrechner kostenrechner = new Kostenrechner();

            //Act
            double result = kostenrechner.BerechneJahresgehalt(mitarbeiterStub);


            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void BerechneJahresgehalt_nullObject_throwsException()
        {
            IMitarbeiter mitarbeiterStub = null;
            IKostenrechner kostenrechner = new Kostenrechner();

            Action action = () => kostenrechner.BerechneJahresgehalt(mitarbeiterStub);

            Assert.Throws<NullReferenceException>(action);
        }

        [Fact]
        public void BerechneJahresgehalt_negative_throwsException()
        {
            //Arrange
            IMitarbeiter mitarbeiterStub = ErstelleMitarbeiter(-1);
            IKostenrechner kostenrechner = new Kostenrechner();

            //Act
            Action action = () => kostenrechner.BerechneJahresgehalt(mitarbeiterStub);


            //Assert
            Exception exception = Assert.Throws<ArgumentOutOfRangeException>(action);

            Assert.Contains("Das Gehalt darf nicht negativ sein", exception.Message);
        }   
        
        private IMitarbeiter ErstelleMitarbeiter(double gehalt)
        {
            return new Mitarbeiter(null, null, 0, gehalt, null, 0, ABTEILUNG.HR, LEVEL.MANAGER);
        }


        //Stub sample with private class 
        class MitarbeiterStub : IMitarbeiter
        {
            public int Betriebszugehoerigkeit { get; }
            public ABTEILUNG Abteilung { get; }
            public LEVEL Level { get; }
            public string Vorname { get; }
            public string Nachname { get; }
            public int Alter { get; }
            public double Gehalt { get; }
            public string Standort { get; }
            public MitarbeiterStub(int gehalt)
            {   
                this.Gehalt = gehalt;
            }
        }
        
        [Fact]
        public void BerechneJahresgehalt_1500_18000()
        {
            //Arrange
            IMitarbeiter mitarbeiterStub = new MitarbeiterStub(1500);
            IKostenrechner kostenrechner = new Kostenrechner();

            //Act
            double result = kostenrechner.BerechneJahresgehalt(mitarbeiterStub);


            //Assert
            Assert.Equal(18000, result);
        }
    }
}
