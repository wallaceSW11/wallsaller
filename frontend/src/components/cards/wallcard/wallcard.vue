<template>
    <div class="card">
        <div class="header">
            <title-page :text="title" />
        </div>
        <div class="content">
            <div class="row">
                <div class="field">
                    <InputLabel
                        label="Altura (centímetro)"
                        v-model="modelValue.height"
                    />
                </div>
                <div class="field">
                    <InputLabel
                        label="Largura (centímetro)"
                        v-model="inputWall.width"
                    />
                </div>
                <div class="field">
                    <InputLabel
                        label="Portas"
                        type="Number"
                        v-model="inputWall.doors"
                    />
                </div>
                <div class="field">
                    <InputLabel
                        label="Janelas"
                        type="Number"
                        v-model="inputWall.windows"
                    />
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import InputLabel from "@/components/inputs/input/InputLabel.vue";
import TitlePage from "@/components/titles/title/TitlePage.vue";

export default {
    name: "WallCard",
    emits: ["update:modelValue"],
    props: {
        title: {
            type: String,
            default: "",
        },

        modelValue: {
            type: Object,
            default() {
                return {};
            },
        },
    },
    data() {
        // return {
        //     inputWall: {
        //         height: 11,
        //     },
        // };
    },
    created() {},

    components: {
        InputLabel,
        TitlePage,
    },
    computed: {
        // inputWall() {
        //     this.$emit("wall", this.inputWall);
        // },
        inputWall: {
            get: function () {
                return this.value;
            },
            set: function (newValue) {
                this.$emit("onChange", newValue);
            },
        },
    },
};
</script>

<style lang="scss" src="./style.scss" scoped />
