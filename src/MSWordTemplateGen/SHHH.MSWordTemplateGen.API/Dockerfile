#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY MSWordTemplateGen/SHHH.MSWordTemplateGen.API/SHHH.MSWordTemplateGen.API.csproj MSWordTemplateGen/SHHH.MSWordTemplateGen.API/
RUN dotnet restore "MSWordTemplateGen/SHHH.MSWordTemplateGen.API/SHHH.MSWordTemplateGen.API.csproj"
COPY . .
WORKDIR "/src/MSWordTemplateGen/SHHH.MSWordTemplateGen.API"
RUN dotnet build "SHHH.MSWordTemplateGen.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SHHH.MSWordTemplateGen.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SHHH.MSWordTemplateGen.API.dll"]
