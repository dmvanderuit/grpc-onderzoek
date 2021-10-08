CREATE TABLE IF NOT EXISTS aircraft (
    id serial PRIMARY KEY,
    model varchar(50) NOT NULL,
    capacity int NOT NULL,
    status varchar(50) NOT NULL,
    flight_number varchar(50) NOT NULL
);

DELETE FROM aircraft;

INSERT INTO aircraft (model, capacity, status, flight_number)
    VALUES ('A330-300', '300', 'Check in', 'DL74'), ('737', '186', 'Check in', 'KL1009'), ('777-300ER', '408', 'On time', 'KL835'), ('A319', '138', 'On time', 'SK552'), ('787-9', '294', 'On time', 'UA908'), ('A320', '145', 'Delayed', 'BA431'), ('787-9', '294', 'Delayed', 'KL713'), ('777-300ER', '408', 'On time', 'KL871'), ('787-9', '294', 'Cancelled', 'EY78'), ('A320', '145', 'On time', 'VY8303'), ('777-300ER', '408', 'On time', 'EK148'), ('A320', '145', 'Delayed', 'LH2305'), ('A319', '138', 'Cancelled', 'U27939'), ('A340-600', '350', 'On time', 'LX735');

