namespace Attribinter;

/// <summary>Records data about arguments of type parameters.</summary>
/// <typeparam name="TPayload">The type of the payload passed to the recorder, describing the arguments.</typeparam>
public interface ITypeArgumentRecorder<in TPayload> : IArgumentRecorder<ITypeParameter, TPayload> { }
