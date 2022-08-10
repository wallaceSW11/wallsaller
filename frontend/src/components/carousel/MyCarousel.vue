<template>
    <div class="carousel">
        <Carousel :items-to-show="2.5" :wrap-around="true">
            <Slide v-for="slide in 10" :key="slide">
                <!-- <div class="carousel__item">{{ slide }}</div> -->
                <div class="carousel__item">
                    <div class="pic">
                        <img
                            :src="require(`@/assets/images/photo${slide}.jpg`)"
                            alt=""
                        />
                    </div>
                    <div class="action">
                        <button-custom text="Selecionar" />
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
import { defineComponent } from "vue";
import { Carousel, Navigation, Slide } from "vue3-carousel";
// import { MyComp } from "./MyComp.vue";

import "vue3-carousel/dist/carousel.css";
import ButtonCustom from "../buttons/buttons/button/ButtonCustom.vue";

export default defineComponent({
    name: "MyCarousel",
    components: {
        Carousel,
        Slide,
        Navigation,
        ButtonCustom,
        // MyComp,
    },
    methods: {
        sourceImg(index) {
            return `@/assets/images/photo${index}.jpg`;
        },
    },
});
</script>

<style lang="scss" scoped>
.carousel {
    display: flex;
    min-width: 100%;
    /* background-color: purple; */
}

.carousel__item {
    min-height: 100px;
    width: 100%;
    /* background-color: red; */
    border: 1px solid $primaryColor;
    color: var(--carousel-color-white);
    font-size: 20px;
    border-radius: 8px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
}

.pic {
    display: flex;
    justify-content: center;
    align-items: center;
    width: 80px;
    max-height: 80px;
    overflow: hidden;
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
