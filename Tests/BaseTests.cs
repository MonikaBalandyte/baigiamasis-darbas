
using Framework;
using NUnit.Framework;

namespace Tests
{
    internal class BaseTests
    {
        [SetUp]

        public void SetUp()
        {
            Driver.SetupDriver();
        }

        [TearDown]

        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
