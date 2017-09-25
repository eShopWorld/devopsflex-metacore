namespace Eshopworld.MetaCore
{
    /// <summary>
    /// Represents a customized version for a the specific <typeparamref name="T" /> country.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerCountry" /> based type.</typeparam>
    internal interface ICountry<out T> : ICustomizeCode<T>
        where T : IMarkerCountry
    {
    }
}
