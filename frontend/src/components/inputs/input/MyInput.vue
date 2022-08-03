<template>
    <input
        :value="modelValue"
        @input="$emit('update:modelValue', $event.target.value)"
    />
</template>

<script>
export default {
    name: "InputLabel",
    props: ["modelValue"],
    emits: ["update:modelValue"],
};
</script>
