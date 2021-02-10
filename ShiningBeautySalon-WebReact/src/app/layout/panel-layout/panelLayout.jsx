import React from 'react';
import AdminHeader from '../../../shared/panelheader';
import Sidebar from '../../../shared/sidebar';

const PanelLayout = () => {
    return (
        <div className="layout-wrapper">
            <div className="container-fluid">
                <div className="row">
                    <AdminHeader />
                    <Sidebar />
                    <div className="container" style={{ marginLeft : '250px' }}>
                        <div className="row mt-5">
                            <div className="col-md-12">
                                <h1>Content Will Be Here</h1>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default PanelLayout; 