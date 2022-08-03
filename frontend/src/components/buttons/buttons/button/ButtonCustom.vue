<template>
    <div
        :class="['main-button', secondary ? 'secundaria' : 'primaria']"
        @click="clicked"
    >
        <span>{{ text }}</span>
    </div>
</template>

<script>
export default {
    name: "ButtonCustom",
    props: {
        text: { type: String, default: "" },
        callback: { type: Function, default: () => {} },
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
