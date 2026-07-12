FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת כל הקבצים
COPY . .

# הרצת ה-Restore על קובץ ה-sln הראשי
RUN dotnet restore "Workers management.sln"

# בנייה ופרסום של פרויקט ה-API הספציפי
RUN dotnet publish "Workers management.API/Workers management.API.csproj" -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
EXPOSE 8080
ENTRYPOINT ["dotnet", "Workers management.API.dll"]
