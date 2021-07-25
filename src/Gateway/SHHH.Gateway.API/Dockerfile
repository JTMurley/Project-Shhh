#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY Gateway/SHHH.Gateway.API/SHHH.Gateway.API.csproj Gateway/SHHH.Gateway.API/
RUN dotnet restore "Gateway/SHHH.Gateway.API/SHHH.Gateway.API.csproj"
COPY . .
WORKDIR "/src/Gateway/SHHH.Gateway.API"
RUN dotnet build "SHHH.Gateway.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SHHH.Gateway.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SHHH.Gateway.API.dll"]
