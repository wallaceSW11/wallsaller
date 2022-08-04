<template>
    <div class="card">
        <div class="card-status">
            <span>Status: </span
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
