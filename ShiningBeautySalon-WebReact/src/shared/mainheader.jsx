import React from 'react'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { Link } from 'react-router-dom';
import Strings from '../utility/strings';
import { Menubar } from 'primereact/menubar';  
import bg from '../asset/image/team-2-1.jpg'

const MainHeader = () => {
    const items = [
        {
            label: Strings.item_home,
            icon: 'pi pi-fw pi-home'
        },
        {
            label: Strings.item_aboutUs,
            icon: 'pi pi-fw pi-info-circle'
        }, 
        {
            label: Strings.item_contactUs,
            icon: 'pi pi-fw pi-phone'
        }, 
        {
            label: Strings.panel_Location,
            icon: 'pi pi-fw pi-calendar'
        }, 
        {
            label: Strings.panel_Person,
            icon: 'pi pi-fw pi-user',
        }, 
    ];
    return (

        <Menubar style={{width : '100%'}}
            model={items}
            start={<span className="navbar-brand text-white">{Strings.brand_Short}</span>} 
        />

    )
}

export default MainHeader;



//<a className="navbar-brand text-white">{Strings.brand_Short}</a>
//    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample07" aria-controls="navbarsExample07" aria-expanded="false" aria-label="Toggle navigation">
//        <span className="navbar-toggler-icon"></span>
//    </button>

//    <div className="collapse navbar-collapse" id="navbarsExample07">
//        <ul className="navbar-nav mr-auto">
//            <li className="nav-item active text-white">
//                <Link to="/" className="nav-link text-white"><FontAwesomeIcon style={{ marginRight: '5px' }} icon={faHome} />{Strings.item_home} <span className="sr-only">(current)</span></Link>
//            </li>
//            <li className="nav-item text-white">
//                <Link to="/aboutUs" className="nav-link text-white"><FontAwesomeIcon style={{ marginRight: '5px' }} icon={faInfo} />{Strings.item_aboutUs}</Link>
//            </li>
//            <li className="nav-item text-white">
//                <Link to="/contactUs" className="nav-link text-white"><FontAwesomeIcon style={{ marginRight: '5px' }} icon={faPhone} />{Strings.item_contactUs}</Link>
//            </li>
//        </ul>
//        <ul className="navbar-nav mr-auto float-right">
//            <li className="nav-item text-white">
//                <Link to="/panel" className="nav-link text-white"><FontAwesomeIcon style={{ marginRight: '5px' }} icon={faColumns} />{Strings.item_panel}</Link>
//            </li>
//            <li className="nav-item text-white">
//                <Link to="/login" className="nav-link text-white"><FontAwesomeIcon style={{ marginRight: '5px' }} icon={faSignInAlt} />{Strings.item_login}</Link>
//            </li>
//        </ul>
//    </div>