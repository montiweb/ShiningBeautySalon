import React from "react";
import { Calendar } from 'primereact/calendar';

const Datepicker = (props) => { 
    return <div className="pb-md">
        <div className={(props.theme == "dark") ? "pb-xs text-white" : "pb-xs font-md"}>{props.title}</div>
        <Calendar
            dateFormat="yy/mm/dd"
            value={props.value}
            onChange={props.onChange}
            placeholder={props.placeholder}
            style={{ width: "100%" }}
            showTime={(props.showTime) ? props.showTime : false}></Calendar>
    </div>
}

export default Datepicker;


