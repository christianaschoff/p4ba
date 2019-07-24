using System;
using Xunit;
using Contract;
using Model;
using Rules;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class AuslastungTests
    {
        [Theory]
        [InlineData(200, AUSLASTUNG.GRUEN)]
        [InlineData(120, AUSLASTUNG.GELB)]
        [InlineData(80, AUSLASTUNG.ROT)]
        [InlineData(20, AUSLASTUNG.ALARM)]
        public void BerechneAuslastungsstatus_MultipleDays_CorrectStatus(int input, AUSLASTUNG expected)
        {
            //Arrange
            IAuslastung auslastung = new Auslastung();
            
            //Act
            AUSLASTUNG result = auslastung.BerechneAuslastungsstatus(input);


            //Assert
            Assert.Equal(expected, result);
        }
    }
}
