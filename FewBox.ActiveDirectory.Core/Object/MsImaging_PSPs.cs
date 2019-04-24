using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Object
{
    public class MsImaging_PSPs : ActiveDirectoryObject
    {
        internal MsImaging_PSPs(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
