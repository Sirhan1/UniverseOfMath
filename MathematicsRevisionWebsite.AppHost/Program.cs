var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MathematicsRevisionWebsite_Server>("mathematicsrevisionwebsite-server");

builder.Build().Run();
