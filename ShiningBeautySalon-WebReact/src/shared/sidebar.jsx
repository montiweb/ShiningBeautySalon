import React from 'react'
import { Link } from 'react-router-dom';  
import Strings from '../app/core/strings';

const Sidebar = () => {
    return (
        <nav id="sidebar" className="bg-secondary"> 
            <ul className="list-unstyled components">
                <li className="active">
                    <Link to="/panel">
                        {Strings.item_home}
                    </Link>
                    <Link to="/panel">
                        {Strings.panel_Service}
                    </Link>
                    <Link to="/panel">
                        {Strings.panel_Salon}
                    </Link>
                </li>  
            </ul>
        </nav>
    )
}


export default Sidebar;