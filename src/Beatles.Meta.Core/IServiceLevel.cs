namespace Beatles.Meta.Core
{
    /// <summary>
    /// Represents a customized version for a the specific <typeparamref name="T"/> serviceLevel.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerServiceLevel"/> based type.</typeparam>
    public interface IServiceLevel<out T> : ICustomizeCode<T>
        where T : IMarkerServiceLevel
    {
    }

    /// <summary>
    /// base marker interface for service level customization
    /// 
    /// NOTE that is is pure marker interface and is not to be implemented,  <see cref="IServiceLevel{T}"/> is the correct interface for branding purposes
    /// </summary>
    public interface IMarkerServiceLevel
    {
    }
}
