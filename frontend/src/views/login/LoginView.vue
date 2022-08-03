<template>
    <div class="main">
        <div class="main">
            <div class="card">
                <div class="card-head">Logo</div>
                <div class="card-form">
                    <input-label label="E-mail" />
                    <input-label label="Senha" />
                </div>
                <div class="card-footer">
                    <button-custom text="Acessar" @clicked="access" />
                    <span
                        >Novo por aqui? chega mais e
                        <router-link to="/registration"
                            >Clique aqui</router-link
                        >
                        para criar sua conta!</span
                    >
                </div>
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

<style></style>
