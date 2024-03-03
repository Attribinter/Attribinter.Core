namespace Attribinter;

/// <summary>Parses the constructor arguments of attributes.</summary>
/// <typeparam name="TData">The type of the data recorded by the provided recorders.</typeparam>
/// <typeparam name="TAttribute">The type representing the parsed attributes.</typeparam>
public interface IConstructorArgumentParser<TData, TAttribute> : IArgumentParser<IConstructorParameter, TData, TAttribute> { }
