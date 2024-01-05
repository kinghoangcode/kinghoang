FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 8081
WORKDIR /app

COPY --from=base /app/publish .
ENTRYPOINT ["dotnet", "Catalog.API.dll"]