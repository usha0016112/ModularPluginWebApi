# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
<<<<<<< HEAD
WORKDIR /app

COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out
=======
WORKDIR /src

# copy only project file first
COPY ModularPluginWebApi/ModularPluginWebApi.csproj ./ModularPluginWebApi/
RUN dotnet restore ./ModularPluginWebApi/ModularPluginWebApi.csproj

# copy full code
COPY . .
WORKDIR /src/ModularPluginWebApi

RUN dotnet publish -c Release -o /app/out
>>>>>>> f52f21e (fixed dockerfile)

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /app/out .

ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

