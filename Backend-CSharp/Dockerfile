# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
WORKDIR /source

# copy everything and build
COPY . .

RUN dotnet restore App.Api
RUN dotnet publish App.Api --configuration release --output /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine
WORKDIR /app
COPY --from=build /app ./

# install required font
RUN apk add --no-cache font-carlito

ENV ASPNETCORE_HTTPS_PORT=443

# for local testing
# ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT [ "dotnet", "App.Api.dll" ]
