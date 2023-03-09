##### Build stage #####
FROM mcr.microsoft.com/dotnet/sdk:6.0-jammy-amd64 as build
COPY /FoodManagerApi/. ./
WORKDIR /FoodManagerApi
RUN dotnet restore
RUN dotnet build -o /app
RUN dotnet publish -o /publish


##### Ready to start app #####
FROM mcr.microsoft.com/dotnet/aspnet:6.0-jammy-amd64
COPY --from=build  /publish /app
WORKDIR /app
EXPOSE 1234
CMD ["./FoodManagerApi"]
