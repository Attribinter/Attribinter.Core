namespace Attribinter;

/// <summary>Parses the named arguments of attributes.</summary>
/// <typeparam name="TData">The type of the data recorded by the provided recorders.</typeparam>
/// <typeparam name="TAttribute">The type representing the parsed attributes.</typeparam>
public interface INamedArgumentParser<TData, TAttribute> : IArgumentParser<INamedParameter, TData, TAttribute> { }
