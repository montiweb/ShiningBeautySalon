import React, { useState } from 'react'; 
import { useHistory } from 'react-router-dom';
import FormButton from '../../../shared/comps/Button';
import Textbox from '../../../shared/comps/Textbox';
import navigation from '../../core/navigation';
import AuthenticationService from '../../core/services/authenticationService';
import Strings from '../../core/strings';

const LoginLayout = () => {
    const history = useHistory();
    //UseState
    const [username, setUsername] = useState("")
    const [password, setPassword] = useState("")

    //OnChange
    const _onChangePassword = (e) => setPassword(e.target.value);
    const _onChangeUsername = (e) => setUsername(e.target.value);

    //OnClick
    const _onClickLogin = async () => {
        var dataSet = {
            Username: username,
            Password: password
        }
        const res = await AuthenticationService.login(dataSet);
        if (res) history.push(`${navigation.panel}`)
        else alert("User Not Found")

    }

    const _onClickCancel = () => {
        history.push("/")
    }

    return (
        <div className="login-page">
            <div className="container pt-5">
                <div className="row justify-content-center">
                    <div className="col col-md-6">
                        <div className="card login-card">
                            <div className="card-header">
                                <h3>{Strings.item_login}</h3>
                            </div>
                            <div className="card-body login-card-body">
                                <div className="container">
                                    <div className="row  justify-content-center ">
                                        <div className="col col-md-12">
                                            <div className="login-container">
                                                <div className="row">
                                                    <div className="col-md-6">
                                                        <Textbox theme="dark" value={username} onChange={_onChangeUsername} title={Strings.login_Username} type="text" placeholder={Strings.login_Username} />
                                                    </div>
                                                    <div className="col-md-6">
                                                        <Textbox theme="dark" value={password} onChange={_onChangePassword} title={Strings.login_Password} type="password" placeholder={Strings.login_Password} />
                                                    </div>
                                                    <div className="col col-md-12 mt-2">
                                                        <FormButton onClick={_onClickLogin} type="login" Label={Strings.item_login} />
                                                        <FormButton onClick={_onClickCancel} type="cancel" Label={Strings.general_cancel} />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    )
}

export default LoginLayout; 