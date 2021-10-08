import React, {useEffect, useState} from 'react';
import './App.css';
import Header from "./components/Header";
import FlightRow from "./components/FlightRow";
import {FlightData} from "./models/FlightData";

function App() {
    const [flightData, setFlightData] = useState<FlightData[]>();

    useEffect(() => {
        fetch("https://localhost:5001/flights")
            .then(response => response.json()
                .then(data => {
                    setFlightData(data)
                }));
    }, [])

    return (
        <div className="app">
            <div className="wrapper">
                <Header/>
                <table>
                    <thead>
                    <tr>
                        <th>Terminal</th>
                        <th>Flight</th>
                        <th>Aircraft</th>
                        <th>Destination</th>
                        <th>Time</th>
                        <th>Gate</th>
                        <th>Remarks</th>
                    </tr>
                    </thead>
                    <tbody>
                    {flightData?.map(fd => <FlightRow flightNumber={fd.flightNumber} departureTime={fd.departureTime}
                                                      destination={fd.destination} gate={fd.gate} status={fd.status}
                                                      terminal={fd.terminal}
                                                      aircraftModel={fd.aircraftModel}
                                                      key={fd.flightNumber}/>)}
                    </tbody>
                </table>
            </div>
        </div>
    );
}

export default App;
