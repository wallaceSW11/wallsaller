import Item from "./Item";
import Payment from "./Payment";

export default class OrderDetail {
    constructor(obj) {
        obj = obj || {};

        this.id = obj.id;
        this.createdAt = obj.createdAt;
        this.user = obj.user;
        this.client = obj.client;
        this.deadline = obj.deadline;
        this.status = obj.status;
        this.totalOrder = obj.totalOrder;
        this.items =
            (Array.isArray(obj.items) && obj.items.map((i) => new Item(i))) ||
            [];
        this.payments =
            (Array.isArray(obj.payments) &&
                obj.payments.map((i) => new Payment(i))) ||
            [];
    }
}
