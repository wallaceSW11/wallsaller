<template>
    <div class="title">
        <div class="title-content">
            <div class="title-text" @click="$emit('title-clicked')">
                <h2>{{ text }}</h2>
            </div>
            <div v-if="addIcon" @click="iconClick" class="title-icon">+</div>
        </div>

        <div class="line"></div>
    </div>
</template>

<script>
export default {
    name: "TitlePage",
    emits: ["clicked", "title-clicked"],
    props: {
        text: { type: String, default: "" },
        addIcon: { type: Boolean, default: false },
    },
    methods: {
        iconClick() {
            console.log("cliquei");
            this.$emit("clicked");
        },
    },
};
</script>

<style lang="scss" src="./style.scss" scoped />
