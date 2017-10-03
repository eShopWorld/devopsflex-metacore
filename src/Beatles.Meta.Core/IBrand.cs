namespace Beatles.Meta.Core
{
    /// <summary>
    /// Represents a customized version for a the specific <typeparamref name="T"/> brand.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerBrand"/> based type.</typeparam>
    public interface IBrand<out T> : ICustomizeCode<T>
        where T : IMarkerBrand
    {
    }

    /// <summary>
    /// base marker interface for brand customization
    /// 
    /// NOTE that is is pure marker interface and is not to be implemented,  <see cref="IBrand{T}"/> is the correct interface for branding purposes
    /// </summary>
    public interface IMarkerBrand
    {

    }
}
