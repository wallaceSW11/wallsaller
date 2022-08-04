<template>
    <div class="main">
        <div class="card">
            <div class="card-head">
                Turquesa <br />
                Ateliê criativo
            </div>
            <div class="card-form">
                <input-label label="E-mail" />
                <input-label label="Senha" />
            </div>
            <div class="card-footer">
                <button-custom text="Acessar" @clicked="access" />
                <br />
                <span
                    ><strong>Novo por aqui?</strong> <br />
                    <router-link to="/registration">Clique aqui</router-link>
                    para criar sua conta!</span
                >
            </div>
        </div>
    </div>
</template>

<script>
import InputLabel from "@/components/inputs/input/InputLabel.vue";
import ButtonCustom from "@/components/buttons/buttons/button/ButtonCustom.vue";

export default {
    name: "LoginView",
    components: {
        InputLabel,
        ButtonCustom,
    },
    methods: {
        access() {
            // se super vai para o home, se não, vai para os pedidos.
            this.$router.push({ name: "OrdersView" });
        },
    },
};
</script>

<style lang="scss" scoped>
.main {
    display: flex;
    flex-direction: column;
}

.card {
    display: flex;
    flex-direction: column;
    min-width: 600px;
    margin: 20px auto;
    border: 1px solid $primaryColor;
    border-radius: 5px;
    background-color: #fff;
}

.card-head {
    display: flex;
    justify-content: center;
    align-items: center;
    color: $primaryColor;
    font-size: 30px;
    font-weight: bold;
    padding: 10px 15px;
    text-align: center;
}

.card-form {
    padding: 10px;
}

.card-footer {
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    margin: 15px;
}

.card-footer span {
    text-align: center;
}

@media (max-width: 900px) {
    .card {
        min-width: 90%;
        margin: 10px auto;
    }
}
</style>
