ARG DOTNETVERSION="5.0"
FROM mcr.microsoft.com/dotnet/sdk:${DOTNETVERSION}

RUN apt-get update && apt-get install -y nano

WORKDIR /app
COPY . .

RUN dotnet restore XMLDevourer/XMLDevourer.csproj
RUN dotnet restore XMLDevourer.Tests/XMLDevourer.Tests.csproj
