# Multi-stage build for Production
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM node:22 AS client-build
WORKDIR /src
# Копируем только package файлы для лучшего кэширования
COPY ["InteractiveCv.Client/package*.json", "InteractiveCv.Client/"]
#COPY ["InteractiveCv.Client/package.json", "InteractiveCv.Client/package-lock.json*", "InteractiveCv.Client/"]
WORKDIR "/src/InteractiveCv.Client"
RUN npm install
WORKDIR /src
COPY ["InteractiveCv.Client/", "InteractiveCv.Client/"]
WORKDIR "/src/InteractiveCv.Client"
RUN npm run build

# Этот этап используется для сборки проекта службы
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Копируем собранный фронтенд
#RUN rm -rf /src/InteractiveCv.Server/wwwroot && mkdir -p /src/InteractiveCv.Server/wwwroot
#COPY --from=client-build /src/InteractiveCv.Client/dist ./InteractiveCv.Server/wwwroot/

COPY ["InteractiveCv.Server/InteractiveCv.Server.csproj", "InteractiveCv.Server/"]
RUN dotnet restore "./InteractiveCv.Server/InteractiveCv.Server.csproj"
COPY ["InteractiveCv.Server/", "InteractiveCv.Server/"]
COPY --from=client-build src/InteractiveCv.Client/dist InteractiveCv.Server/wwwroot/
WORKDIR "/src/InteractiveCv.Server"
RUN dotnet build "./InteractiveCv.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Этот этап используется для публикации проекта службы, который будет скопирован на последний этап
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./InteractiveCv.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Этот этап используется в рабочей среде или при запуске из VS в обычном режиме (по умолчанию, когда конфигурация отладки не используется)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InteractiveCv.Server.dll"]

