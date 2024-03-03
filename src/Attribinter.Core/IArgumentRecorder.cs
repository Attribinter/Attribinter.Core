﻿namespace Attribinter;

/// <summary>Records data about arguments of parameters.</summary>
/// <typeparam name="TParameter">The type representing the parameter.</typeparam>
/// <typeparam name="TPayload">The type of the payload passed to the recorder, describing the arguments.</typeparam>
public interface IArgumentRecorder<in TParameter, in TPayload>
{
    /// <summary>Attempts to record data about an argument of a parameter.</summary>
    /// <param name="parameter">The parameter associated with the argument.</param>
    /// <param name="payload">The payload describing the argument.</param>
    /// <returns>A <see cref="bool"/> indicating whether the data was successfully recorded.</returns>
    public abstract bool TryRecordData(TParameter parameter, TPayload payload);
}
