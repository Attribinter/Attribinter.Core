namespace Attribinter;

/// <summary>Records data about arguments of named parameters.</summary>
/// <typeparam name="TPayload">The type of the payload passed to the recorder, describing the arguments.</typeparam>
public interface INamedArgumentRecorder<in TPayload> : IArgumentRecorder<INamedParameter, TPayload> { }
