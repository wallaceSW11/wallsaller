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
        modelValue: { type: FileList },
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
    methods: {
        previewFiles(event) {
            console.log(event.target.files);
            this.$emit("update:modelValue", event.target.files);
        },
    },
};
</script>

<style lang="scss" scoped>
.inputfile-main {
    display: flex;
    flex-direction: column;
    margin: 5px 0;
}

label {
    line-height: 25px;
}
</style>
