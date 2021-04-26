ARG DOTNET-VERSION="5.0"
FROM mcr.microsoft.com/dotnet/sdk:${DOTNET-VERSION}

WORKDIR /app
COPY . .
