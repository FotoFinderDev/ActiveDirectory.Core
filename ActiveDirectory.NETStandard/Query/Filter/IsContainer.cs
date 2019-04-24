using ActiveDirectory.NETStandard.Attribute;

namespace ActiveDirectory.NETStandard.Query.Filter
{
    /// <summary>
    /// Is container filter (Eg: (objectClass=container)).
    /// </summary>
    public class IsContainer : IFilter
    {
        /// <summary>
        /// Build the AD filter string (Eg: (objectClass=container)).
        /// </summary>
        /// <returns>The filter string.</returns>
        public string BuildFilter()
        {
            IFilter filter = new Is(AttributeNames.ObjectClass, ContainerAttributeValues.Container);
            return filter.BuildFilter();
        }
    }
}
