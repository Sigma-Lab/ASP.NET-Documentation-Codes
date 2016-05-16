/// Looking at each method in the Startup class in the order in which they are called, the following services may be requested as [params]

/// Startup Constructor - IApplicationEnvironment, IHostingEnvironment, ILoggerFactory
/// ConfigureServices - IServiceCollection
/// Configure - IApplicationBuilder, IApplicationEnvironment, IHostingEnvironment, ILoggerFactory