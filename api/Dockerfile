# Use the official .NET SDK image to build and publish the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining files and build the app
COPY . ./
RUN dotnet publish -c Release -o out

# Use the official runtime image for the final build
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose the API port
EXPOSE 8080
EXPOSE 8081

# Set the entry point
ENTRYPOINT ["dotnet", "api.dll"]
