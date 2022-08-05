<template>
    <div class="check">
        <label>
            <input id="check" type="checkbox" v-model="checked" />
            {{ text }}</label
        >
    </div>
</template>

<script>
export default {
    name: "checkboxCustom",
    emits: ["update:modelValue"],
    props: {
        text: { type: String, default: "" },
        modelValue: { type: Boolean, default: true },
    },
    data() {
        return {
            checked: true,
        };
    },
    watch: {
        modelValue(newValue) {
            this.checked = newValue;
        },
        checked(newValue) {
            this.$emit("update:modelValue", newValue);
        },
    },
};
</script>

<style lang="scss" src="./style.scss" scoped />
