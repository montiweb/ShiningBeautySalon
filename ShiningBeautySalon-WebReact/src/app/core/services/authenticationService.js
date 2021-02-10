import address from "../address";
import { http } from "../http";

export default class AuthenticationService {

    static async login(data) {
        var response = await http.post(`${address.Authentication_SignIn}?username=${data.Username}&password=${data.Password}`, data);
        return response.data;
    }

}