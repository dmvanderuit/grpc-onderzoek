# FlightService

Deze code is gegenereerd met behulp van de Jetbrains Rider Project Generator.

## Hoe start je de FlightService?

**Vereisten:**

- [Dotnet 5](https://dotnet.microsoft.com/download) geïnstalleerd
- [Docker](https://docs.docker.com/get-docker/) geïnstalleerd
- [Docker Compose](https://docs.docker.com/compose/install/) geïnstalleerd

Start eerst de benodigde afhankelijkheden van de applicatie op. Dit is in ieder geval
het [docker-compose](../docker-compose.yml) bestand, door `docker-compose up -d` uit te voeren in de 'casus'-map.

### Starten met een IDE

Om de applicatie in je favoriete IDE (Rider, Visual Studio, et cetera). Build het project en start het.

### Starten via de commandline

Navigeer in je terminal naar deze map. Voer het volgende commando uit: `dotnet restore`. Dit installeert de benodigde
dependencies.

Voer nu het commando `dotnet run` uit.

## Beschrijving van de FlightService

De FlightService is een simpele ASP.NET Core 5 Web API die wordt gebruikt als voorbeeld bij
de [blogpost over gRPC](../../README.md).

Het uiteindelijke doel van deze applicatie, is om binnenkomende requests af te handelen. Eerst zal de 'Aircraft'-data
opgehaald worden bij de desbetreffende service, doormiddel van een RPC. Daarnaast zal de data uit de eigen database
opgehaald worden. Tot slot worden deze twee met elkaar gecombineerd en wordt het gewenste resultaat teruggegeven.

