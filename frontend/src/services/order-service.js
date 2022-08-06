// import api from "./api";
import data from "./data";

function getAll() {
    return data.Orders;
    // return new Promise((resolve, reject) => {
    //     return data.Orders;
    // });
}

function getById() {
    return data.OrderDetail;
    // return new Promise((resolve, reject) => {
    //     return data.OrderDetail;
    // });
}

export default {
    getAll,
    getById,
};
