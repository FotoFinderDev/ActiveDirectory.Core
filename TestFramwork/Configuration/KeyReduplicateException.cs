using System;

namespace ActiveDirectory.Core.TestFramework.Configuration
{
    public class KeyReduplicateException : Exception
    {
        public override string Message
        {
            get
            {
                return "The property key of configuation file is reduplicate.";
            }
        }
    }
}
