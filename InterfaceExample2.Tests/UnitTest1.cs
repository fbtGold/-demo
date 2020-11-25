using Xunit;
using 单元测试demo;

namespace InterfaceExample2.Tests
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var fan = new DeskFan(new PowerSupplyLowerThanZero());
            var expected = "没电";
            var actual = fan.word();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerHigherThan220_Ok()
        {
            var fan = new DeskFan(new PowerSupplyHigherThan220());
            var actual = fan.word();
            var expected = "危险";
            Assert.Equal(actual, expected);
        }
    }

    class PowerSupplyLowerThanZero:IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }

    class PowerSupplyHigherThan220 : IPowerSupply
    {
        public int GetPower()
        {
            return 220;
        }
    }
}
