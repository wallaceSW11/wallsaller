<template>
    <header class="navbar-header">
        <nav class="navbar-nav">
            <!-- <div class="item"></div> -->
            <div class="navbar-item"><h1>Pedidos</h1></div>
            <!-- <div class="item"></div> -->
        </nav>
    </header>
</template>

<script>
export default {
    name: "NavBar",
};
</script>

<style lang="scss" scoped>
.navbar-header {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    background-color: $primaryColor;
    color: $primaryColorFont;
    height: 30px;
    font-weight: bold;
}
</style>
