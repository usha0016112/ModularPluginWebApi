
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ModularPluginWebApi.slnx .

COPY ModularPluginWebApi/ModularPluginWebApi.csproj ModularPluginWebApi/
COPY Plugin.Abstractions/Plugin.Abstractions.csproj Plugin.Abstractions/
COPY SamplePlugin/SamplePlugin.csproj SamplePlugin/

RUN dotnet restore ModularPluginWebApi.slnx

COPY . .
RUN dotnet publish ModularPluginWebApi/ModularPluginWebApi.csproj -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .

ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "ModularPluginWebApi.dll"]
