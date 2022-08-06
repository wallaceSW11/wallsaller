export default class Item {
    constructor(obj) {
        obj = obj || {};

        this.id = obj.id;
        this.type = obj.type;
        this.description = obj.description;
        this.quantity = obj.quantity;
        this.theme = obj.theme;
        this.size = obj.size;
        this.name = obj.name;
        this.age = obj.age;
        this.note = obj.note;
        this.price = obj.price;
        this.color = obj.color;
        this.pics = obj.pics;
        this.texts = obj.texts;
        this.drawer = obj.drawer;
    }
}
