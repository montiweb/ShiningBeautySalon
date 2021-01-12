import Axios from 'axios'
 
function parseBody(response) {
    if (response.status === 200) {
        return response;
    } else {
        console.warn('Error parseBody', response);
        return Promise.reject(response);
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
    console.log(error);
    return Promise.reject(error)
});

instance.interceptors.response.use((response) => {
    return parseBody(response)
}, error => {
    if (error.response == undefined) {
        return Promise.reject(error);
    }

    console.warn('Error status', error.response.status);

    if (error.response.status == 401) {
        localStorage.removeItem('userIdentity');
        window.location.href = "/login";
    }
    return Promise.reject(error);
});

export const http = instance