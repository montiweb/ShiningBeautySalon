import React from 'react'
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHome, faUserAlt, faEnvelope, faGripLines } from '@fortawesome/free-solid-svg-icons';

const AdminHeader = () => {
    return (
        <nav className="navbar navbar-expand-lg navbar-light m-0 border-bottom bg-secondary" style={{ width : '100%' }}>  
            <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span className="navbar-toggler-icon"></span>
            </button>
            <div className="collapse navbar-collapse" id="navbarSupportedContent">
                <ul className="navbar-nav ml-auto mt-2 mt-lg-0"> 
                    <li className="nav-item">
                        <Link to="/" className="nav-link rounded-circle tool-box"><FontAwesomeIcon icon={faEnvelope} /> <span className="sr-only">(current)</span></Link>
                    </li>  
                    <li className="nav-item">
                        <Link to="/" className="nav-link rounded-circle tool-box"><FontAwesomeIcon icon={faHome} /> <span className="sr-only">(current)</span></Link>
                    </li>  
                    <li className="nav-item active">
                        <Link to="/" className="nav-link rounded-circle tool-box"><FontAwesomeIcon icon={faUserAlt} /> <span className="sr-only">(current)</span></Link>
                    </li>
                </ul>
            </div>
        </nav>
    )
}

export default AdminHeader;