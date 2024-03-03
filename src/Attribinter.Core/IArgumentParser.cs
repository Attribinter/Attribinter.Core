namespace Attribinter;

/// <summary>Parses arguments of attributes.</summary>
/// <typeparam name="TParameter">The type of the parameter associated with the parsed arguments.</typeparam>
/// <typeparam name="TData">The type of the data recorded by the provided recorders.</typeparam>
/// <typeparam name="TAttribute">The type representing the parsed attributes.</typeparam>
public interface IArgumentParser<TParameter, TData, TAttribute>
{
    /// <summary>Attempts to parse some arguments of an attribute.</summary>
    /// <param name="recorder">Records the parsed arguments.</param>
    /// <param name="attribute">The parsed attribute.</param>
    /// <returns>A <see cref="bool"/> indicating whether the attempt was successful.</returns>
    public abstract bool TryParse(IArgumentRecorder<TParameter, TData> recorder, TAttribute attribute);
}
