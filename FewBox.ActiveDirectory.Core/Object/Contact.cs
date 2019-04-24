using ActiveDirectory.NETStandard.Attribute;
using ActiveDirectory.NETStandard.Attribute.ValueAdapter;
using ActiveDirectory.NETStandard.Query;
using ActiveDirectory.NETStandard.Query.Filter;
using System.Collections.Generic;
using System.DirectoryServices;

namespace ActiveDirectory.NETStandard.Object
{
    public class Contact : PersonObject
    {
        internal Contact(DirectoryEntry directoryEntry) :
            base(directoryEntry)
        {
        }

        /// <summary>
        /// Find one contact object by common name.
        /// </summary>
        /// <param name="cn">The common name.</param>
        /// <returns>One contact object.</returns>
        public static Contact FindOneByCN(string cn)
        {
            return FindOne(new Is(AttributeNames.CN, cn));
        }

        /// <summary>
        /// Find all contact directory entry by filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>All contact directory entry by filter.</returns>
        public static new IList<Contact> FindAll(IFilter filter)
        {
            return ActiveDirectoryQuery.FindAllByFilter<Contact>(new And(new IsContact(), filter));
        }

        /// <summary>
        /// Find one contact directory entry by filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>All contact directory entry by filter.</returns>
        public static new Contact FindOne(IFilter filter)
        {
            return ActiveDirectoryQuery.FindOneByFilter<Contact>(new And(new IsContact(), filter));
        }
    }
}
