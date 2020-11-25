using Xunit;
using ��Ԫ����demo;
using Moq;

namespace InterfaceExample2.Tests
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);

            //var fan = new DeskFan(new PowerSupplyLowerThanZero());
            var fan = new DeskFan(mock.Object);
            var expected = "û��";
            var actual = fan.word();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerHigherThan220_Ok()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 220);

            var fan = new DeskFan(mock.Object);
            var actual = fan.word();
            var expected = "Σ��";
            Assert.Equal(actual, expected);
        }
    }

    
}
