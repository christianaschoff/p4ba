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
            IMitarbeiter mitarbeiterStub = new Mitarbeiter(null, null, 0, 1000, null, 0, ABTEILUNG.HR, LEVEL.MANAGER);
            IKostenrechner kostenrechner = new Kostenrechner();

            //Act
            double result = kostenrechner.BerechneJahresgehalt(mitarbeiterStub);


            //Assert
            Assert.Equal(12000, result);
        }

        [Fact]
        public void BerechneJahresgehalt_nullObject_throwsException()
        {
            IMitarbeiter mitarbeiterStub = null;
            IKostenrechner kostenrechner = new Kostenrechner();

            Action action = () => kostenrechner.BerechneJahresgehalt(mitarbeiterStub);

            Assert.Throws<NullReferenceException>(action);
        }
    }
}
