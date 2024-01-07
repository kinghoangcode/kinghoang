FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
EXPOSE 8081

COPY Order.API.csproj .
RUN dotnet restore ./Order.API.sln

COPY . .
RUN dotnet publish -c Release -o /app/order

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=base /app/order .
ENTRYPOINT ["dotnet", "Order.API.dll"]