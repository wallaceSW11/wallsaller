<template>
    <div class="textarea-main">
        <label for="textarea">{{ label }}</label>
        <textarea name="textarea" v-model="internValue" maxlength="200" />
    </div>
</template>

<script>
export default {
    name: "TextArea",
    emits: ["update:modelValue"],
    props: {
        label: { type: String, default: "" },
    },
    data() {
        return {
            internValue: null,
        };
    },
    watch: {
        modelValue(newValue) {
            this.internValue = newValue;
        },
        internValue(newValue) {
            this.$emit("update:modelValue", newValue);
        },
    },
};
</script>

<style lang="scss" scoped>
.textarea-main {
    display: flex;
    flex-direction: column;
}

textarea {
    border: 1px solid $primaryColor;
    background-color: #fff;
    min-height: 60px;
    resize: none;
}
</style>
