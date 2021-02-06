import React from 'react'; 
import { GMap } from 'primereact/gmap'; 

const GoogleMap = (props) => {
    return (
        <GMap options={props.options} style={{ width: '100%', minHeight: '320px' }} onMapReady={props.onReady} onMapClick={props.onClick} />
    )
}

export default GoogleMap;