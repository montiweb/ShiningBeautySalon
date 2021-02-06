import React from 'react';
import { InputTextarea } from 'primereact/inputtextarea';
import { GMap } from 'primereact/gmap';
import { useState } from 'react';

const TextArea = (props) => {
    return (
        <div className="pb-md">
            <div className={(props.theme == "dark") ? "pb-xs text-white" : "pb-xs font-md"}>{props.title}</div>
            <InputTextarea rows={props.rows} cols={30} value={props.value} onChange={props.onChange} style={{ width: "100%" }} placeholder={props.placeholder} />
            <span className="p-ml-2">{props.value}</span>
        </div> 
    )
}

export default TextArea;