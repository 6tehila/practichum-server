FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת קובץ ה-Solution וכל תיקיות הפרויקטים
COPY ["Workers management.sln", "./"]
COPY ["Workers management.API/Workers management.API.csproj", "Workers management.API/"]
COPY ["Workers management.Core/Workers management.Core.csproj", "Workers management.Core/"]
COPY ["Workers management.Data/Workers management.Data.csproj", "Workers management.Data/"]
COPY ["Workers management.Service/Workers management.Service.csproj", "Workers management.Service/"]

# הרצת שחזור תלויות לכל הפרויקטים יחד
RUN dotnet restore "Workers management.sln"

# העתקת שאר קבצי הקוד של כל המערכת
COPY . .

# בנייה ופרסום ישירות מתוך תיקיית ה-API
WORKDIR "/src/Workers management.API"
RUN dotnet publish "Workers management.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# שלב הריצה
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "Workers management.API.dll"]
