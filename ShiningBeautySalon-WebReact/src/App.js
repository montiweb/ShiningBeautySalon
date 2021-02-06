import React, { Component } from 'react';
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import navigation from './utility/navigation';
import Login from './pages/login';
import Panel from './pages/panel';

export default class App extends Component {
    render() {
        return (
            <div className="App" >
                <Router>
                    <Switch>
                        <Route path={`/${navigation.login}`} component={Login} />
                        <Route path={`/${navigation.panel}`} component={Panel} /> 
                        <Route exact path={`/`} component={Login} />
                    </Switch>
                </Router>
            </div>
        );
    }
} 
