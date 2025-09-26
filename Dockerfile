# определяем aspnet
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

# собираем фронтенд
FROM node:22 AS client-build
WORKDIR /src
COPY ["InteractiveCv.Client/package*.json", "InteractiveCv.Client/"]
WORKDIR "/src/InteractiveCv.Client"
RUN npm install
WORKDIR /src
COPY ["InteractiveCv.Client/", "InteractiveCv.Client/"]
WORKDIR "/src/InteractiveCv.Client"
RUN npm run build

# собираем бэкэнд
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["InteractiveCv.Server/InteractiveCv.Server.csproj", "InteractiveCv.Server/"]
RUN dotnet restore "./InteractiveCv.Server/InteractiveCv.Server.csproj"
COPY ["InteractiveCv.Server/", "InteractiveCv.Server/"]
# копируем собранный фронтенд в бэк
COPY --from=client-build src/InteractiveCv.Client/dist InteractiveCv.Server/wwwroot/
WORKDIR "/src/InteractiveCv.Server"
RUN dotnet build "./InteractiveCv.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

# публикуем
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./InteractiveCv.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# запускаем
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InteractiveCv.Server.dll"]

