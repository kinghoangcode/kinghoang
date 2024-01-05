FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app

COPY Catalog.API.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=base /app .
ENTRYPOINT ["./Catalog.API"]