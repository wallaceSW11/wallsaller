import axios from "axios";

const api = axios.create({
    baseURL: "https://localhost:7168/api/v1",
    headers: { "Cache-Control": "no-cache" },
});

export default api;
