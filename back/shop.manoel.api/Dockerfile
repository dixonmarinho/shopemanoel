# Estágio de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar arquivos de projeto e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar o restante dos arquivos e compilar a aplicação
COPY . ./
RUN dotnet publish -c Release -o /out

# Estágio de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out .

# Expor a porta 80 para acessar o serviço
EXPOSE 80

# Comando para iniciar a aplicação
ENTRYPOINT ["dotnet", "shop.manoel.api.dll"]