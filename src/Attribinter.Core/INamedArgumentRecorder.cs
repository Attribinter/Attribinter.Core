namespace Attribinter;

/// <summary>Records data about arguments of named parameters.</summary>
/// <typeparam name="TPayload">The type of the payload passed to the recorder, describing the arguments.</typeparam>
public interface INamedArgumentRecorder<in TPayload>
{
    /// <summary>Attempts to record data about an argument of a named parameter.</summary>
    /// <param name="parameterName">The name of the parameter associated with the argument.</param>
    /// <param name="payload">The payload describing the argument.</param>
    /// <returns>A <see cref="bool"/> indicating whether the data was successfully recorded.</returns>
    public abstract bool TryRecordData(string parameterName, TPayload payload);
}
