<template>
    <div class="main">
        <nav-bar />
        <div class="card" v-for="order in ordersData" :key="order.id">
            <div class="card-status">
                <span>Status: </span><strong>{{ order.status }}</strong>
            </div>
            <div class="card-content">
                <span>Cliente: {{ order.client }}</span>
                <span>Previsão de entrega: {{ order.deadline }}</span>
            </div>
            <div class="card-footer" @click="goToDetail(order.id)">
                <div class="card-action">Detalhes</div>
                <div class="card-action-icon">></div>
            </div>
        </div>
    </div>
</template>

<script>
import NavBar from "@/components/navbar/NavBar.vue";
// import OrdersCard from "@/components/cards/orderscard/OrdersCard";
import Orders from "@/models/Orders";
import orderService from "@/services/order-service";

export default {
    name: "OrdersView",
    components: {
        NavBar,
        // OrdersCard,
    },
    data() {
        return {
            ordersData: new Orders(),
        };
    },
    created() {
        this.getAllOrders();
    },
    methods: {
        getAllOrders() {
            this.ordersData = orderService.getAll();

            // orderService
            // .getAll()
            //     .then((res) => {
            //         this.ordersData = res;
            //     })
            //     .catch((err) => console.log(err));
        },
        goToDetail(id) {
            this.$router.push({ name: "OrderDetailView", params: { id: id } });
        },
    },
};
</script>

<style lang="scss" scoped>
.card {
    display: flex;
    flex-direction: column;
    min-width: 300px;
    margin: auto;
    border: 1px solid $primaryColor;
    border-radius: 5px;
}

@media (max-width: 900px) {
    .card {
        max-width: 95%;
        margin: 10px auto;
    }
}

.card-content {
    display: flex;
    flex-direction: column;
}

.card-footer {
    cursor: pointer;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    padding: 5px;
    background-color: $primaryColor;
    color: $primaryColorFont;
}

.card-status,
.card-content span {
    line-height: 20px;
}

.card-status {
    padding: 5px;
}

.card-content {
    padding: 0 5px 5px 5px;
}

.card strong {
    font-weight: bold;
}
</style>
