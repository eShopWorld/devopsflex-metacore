namespace Beatles.Meta.Core
{
    /// <summary>
    ///  Represents a customized version for a the specific <typeparamref name="T" /> currency.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerCurrency" /> based type.</typeparam>
    public interface ICurrency<out T> : ICustomizeCode<T>
        where T : IMarkerCurrency
    {
    }

    /// <summary>
    /// base marker interface for currency customization
    /// 
    /// NOTE that is is pure marker interface and is not to be implemented,  <see cref="ICurrency{T}"/> is the correct interface for branding purposes
    /// </summary>
    public interface IMarkerCurrency
    {
    }
}
