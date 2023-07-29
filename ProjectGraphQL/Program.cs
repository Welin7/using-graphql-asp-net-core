using ProjectGraphQL.Mutation;
using ProjectGraphQL.Query;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<QueryMusicCollection>()
    .AddMutationType<MutationMusicCollection>();

var app = builder.Build();

app.MapGraphQL(path: "/");

app.Run();
