export default class Payment {
    constructor(obj) {
        obj = obj || {};

        this.id = obj.id;
        this.description = obj.description;
        this.value = obj.value;
    }
}
