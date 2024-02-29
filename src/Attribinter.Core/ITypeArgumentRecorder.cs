namespace Attribinter;

using Microsoft.CodeAnalysis;

/// <summary>Records data about arguments of type parameters.</summary>
/// <typeparam name="TPayload">The type of the payload passed to the recorder, describing the arguments.</typeparam>
public interface ITypeArgumentRecorder<in TPayload
{
    /// <summary>Attempts to record data about an argument of a type parameter.</summary>
    /// <param name="parameter">The type parameter associated with the argument.</param>
    /// <param name="payload">The payload describing the argument.</param>
    /// <returns>A <see cref="bool"/> indicating whether the data was successfully recorded.</returns>
    public abstract bool TryRecordData(ITypeParameterSymbol parameter, TPayload payload);
}
