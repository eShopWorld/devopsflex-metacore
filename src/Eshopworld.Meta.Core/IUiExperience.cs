namespace Eshopworld.Meta.Core
{
    /// <summary>
    /// Represents a customized version for a the specific <typeparamref name="T"/> ui experience.
    /// </summary>
    /// <typeparam name="T">The specific <see cref="IMarkerTenant"/> based type.</typeparam>
    public interface IUiExperience<out T> : ICustomizeCode<T>
        where T : IMarkerUiExperience
    {
    }

    /// <summary>
    /// Base marker interface for ui experience customization
    /// </summary>
    /// <remarks>
    /// This is a pure marker interface and is not meant to be implemented, <see cref="IUiExperience{T}"/> is the correct interface for customizing ui experience code.
    /// </remarks>
    public interface IMarkerUiExperience
    {
    }
}
