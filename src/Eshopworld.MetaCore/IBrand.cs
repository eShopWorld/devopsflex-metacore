namespace Eshopworld.MetaCore
{
    /// <summary>
    /// Represents a customized version for a the specific <typeparamref name="T"/> brand.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerBrand"/> based type.</typeparam>
    public interface IBrand<out T> : ICustomizeCode<T>
        where T : IMarkerBrand
    {
    }
}
