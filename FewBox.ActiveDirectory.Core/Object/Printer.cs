using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Object
{
    public class Printer : ActiveDirectoryObject
    {
        internal Printer(DirectoryEntry directoryEntry) : base(directoryEntry)
        {
        }
    }
}
