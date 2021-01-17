import logo from './logo.svg';
import './App.css';
import { http } from './utilize/http';
import { useEffect, useState } from 'react';

function App() {
    const [list, setList] = useState([])
    const CallTest = async () => { 
        var response = await http.get(`http://api.shiningbeautysalon.com/Salon`);
        //var response = await http.get(`https://localhost:44355/Salon`);
        setList(response.data)
    }
    const click = () => {
        CallTest()
    } 
    return (
        <div className="App">
            <p>This is Salon Data</p>

            <button onClick={click}>Click ME</button>
            {
                (list.length > 0) ?list.map((item, index) =>  
                    <div>{item.id}
                        {item.name}
                        {item.address}
                        {item.about}
                        {item.slogan}
                        {item.logo}
                        {item.phone}
                        {item.url}</div>
                 ): <></>
            }
        </div>
    );
}

export default App;
