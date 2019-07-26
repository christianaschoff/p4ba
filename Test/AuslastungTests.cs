using Xunit;
using Contract;
using Rules;

namespace Test
{
    public class AuslastungTests
    {
        [Theory]
        [InlineData(200, AUSLASTUNG.GRUEN)]
        [InlineData(199, AUSLASTUNG.GELB)]
        [InlineData(120, AUSLASTUNG.GELB)]
        [InlineData(119, AUSLASTUNG.ROT)]
        [InlineData(61, AUSLASTUNG.ROT)]
        [InlineData(60, AUSLASTUNG.ALARM)]
        [InlineData(0, AUSLASTUNG.ALARM)]
        [InlineData(-1, AUSLASTUNG.ALARM)]
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
