namespace ActiveDirectory.NETStandard.Exception
{
    public class ClientContextDoesNotInitialException : System.Exception
    {
        public ClientContextDoesNotInitialException() :
            base(@"Team: Please init your client context first. - ClientContext.Init([Path], [Username], [Password])") {
        }
    }
}
