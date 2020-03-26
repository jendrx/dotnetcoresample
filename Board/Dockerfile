#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Board/Board.csproj", "Board/"]
COPY ["UtilLib/UtilLib.csproj", "UtilLib/"]
COPY ["UtilLib.Test/UtilLib.Test.csproj", "UtilLib.Test/"]
RUN dotnet restore "Board/Board.csproj"
RUN dotnet restore ""UtilLib.Test/UtilLib.Test.csproj""
COPY . .
WORKDIR "/src/Board"
RUN dotnet build "Board.csproj" -c Release -o /app/build

FROM build as unittest
WORKDIR "/src/UtilLib.Test" 

FROM build AS publish
RUN dotnet publish "Board.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Board.dll"]