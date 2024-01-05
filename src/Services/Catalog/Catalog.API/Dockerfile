FROM mcr.microsoft.com/dotnet/sdk:8.0-jammy AS base
WORKDIR /app

COPY Catalog.API.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish --no-restore -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0-jammy
WORKDIR /app

COPY --from=base /app/publish .
ENTRYPOINT ["./Catalog.API"]