#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Workers management.API/Workers management.API.csproj", "Workers management.API/"]
COPY ["Workers management.Service/Workers management.Service.csproj", "Workers management.Service/"]
COPY ["Workers management.Data/Workers management.Data.csproj", "Workers management.Data/"]
COPY ["Workers management.Core/Workers management.Core.csproj", "Workers management.Core/"]
RUN dotnet restore "Workers management.API/Workers management.API.csproj"
COPY . .
WORKDIR "/src/Workers management.API"
RUN dotnet build "Workers management.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Workers management.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Workers management.API.dll"]