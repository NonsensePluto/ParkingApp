using ParkingAppSolution.Service.IoC;

var builder = WebApplication.CreateBuilder(args);

SerilogConfigurator.ConfigureServices(builder);
SwaggerConfigurator.ConfigureServices(builder.Services);
DbContextConfigurator.ConfigureServices(builder);

var app = builder.Build();

SerilogConfigurator.ConfigureApplication(app);
SwaggerConfigurator.ConfigureApplication(app);
DbContextConfigurator.ConfigureApplication(app);

app.Run();