<template>
    <header>
        <nav>
            <!-- <div class="item"></div> -->
            <div class="item"><h1>Pedidos</h1></div>
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
header {
    display: flex;
    flex-direction: row;

    text-align: center;
    height: 25px;
    width: 100%;

    background-color: $primaryColor;
}

nav {
    display: flex;
    flex-direction: row;
    width: 100%;
}

.item {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    color: $primaryColorFont;
    width: 100%;
}
</style>
