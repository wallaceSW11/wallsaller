export default class Orders {
    constructor(obj) {
        obj = obj || {};

        this.id = obj.id;
        this.status = obj.status;
        this.client = obj.client;
        this.deadline = obj.deadline;
    }
}
