ARG DOTNETVERSION="5.0"
FROM mcr.microsoft.com/dotnet/sdk:${DOTNETVERSION}

LABEL org.opencontainers.image.title="XMLDevourer development container"
LABEL org.opencontainers.image.source=https://github.com/CrazySailing/XMLDevourer

RUN apt-get update && apt-get install -y nano

WORKDIR /app
COPY . .

RUN dotnet restore XMLDevourer/XMLDevourer.csproj
RUN dotnet restore XMLDevourer.Tests/XMLDevourer.Tests.csproj
