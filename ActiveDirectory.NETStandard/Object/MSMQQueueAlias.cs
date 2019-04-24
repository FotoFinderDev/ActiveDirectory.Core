using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Object
{
    public class MSMQQueueAlias : ActiveDirectoryObject
    {
        internal MSMQQueueAlias(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }
    }
}
