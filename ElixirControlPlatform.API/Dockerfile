# Usa la imagen del SDK de .NET 6.0 para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copia el archivo de solución y los proyectos necesarios
COPY ElixirControl-Platform.sln ./
COPY ElixirControlPlatform.API/*.csproj ./ElixirControlPlatform.API/

# Restaura las dependencias para que sean compatibles con .NET 6.0
RUN dotnet restore

# Copia el resto del código fuente
COPY . ./

# Publica la aplicación en modo Release
RUN dotnet publish ElixirControlPlatform.API/ElixirControlPlatform.API.csproj -c Release -o out

# Configura la imagen de producción
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expone el puerto que usará la aplicación
EXPOSE 80

# Comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "ElixirControlPlatform.API.dll"]
