namespace Eshopworld.Meta.Core
{
    /// <summary>
    /// Represents a customized version for a the specific <typeparamref name="T"/> brand.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerTenant"/> based type.</typeparam>
    public interface ITenant<out T> : ICustomizeCode<T>
        where T : IMarkerTenant
    {
    }

    /// <summary>
    /// Base marker interface for brand customization
    /// </summary>
    /// <remarks>
    /// This is a pure marker interface and is not meant to be implemented, <see cref="ITenant{T}"/> is the correct interface for customizing tenant code.
    /// </remarks>
    public interface IMarkerTenant
    {
    }
}
