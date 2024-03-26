using DiMultipleImplementationOfSameInterface.Extensions;

var builder = WebApplication.CreateBuilder(args);

ServiceRegistration.AddDependentServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
