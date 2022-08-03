<template>
  <div class="menu-button">
      <button type="button" :class="['hamburger', isActive ? 'active' : '']" @click="callback">
          <span class="line"></span>
          <span class="line"></span>
          <span class="line"></span>
      </button>
  </div>

</template>

<script>
export default {
    name: 'MenuButton',
    props: {
        callback: { type: Function, default: () => {} },
        clicked: { type: Boolean, default: false}
    },
    data() {
        return {
            isActive: false,
        }
    },
    watch: {
        clicked() {
            this.isActive = !this.isActive;
        }
    }

}
</script>

<style lang="scss" src="./style.scss" scoped />
