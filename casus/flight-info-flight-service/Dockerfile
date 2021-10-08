FROM mcr.microsoft.com/dotnet/sdk:5.0 AS publish

WORKDIR /src

COPY *.csproj .
RUN dotnet restore

COPY . .

RUN dotnet build -c Release -o /app/build

RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
RUN ["apt", "update"]
RUN ["apt", "upgrade", "-y"]

WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 80
ENV ASPNETCORE_URLS=http://*:80
ENTRYPOINT ["./FlightService"]
