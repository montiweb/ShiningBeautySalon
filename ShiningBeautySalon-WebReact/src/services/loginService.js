import { http } from "../utility/http"
import address from "../utility/address"


export default class LoginService {

    static async signIn(data) { 
        var response = await http.post(`${address.Login_SignIn}?username=${data.Username}&password=${data.Password}`, data);
        return response.data;
    }

}