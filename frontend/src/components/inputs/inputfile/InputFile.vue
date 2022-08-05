<template>
    <div class="inputfile-main">
        <label for="pics">{{ label }}</label>
        <input
            name="pics"
            type="file"
            accept="image/png, image/jpeg"
            multiple
            @change="previewFiles"
        />
    </div>
</template>

<script>
export default {
    name: "InputFile",
    emits: ["update:modelValue"],
    props: {
        label: { type: String, default: "" },
        modelValue: { type: Array },
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
            console.log(newValue);
            this.$emit("update:modelValue", newValue);
        },
    },
    methods: {
        previewFiles(event) {
            console.log(event.target.files);
            this.$emit("update:modelValue", event.target.files);
        },
    },
};
</script>

<style></style>
