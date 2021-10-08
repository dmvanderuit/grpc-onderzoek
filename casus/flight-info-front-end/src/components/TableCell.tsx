import {FunctionComponent} from "react";

interface OwnProps {
    content: string;
    length: number;
    className: string;
}

const TableCell: FunctionComponent<OwnProps> = (props) => {
    const spanList: JSX.Element[] = [];

    for(let i = 0; i < props.length; i++) {
        spanList.push(<span className={`letter-box ${props.className}`}>{props.content[i] && props.content[i] !== " " ? props.content[i] : <>&nbsp;</>}</span>)
    }

    return <td>{spanList}</td>;
}

export default TableCell;
