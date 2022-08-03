<template>
    <div class="main">
        <nav-bar />
        <orders-card />
    </div>
</template>

<script>
import NavBar from "@/components/navbar/NavBar.vue";
import OrdersCard from "@/components/cards/orderscard/OrdersCard";

export default {
    name: "OrdersView",
    components: {
        NavBar,
        OrdersCard,
    },
};
</script>

<style></style>
