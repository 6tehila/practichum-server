FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת כל המאגר בבת אחת (שומר על מבנה התיקיות המדויק)
COPY . .

# הרצת ה-Publish ישירות על קובץ ה-Solution הראשי
# זה יבנה את כל הפרויקטים יחד וישים את התוצאה בתיקיית publish
RUN dotnet publish "Workers management.sln" -c Release -o /app/publish /p:UseAppHost=false

# שלב הריצה - משתמש רק בתוצאה המוכנה
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080

# הפעלה ישירה של ה-DLL של ה-API מתוך התיקייה המאוחדת
ENTRYPOINT ["dotnet", "Workers management.API.dll"]
