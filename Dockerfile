# שלב הבנייה משתמש ב-SDK 8 כדי למנוע קריסות ארכיטקטורה ב-Render
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת כל המאגר
COPY . .

# הרצת ה-Publish דרך ה-SDK החדש עם הגדרת טרגט מפורשת ל-.NET 6
RUN dotnet publish "Workers management.sln" -c Release -o /app/publish /p:UseAppHost=false -f net6.0

# שלב הריצה משתמש ב-.NET 6 בדיוק כפי שהפרויקט דורש
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080

# הפעלת ה-API
ENTRYPOINT ["dotnet", "Workers management.API.dll"]
