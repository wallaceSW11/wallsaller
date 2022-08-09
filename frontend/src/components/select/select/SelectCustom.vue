<template>
    <div class="main-select">
        <label for="select">{{ label }}</label>
        <select name="select" v-model="selected">
            <option disable>{{ defaultOption }}</option>
            <option
                v-for="(item, index) in options"
                :key="index"
                :value="item.value"
            >
                {{ item.text }}
            </option>
        </select>
    </div>
</template>

<script>
export default {
    name: "SelectCustom",
    emits: ["option-selected"],
    props: {
        label: {
            type: String,
            default: "",
        },
        defaultOption: {
            type: String,
            default: "",
        },
        options: {
            type: Object,
        },
        modelValue: { type: String },
    },
    data() {
        return {
            selected: this.modelValue ?? this.defaultOption,
        };
    },
    watch: {
        selected(newValue) {
            this.$emit("option-selected", newValue);
        },
    },
};
</script>

<style lang="scss" scoped>
.main-select {
    display: flex;
    flex-direction: column;
    padding-bottom: 10px;
}

select {
    height: 25px;
    border: 1px solid $primaryColor;
    background-color: #fff;
}
</style>
