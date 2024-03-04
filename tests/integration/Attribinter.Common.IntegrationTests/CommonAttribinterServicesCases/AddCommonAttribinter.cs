﻿namespace Attribinter.Semantic.CommonAttribinterServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

using System;

using Xunit;

public sealed class AddCommonAttribinter
{
    private static IServiceCollection Target(IServiceCollection services) => CommonAttribinterServices.AddCommonAttribinter(services);

    private readonly IServiceProvider ServiceProvider;

    public AddCommonAttribinter()
    {
        HostBuilder host = new();

        host.ConfigureServices(static (services) => Target(services));

        ServiceProvider = host.Build().Services;
    }

    [Fact]
    public void NullServiceCollection_ArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidServiceCollection_ReturnsSameServiceCollection()
    {
        var serviceCollection = Mock.Of<IServiceCollection>();

        var actual = Target(serviceCollection);

        Assert.Same(serviceCollection, actual);
    }

    [Fact]
    public void ITypeParameterFactory_ServiceCanBeResolved() => ServiceCanBeResolved<ITypeParameterFactory>();

    [Fact]
    public void IConstructorParameterFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IConstructorParameterFactory>();

    [Fact]
    public void INamedParameterFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INamedParameterFactory>();

    [AssertionMethod]
    private void ServiceCanBeResolved<TService>() where TService : notnull
    {
        var service = ServiceProvider.GetRequiredService<TService>();

        Assert.NotNull(service);
    }
}
