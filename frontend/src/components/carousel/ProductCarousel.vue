<template>
    <div class="carousel-container">
        <Carousel :items-to-show="2.5" :wrap-around="true">
            <Slide v-for="(product, index) in products" :key="index">
                <div class="carousel__item">
                    <div class="item-title">
                        <span>{{ product.text }}</span>
                    </div>
                    <div class="pic">
                        <img
                            :src="require(`@/assets/images/${product.image}`)"
                            alt=""
                        />
                    </div>
                </div>
            </Slide>

            <template #addons>
                <Navigation />
            </template>
        </Carousel>
    </div>
</template>

<script>
// import { defineComponent } from "vue";
import { Carousel, Navigation, Slide } from "vue3-carousel";

import "vue3-carousel/dist/carousel.css";

import Data from "@/services/data.js";

export default {
    name: "ProductCarousel",
    components: {
        Carousel,
        Slide,
        Navigation,
    },
    data() {
        return {
            products: Data.AvaliableProducts,
        };
    },
    methods: {
        sourceImg(index) {
            return `@/assets/images/photo${index}.jpg`;
        },
    },
};
</script>

<style lang="scss" scoped>
.carousel-container {
    // display: flex;
    // max-width: 100%;
    // margin: 0 10px;
}

.carousel__item {
    height: 180px;
    border: 1px solid $primaryColor;
    // color: var(--carousel-color-white);
    font-size: 18px;
    border-radius: 8px;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    align-items: center;
    padding: 5px;
}

.pic {
    display: flex;
    justify-content: center;
    align-items: center;
    max-width: 120px;
}

img {
    width: 100%;
    height: auto;
}

.carousel__slide {
    padding: 10px;
}

.carousel__prev,
.carousel__next {
    box-sizing: content-box;
    border: 5px solid white;
    background-color: $primaryColor !important;
    color: $primaryColor;
}

.carousel__icon {
    background-color: $primaryColor;
    color: $primaryColor;
}
</style>
