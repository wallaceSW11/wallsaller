<template>
    <div
        :class="['main-button', secondary ? 'secundaria' : 'primaria']"
        @click="$emit('clicked')"
    >
        <span>{{ text }}</span>
    </div>
</template>

<script>
export default {
    name: "ButtonCustom",
    emits: ["clicked"],
    props: {
        text: { type: String, default: "" },
        secondary: { type: Boolean, default: false },
    },
    data() {
        return {};
    },
    methods: {
        clicked() {
            this.$emit("clicked");
        },
    },
};
</script>

<style lang="scss" src="./style.scss" scoped />
