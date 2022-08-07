<template>
    <div class="flex">
        <label for="input" class="labelClass">{{ label }}</label>

        <input
            :type="type"
            :placeholder="placeHolder"
            :value="modelValue"
            @input="$emit('update:modelValue', $event.target.value)"
            ref="myInput"
            :disabled="isDisabled"
        />
    </div>
</template>

<script>
export default {
    name: "InputLabel",
    inheritedAttrs: false,
    props: {
        label: { type: String, default: "" },
        type: { type: String, default: "text" },
        placeHolder: { type: String, default: "" },
        modelValue: { type: String, default: "" },
        autoFocus: { type: Boolean, default: false },
        isDisabled: { type: Boolean, default: false },
    },
    emits: ["update:modelValue"],
    data() {
        return {};
    },

    mounted() {
        if (this.autoFocus) {
            this.$refs.myInput.focus();
        }
    },
    // computed: {
    //     inputValue: {
    //         get: function () {
    //             return this.value;
    //         },
    //         set: function (newValue) {
    //             this.$emit("onChange", newValue);
    //         },
    //     },
    // },
};
</script>

<style lang="scss" src="./style.scss" scoped />
