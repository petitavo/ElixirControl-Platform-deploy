# Usa la imagen base del SDK de .NET 8.0
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establece el directorio de trabajo
WORKDIR /app

# Copia el archivo de proyecto y restaura las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia el resto de la aplicación
COPY . ./

# Construye el proyecto
RUN dotnet publish -c Release -o out

# Genera la imagen final con la runtime de .NET
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/out .

# Comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "TuAplicacion.dll"]
