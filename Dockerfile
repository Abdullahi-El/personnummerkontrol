# Använd .NET SDK-bilden för att bygga applikationen
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Kopiera projektfiler
COPY . ./
RUN dotnet test

# Bygg projektet
RUN dotnet publish -c Release -o /app/out

# Använd en mindre runtime-bild
FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build-env /app/out ./

# Lista alla filer för att verifiera
RUN ls -la /app

# Starta applikationen
ENTRYPOINT ["dotnet", "personnumervalidation.dll"]
