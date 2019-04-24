using ActiveDirectory.NETStandard.Authentication;
using ActiveDirectory.Core.TestFramework.Configuration;
using NUnit.Framework;

namespace ActiveDirectory.NETStandard.TestSuite.Init
{
    [TestFixture]
    class AuthenticationTest
    {
        [TestCase]
        public void TestConnection() {
            ClientContext.Init(TF.PS["ClientPath"],
                TF.PS["ClientUserName"], 
                TF.PS["ClientPassword"]);
        }
    }
}
