<template>
    <div class="title">
        <div class="title-content">
            <div class="title-text" @click="$emit('title-clicked')">
                <h2>{{ text }}</h2>
            </div>
            <div
                v-if="addIcon"
                @click="$emit('icon-clicked')"
                class="title-icon"
            >
                +
            </div>
        </div>

        <div class="line"></div>
    </div>
</template>

<script>
export default {
    name: "TitlePage",
    emits: ["icon-clicked", "title-clicked"],
    props: {
        text: { type: String, default: "" },
        addIcon: { type: Boolean, default: false },
    },
};
</script>

<style lang="scss" src="./style.scss" scoped />
