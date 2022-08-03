<template>
    <div class="float-button" @click="callback"><span>+</span></div>

</template>

<script>
export default {
    name: 'Float-Button',
    props: {
        callback: { type: Function, default: () => {}}
    },
    data() {
        return {

        }
    },


}
</script>

<style lang="scss" src="./style.scss" scoped />