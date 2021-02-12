import React from 'react';
import { Link } from 'react-router-dom';
import Image from '../../../asset/image/40100.jpg'
const MainLayout = () => {
    return (
        <div className="layout-wrapper wallpaper" style={{ textAlign: "center", backgroundColor: 'white' }}>
            <img src={Image} style={{ margin: "auto", height: '100%' }} />
        </div>
    )
}

export default MainLayout; 