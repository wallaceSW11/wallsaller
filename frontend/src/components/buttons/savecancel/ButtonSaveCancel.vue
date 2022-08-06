<template>
    <div class="main-buttons">
        <div class="item-save">
            <button-custom text="Salvar" @click="$emit('save-clicked')" />
        </div>
        <div class="item">
            <button-custom
                text="Cancelar"
                secondary
                @click="$emit('cancel-clicked')"
            />
        </div>
    </div>
</template>

<script>
import ButtonCustom from "../buttons/button/ButtonCustom.vue";

export default {
    name: "ButtonSaveCancel",
    emits: ["save-clicked", "cancel-clicked"],
    components: {
        ButtonCustom,
    },
};
</script>

<style lang="scss" scoped>
.item-save {
    display: flex;
    margin-bottom: 5px;
}

.item {
    display: flex;
}

.main-buttons {
    display: flex;
    flex-direction: column;
}
</style>
