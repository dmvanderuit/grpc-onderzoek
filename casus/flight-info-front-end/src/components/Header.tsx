import React, {FunctionComponent} from "react";
import Departures from "../assets/departures.png";

const Header: FunctionComponent = () => {
    return <div className="header">
        <div className="departures-wrapper">
            <img className="departures" src={Departures} alt=""/>
        </div>
        <h1>Departures</h1>

    </div>
}

export default Header;
