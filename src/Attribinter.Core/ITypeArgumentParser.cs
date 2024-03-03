namespace Attribinter;

/// <summary>Parses the type arguments of attributes.</summary>
/// <typeparam name="TData">The type of the data recorded by the provided recorders.</typeparam>
/// <typeparam name="TAttribute">The type representing the parsed attributes.</typeparam>
public interface ITypeArgumentParser<TData, TAttribute> : IArgumentParser<ITypeParameter, TData, TAttribute> { }
