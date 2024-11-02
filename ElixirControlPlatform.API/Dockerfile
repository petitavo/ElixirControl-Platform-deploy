# Usa la imagen de .NET 8 para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copia el archivo de solución y restaura las dependencias
COPY ElixirControl-Platform.sln ./
COPY ElixirControlPlatform.API/*.csproj ./ElixirControlPlatform.API/

# Restaura las dependencias
RUN dotnet restore

# Copia el resto del código fuente
COPY . ./

# Publica la aplicación en modo Release
RUN dotnet publish ElixirControlPlatform.API/ElixirControlPlatform.API.csproj -c Release -o out --self-contained -r linux-x64

# Configura la imagen de producción
FROM mcr.microsoft.com/dotnet/runtime-deps:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expone el puerto que usará la aplicación
EXPOSE 80

# Comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "ElixirControlPlatform.API.dll"]
