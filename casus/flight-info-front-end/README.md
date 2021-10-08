# FrontEnd

Deze code is gegenereerd met behulp van het `npx create-react-app --template typescript` commando. De rechten van het '
departures'-icoon behoren
tot [FlatIcon](https://www.flaticon.com/free-icon/departures_565514?term=departure&page=1&position=4&page=1&position=4&related_id=565514&origin=search)
.

Inspiratie voor de front-end is opgedaan door diverse afbeeldingen op Google te bekijken.

## Hoe start je de Front-end?

**Vereisten:**

- [NPM geïnstalleerd](https://docs.npmjs.com/downloading-and-installing-node-js-and-npm)
- Een moderne browser zoals Google Chrome, Safari, Mozilla Firefox of Microsoft Edge (oude browsers kunnen vreemde
  stijl-problemen bevatten door het gebruik van 'nieuwe' CSS-syntax.)

Om de applicatie te starten, verifieer je eerst dat de benodigde services aan staan (In elk geval de FlightService
ASP.NET applicatie). Zorg ook dat de port van de back-end goed staat in [App.tsx](./src/App.tsx).

Om de applicatie vervolgens te starten, voer je het commando `npm start` uit in de map waar ook dit bestand staat.

De applicatie opent een nieuw scherm in je standaard browser. Gebeurt dit niet, navigeer dan naar de URL die in de
console staat.

## Beschrijving van de Front-End

Deze erg simpele front-end in React is de voorkant van de demo uit de [blogpost over gRPC](../../README.md). Aan deze
applicatie hoeft in principe niets gewijzigd te worden.

De applicatie praat rechtstreeks met de FlightService. De data die hieruit terugkomt wordt naar het "Departures" bord in
de applicatie getoond.
