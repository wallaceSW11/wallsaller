<template>
    <div class="title">
        <h2>{{ text }}</h2>
        <div class="line"></div>
    </div>
</template>

<script>
export default {
    name: "TitlePage",
    props: {
        text: { type: String, default: "" },
    },
};
</script>

<style lang="scss" src="./style.scss" scoped />
