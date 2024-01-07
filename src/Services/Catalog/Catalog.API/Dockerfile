FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
EXPOSE 8080

COPY Catalog.API.csproj .
RUN dotnet restore "Catalog.API"

COPY . .
RUN dotnet publish -c Release -o /app/catalog

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=base /app/catalog .
ENTRYPOINT ["dotnet", "Catalog.API.dll"]