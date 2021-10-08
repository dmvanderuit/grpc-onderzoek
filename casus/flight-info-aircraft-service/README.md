# AircraftService

## Hoe start je de AircraftService?

**Vereisten:**

- [NPM geïnstalleerd](https://docs.npmjs.com/downloading-and-installing-node-js-and-npm)
- Zowel Typescript als Nodemon globaal geïnstalleerd (`npm i --save-dev ts-node nodemon`)
- [Docker](https://docs.docker.com/get-docker/) geïnstalleerd
- [Docker Compose](https://docs.docker.com/compose/install/) geïnstalleerd

Start eerst de benodigde afhankelijkheden van de applicatie op. Dit is in ieder geval
het [docker-compose](../docker-compose.yml) bestand, door `docker-compose up -d` uit te voeren in de 'casus'-map.

Deze applicatie is geschreven in Typescript om te zorgen voor type-safety. Na de vereiste afhankelijkheden geïnstalleerd te hebben, start je de applicatie door `nodemon src/index.ts` uit te voeren in de map waar ook dit bestand staat.

## Beschrijving van de AircraftService

De AircraftService is een simpele Typescript applicatie die wordt gebruikt als voorbeeld bij
de [blogpost over gRPC](../../README.md).

Het uiteindelijke doel van deze applicatie, is om de Aircraft-data te versturen naar services die dit nodig hebben, zoals bijvoorbeeld de FlightService.

