<template>
    <div class="float-button" @click="$emit('clicked')"><span>+</span></div>
</template>

<script>
export default {
    name: "Float-Button",
    emits: ["clicked"],
    data() {
        return {};
    },
};
</script>

<style lang="scss" src="./style.scss" scoped />
