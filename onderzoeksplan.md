# Inleiding

Dit document beschrijft het onderzoeksplan. Allereerst het onderwerp, scenario en de hoofd- en deelvragen. Daarna de onderzoeksmethoden. Tot slot een grove planning over het te realiseren rapport.

- [Inleiding](#inleiding)
- [Onderwerp](#onderwerp)
- [Scenario](#scenario)
- [Hoofd- en Deelvragen](#hoofd--en-deelvragen)
  - [Onderzoeksmethoden bij deelvragen](#onderzoeksmethoden-bij-deelvragen)
- [Toepassing op Pitstop](#toepassing-op-pitstop)
- [Literatuurlijst](#literatuurlijst)

# Onderwerp

In dit onderzoeksrapport wordt het onderwerp [gRPC](https://grpc.io) behandeld. Dit onderwerp is al eerder in mijn (part-time) loopbaan naar voren gekomen en leek mij toen al erg interessant. In verband met andere prioriteiten heb ik in die opdracht niet veel gewerkt met gRPC.

Ook tijdens een gastcollege van InfoSupport kwam de techniek aan bod. Tijdens deze les heb ik de inspiratie gekregen om daadwerkelijk iets met de techniek te willen gaan doen. Een onderzoek naar de techniek is dus een prima aansluiting op een eventuele opdracht in de toekomst, waarbij ik gRPC toe kan passen.

# Scenario

In eerste instantie wilde ik gRPC gebruiken als 'failsafe' methode, die in het geval dat een broker als RabbitMQ faalde, de communicatie tussen twee microservices overnam. 
Toen ik dit plan aan de docent voorstelde, merkte hij terecht op dat gRPC en RabbitMQ allebei op het RPC principe draaien. Een logische oorzaak van een falende message broker, is in eerste instantie het RPC protocol dat niet meer bereikbaar is. In een dergelijke situatie is gRPC uiteraard ook niet meer bereikbaar.

De docent gaf aan dat het wellicht een goed idee was om de reeds bestaande [Pitstop](https://github.com/EdwinVW/pitstop/tree/master/src) applicatie van Edwin van Wijk te herschrijven zodat het gebruik maakt van gRPC. Gezien het feit de blogpost gelezen moet kunnen worden door een nieuwkomer in de minor waarin dit onderzoek is uitgevoerd, denk ik dat een applicatie van dergelijke omvang het onderzoek negatief beïnvloedt. De Pitstop applicatie is uitstekend als het gaat om Microservices, maar erg groot om te gebruiken als voorbeeld. Ook worden er veel verschillende (complexe) technieken gebruikt. Daarom is besloten een eigen casus te gebruiken.

In de casus waar mee gewerkt zal worden, is dezelfde architectuur als in Pitstop toegepast, maar dan in het klein. De applicatie omvat een front-end die niets anders doet dan data tonen. Daarnaast bevat de applicatie twee microservices, die uiteindelijk met elkaar in verbinding gesteld worden met behulp van gRPC en data uit zullen wisselen.
Deze oplossing wordt in het onderzoek meegeleverd als out-of-the-box werkend product. De lezer van het onderzoek hoeft de repository enkel te clonen en doormiddel van docker-compose de applicatie op te starten. 

![Figuur 1](./assets/GRPC-gRPC%20Scenario.svg)
*Figuur 1* - Overzicht scenario

In figuur 1 is de uiteindelijke situatie geschetst, waar in de blogpost naartoe wordt gewerkt. Zoals te zien is, worden de twee microservices met behulp van gRPC aan elkaar gekoppeld.

# Hoofd- en Deelvragen

De hoofdvraag in dit onderzoek sluit aan op het scenario dat gebruikt is om een situatie te illustreren waarin gRPC mogelijk van pas komt: "Hoe kan gRPC toegepast worden in een microservice architectuur?".

Om deze hoofdvraag te beantwoorden in kleine delen, zijn er deelvragen opgesteld waarmee stapsgewijs naar een antwoord op de hoofdvraag gewerkt wordt. Hieronder zijn de deelvragen beschreven:

1. "Wat is gRPC?"
In dit eerste hoofdstuk wordt gekeken naar de achterliggende gedachte van de technologie. Door wie is het gemaakt en met welke bedoeling is de techniek op de markt gebracht? Na het behandelen van deze vraag is het vereiste niveau bereikt die nodig is om de volgende vragen en voorbeelden te beantwoorden.

2. "Wat is het verschil tussen gRPC, REST en RabbitMQ?"
Bij de tweede deelvraag wordt het verschil tussen gRPC en RabbitMQ behandeld. Na het beantwoorden van deze deelvraag, kan de lezer een mening vormen over welk van de twee tools het beste zijn voor het probleem waar zij mee werken. Daarnaast schetst het antwoord op deze vraag een goed beeld van wat er gedaan moet worden om microservices met elkaar in verbinding te stellen met behulp van gRPC.

3. "Hoe kunnen twee microservices in verbinding worden gesteld met behulp van gRPC?"
In deze vraag staat het gebruik van de technologie centraal. Hoe wordt gRPC precies gebruikt en hoe implementeren twee verschillende programmeertalen (het Polyglot X principe) de gRPC libraries om met elkaar te communiceren?

Wanneer deze drie deelvragen beantwoord zijn, kan een algemene conclusie worden gevormd over de wijze waarop gRPC kan worden gebruikt in een microservice architectuur zoals de voorbeeldcasus.

Vanwege het feit dat het lastig is om gRPC uit te leggen zonder voorbeeld, denk ik dat het goed is om een casus te gebruiken die tot de verbeelding spreekt. Dit brengt echter wel het nadeel met zich mee, dat er vrij veel andere abstracte termen (buzzwords) gebruikt worden in de casus. Ik ben echter van mening dat de casus goed te volgen is, zelfs wanneer RPC of Polyglot X (nog) niet bekend zijn bij de lezer.

## Onderzoeksmethoden bij deelvragen

Bij de genoemde deelvragen is het goed om van te voren na te denken hoe het onderzoek aangepakt gaat worden. In deze paragraaf zal per deelvraag genoemd worden welke onderzoeksmethode(n) zullen worden gebruikt. De onderzoeksmethoden komen uit de ICT Research Methods Pack.

Bij deelvraag 1 en 2 gaat het vooral om theorie. Daarom zal in deze hoofdstukken voornamelijk gebruik gaan worden gemaakt van de "Literature Study" onderzoeksmethode. Tijdens het onderzoek naar deze deelvragen zal gekeken worden naar relevante bronnen op (voornamelijk) het internet. Na het lezen van de relevante bronnen kan een theoretische synopsis gegeven worden over de techniek.

Bij deelvraag 3 komen twee onderzoeksmethoden kijken. Allereerst zal de "IT architecture sketching" methode van pas komen om de architectuur van de demo-applicatie te schetsen. Dit zal de lezer een goed beeld geven van de situatie en hoe gRPC daarbij past. 
Ook zal in deze deelvraag de methode "Prototype" worden gebruikt. In dit scenario zal het prototype meer lijken op het uiteindelijke antwoord van de hoofdvraag.

# Toepassing op Pitstop

Eerder in dit plan werd Pitstop al genoemd. Deze applicatie is eerder in de minor al gebruikt als voorbeeld van een microservice architectuur die met behulp van de bijgeleverde Kubernetes configuratie gedeployed kan worden. 

In een volgend project binnen de minor zal Pitstop uitgebreid worden met de onderzochte onderwerpen van de individuele teamleden. Dit onderzoek zal dus ook deel uitmaken van de uitwerking van dat project. De conclusie van dit onderzoek kan direct worden overgenomen in iedere microservice architectuur, dus ook in Pitstop.

# Literatuurlijst

Bonestroo, W.J., Meesters, M., Niels, R., Schagen, J.D., Henneke, L., Turnhout, K. van (2018): *ICT Research Methods*. HBO-i, Amsterdam. ISBN/EAN: 9990002067426. Available from: http://www.ictresearchmethods.nl/
Van Wijk, E. (2017, 26 juni). *Web-scale aan de vergetelheid onttrekken*. Computable.nl. Geraadpleegd op 05-10-2012 van https://www.computable.nl/artikel/opinie/maatschappij/6049057/1509029/web-scale-aan-de-vergetelheid-onttrekken.html
