namespace Eshopworld.MetaCore
{
    /// <summary>
    /// Represents a customized version for a the specific <typeparamref name="T"/> serviceLevel.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerServiceLevel"/> based type.</typeparam>
    public interface IServiceLevel<out T> : ICustomizeCode<T>
        where T : IMarkerServiceLevel
    {
    }
}
