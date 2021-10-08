import {FunctionComponent} from "react";
import {FlightData} from "../models/FlightData";
import TableCell from "./TableCell";

const FlightRow: FunctionComponent<FlightData> = (props) => {
    let statusClassname = "status ";

    switch (props.status) {
        case null:
            statusClassname += "negative"
            break;
        case "Cancelled":
            statusClassname += "negative"
            break;
        case "Delayed":
            statusClassname += "warning"
            break;
    }

    return <tr>
        <TableCell key={`${props.flightNumber}-terminal`} content={props.terminal || "ERROR"} className="" length={2}/>
        <TableCell key={`${props.flightNumber}-flightNumber`} content={props.flightNumber || "ERROR"}
                   className="flight-number" length={8}/>
        <TableCell key={`${props.flightNumber}-aircraftModel`} content={props.aircraftModel || "ERROR"} className=""
                   length={10}/>
        <TableCell key={`${props.flightNumber}-destination`} content={props.destination || "ERROR"} className=""
                   length={12}/>
        <TableCell key={`${props.flightNumber}-departureTime`} content={props.departureTime || "ERROR"} className=""
                   length={5}/>
        <TableCell key={`${props.flightNumber}-gate`} content={props.gate || "ERROR"} className="gate" length={4}/>
        <TableCell key={`${props.flightNumber}-status`} content={props.status || "ERROR"} className={statusClassname}
                   length={10}/>
    </tr>;
}

export default FlightRow;
