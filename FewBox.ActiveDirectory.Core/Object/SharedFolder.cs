using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Object
{
    public class SharedFolder : ActiveDirectoryObject
    {
        internal SharedFolder(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
