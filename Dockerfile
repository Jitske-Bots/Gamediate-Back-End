#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Gamediate-back-end/Gamediate-back-end.csproj", "Gamediate-back-end/"]
RUN dotnet restore "Gamediate-back-end/Gamediate-back-end.csproj"
COPY . .
WORKDIR "/src/Gamediate-back-end"
RUN dotnet build "Gamediate-back-end.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gamediate-back-end.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gamediate-back-end.dll"]