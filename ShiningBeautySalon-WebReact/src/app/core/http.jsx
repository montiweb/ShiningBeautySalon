import Axios from 'axios'
 
function parseBody(response) {
    if (response.status === 200) {
        return response;
    } else {
        console.warn('Error parseBody', response);
        return response;
    }
}

let instance = Axios.create({
    withCredentials: true,
    timeout: 60000,
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json',
        'Access-Control-Allow-Credentials': 'true',
    }
});

instance.interceptors.request.use((config) => {
    config.headers.apiKey = "5E5AE551-D93E-4801-BC02-22A5CEB71F08";
    return config;
}, error => {
    return error
});

instance.interceptors.response.use((response) => {
    return parseBody(response)
}, error => {
    if (error.response == undefined) {
        return error;
    }

    console.warn('Error status', error.response.status);

    if (error.response.status == 401) {
        localStorage.removeItem('userIdentity');
        window.location.href = "/login";
    }
    return error;
});

export const http = instance