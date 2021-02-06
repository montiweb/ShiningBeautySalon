import React from 'react';
import { InputText } from 'primereact/inputtext';

const Textbox = (props) => {
    return (
        <div className="pb-md">
            <div className={(props.theme == "dark") ? "pb-xs text-white" : "pb-xs font-md"}>{props.title}</div>
            <InputText type={props.type} value={props.value} onChange={props.onChange} placeholder={props.placeholder} aria-describedby={props.title} style={{ width: "100%" }} />
            <small className="p-invalid p-d-block">{props.error}</small>
        </div>
    )
}

export default Textbox;