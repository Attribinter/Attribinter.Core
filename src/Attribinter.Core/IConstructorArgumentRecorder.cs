namespace Attribinter;

/// <summary>Records data about arguments of constructor parameters.</summary>
/// <typeparam name="TPayload">The type of the payload passed to the recorder, describing the arguments.</typeparam>
public interface IConstructorArgumentRecorder<in TPayload> : IArgumentRecorder<IConstructorParameter, TPayload> { }
