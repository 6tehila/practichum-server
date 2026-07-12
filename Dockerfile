FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# העתקת כל המאגר בבת אחת
COPY . .

# הרצת ה-Publish על קובץ ה-Solution הראשי בגרסה 6
RUN dotnet publish "Workers management.sln" -c Release -o /app/publish /p:UseAppHost=false

# שלב הריצה - שימוש בסביבת ריצה של .NET 6
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080

# הפעלת ה-API
ENTRYPOINT ["dotnet", "Workers management.API.dll"]
