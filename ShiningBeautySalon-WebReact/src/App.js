import React, { Component } from 'react';
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import navigation from './app/core/navigation';
import LoginLayout from './app/layout/login-layout/loginLayout';
import MainLayout from './app/layout/main-layout/mainLayout';
import PanelLayout from './app/layout/panel-layout/panelLayout'; 
 

export default class App extends Component {
    render() {
        return (
            <div className="App" >
                <Router>
                    <Switch>
                        <Route path={`/${navigation.login}`} component={LoginLayout} />
                        <Route path={`/${navigation.panel}`} component={PanelLayout} />
                        <Route exact path={`/`} component={MainLayout} />
                    </Switch>
                </Router>
            </div>
        );
    }
} 
