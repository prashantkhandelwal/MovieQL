using MovieQL.Query;
using MovieQL.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting();
builder.Services.AddTransient<IMoviesRepository, MoviesRepository>();
builder.Services.AddGraphQLServer()
    .AddQueryType<MoviesQuery>()
    .AddMongoDbProjections();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Do something when debugging.
}


app.UseRouting();

app.MapGraphQL();

app.UseEndpoints(endpoints => endpoints.MapGraphQL("/"));
app.MapGet("/", () => "Hello World!");

app.Run();
