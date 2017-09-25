namespace Eshopworld.MetaCore
{
    /// <summary>
    ///  Represents a customized version for a the specific <typeparamref name="T" /> currency.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerCurrency" /> based type.</typeparam>
    public interface ICurrency<out T> : ICustomizeCode<T>
        where T : IMarkerCurrency
    {
    }
}
