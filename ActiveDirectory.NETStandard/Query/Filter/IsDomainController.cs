using ActiveDirectory.NETStandard.Attribute;

namespace ActiveDirectory.NETStandard.Query.Filter
{
    /// <summary>
    /// Is domain filter (Eg: (objectClass=domainDNS)).
    /// </summary>
    public class IsDomainController : IFilter
    {
        /// <summary>
        /// Build the AD filter string (Eg: (objectClass=domainDNS)).
        /// </summary>
        /// <returns>The filter string.</returns>
        public string BuildFilter()
        {
            IFilter filter = new Is(AttributeNames.ObjectClass, DomainControllerAttributeValues.DomainDNS);
            return filter.BuildFilter();
        }
    }
}
