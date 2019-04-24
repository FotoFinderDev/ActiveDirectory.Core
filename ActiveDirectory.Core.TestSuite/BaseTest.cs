using ActiveDirectory.NETStandard.Authentication;
using ActiveDirectory.Core.TestFramework.Configuration;
using NUnit.Framework;

namespace ActiveDirectory.NETStandard.TestSuite
{
    [TestFixture]
    abstract class BaseTest
    {
        [SetUp]
        public void SetUp() {
            ClientContext.Init(TF.PS["ClientPath"],
                TF.PS["ClientUserName"],
                TF.PS["ClientPassword"]);
        }
    }
}
