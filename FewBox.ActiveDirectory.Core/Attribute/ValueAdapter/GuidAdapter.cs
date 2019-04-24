using System;
using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Attribute.ValueAdapter
{
    class GuidAdapter : Adapter<Guid>
    {
        public GuidAdapter(DirectoryEntry directoryEntry, string attributeName) :
            base(directoryEntry, attributeName)
        {
        }

        protected override Guid GetAttributeValue()
        {
            if (this.ValueObject == null)
            {
                return Guid.Empty;
            }
            return new Guid((byte[])this.ValueObject);
        }
    }
}
