<template>
    <div class="main">
        <div class="card">
            <div class="form">
                <input-label label="Nome" />
                <input-label label="Email" />
                <input-label label="Senha" />
                <input-label label="Confirmação de senha" />
            </div>
            <div class="action">
                <button-custom text="Criar conta" />
                <button-custom text="Cancelar" secondary />
            </div>
        </div>
    </div>
</template>

<script>
import InputLabel from "@/components/inputs/input/InputLabel.vue";
import ButtonCustom from "@/components/buttons/buttons/button/ButtonCustom.vue";

export default {
    name: "RegistrationView",
    components: {
        InputLabel,
        ButtonCustom,
    },
};
</script>

<style></style>
