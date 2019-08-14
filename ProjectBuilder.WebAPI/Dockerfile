FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ProjectBuilder.WebAPI/ProjectBuilder.WebAPI.csproj", "ProjectBuilder.WebAPI/"]
COPY ["ProjectBuilder.Infa.IoC/ProjectBuilder.Infa.IoC.csproj", "ProjectBuilder.Infa.IoC/"]
COPY ["ProjectBulder.Infa.Data/ProjectBulder.Infa.Data.csproj", "ProjectBulder.Infa.Data/"]
COPY ["ProjectBuilder.Domain/ProjectBuilder.Domain.csproj", "ProjectBuilder.Domain/"]
COPY ["ProjectBuilder.Application/ProjectBuilder.Application.csproj", "ProjectBuilder.Application/"]
RUN dotnet restore "ProjectBuilder.WebAPI/ProjectBuilder.WebAPI.csproj"
COPY . .
WORKDIR "/src/ProjectBuilder.WebAPI"
RUN dotnet build "ProjectBuilder.WebAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ProjectBuilder.WebAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProjectBuilder.WebAPI.dll"]