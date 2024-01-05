FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY Catalog.API/Catalog.API.csproj .
RUN dotnet restore "Catalog.API/Catalog.API.csproj"

COPY Catalog.API/. .
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=base /app/publish .
ENTRYPOINT ["dotnet", "Catalog.API.dll"]