using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Object
{
    public class UnknownObject : ActiveDirectoryObject
    {
        internal UnknownObject(DirectoryEntry directoryEntry) : 
            base(directoryEntry)
        {
        }
    }
}
