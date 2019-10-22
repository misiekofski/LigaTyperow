FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["LigaTyperow/LigaTyperow.csproj", "LigaTyperow/"]
RUN dotnet restore "LigaTyperow/LigaTyperow.csproj"
COPY . .
WORKDIR "/src/LigaTyperow"
RUN dotnet build "LigaTyperow.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LigaTyperow.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LigaTyperow.dll"]