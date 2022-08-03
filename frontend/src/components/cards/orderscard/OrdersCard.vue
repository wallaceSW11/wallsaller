<template>
    <div class="card">
        <div class="card-status">
            <span>Status:</span
            ><strong>Aguardando aprovação da Turquesa</strong>
        </div>
        <div class="card-content">
            <span>Cliente: Fulano de tal</span>
            <span>Previsão de entrega: 28/12/2022</span>
        </div>
        <div class="card-footer" @click="goToDetail">
            <div class="card-action">Detalhes</div>
            <div class="card-action-icon">></div>
        </div>
    </div>
</template>

<script>
export default {
    name: "OrdersCard",
    methods: {
        goToDetail() {
            this.$router.push({ name: "OrderDetailView" });
        },
    },
};
</script>

<style scoped>
.card-content {
    display: flex;
    flex-direction: column;
}

.card-footer {
    cursor: pointer;
}
</style>
