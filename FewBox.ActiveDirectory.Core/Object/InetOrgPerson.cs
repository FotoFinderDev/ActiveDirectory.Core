using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Object
{
    public class InetOrgPerson : ActiveDirectoryObject
    {
        internal InetOrgPerson(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
