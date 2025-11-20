var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.CloudAspireApp_ApiService>("apiservice");

builder.AddProject<Projects.CloudAspireApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
