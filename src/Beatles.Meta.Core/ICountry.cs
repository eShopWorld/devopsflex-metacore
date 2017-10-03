namespace Beatles.Meta.Core
{
    /// <summary>
    /// Represents a customized version for a the specific <typeparamref name="T" /> country.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerCountry" /> based type.</typeparam>
    internal interface ICountry<out T> : ICustomizeCode<T>
        where T : IMarkerCountry
    {
    }

    /// <summary>
    /// base marker interface for country customization
    /// 
    /// NOTE that is is pure marker interface and is not to be implemented,  <see cref="ICountry{T}"/> is the correct interface for branding purposes
    /// </summary>
    public interface IMarkerCountry
    {
    }
}
