<template>
  <div id="app">
    <img class="logo" alt="Neutronium logo" src="./assets/logo.png">
    <HelloWorld msg="Welcome to Your Neutronium Vue.js App"/>
  </div>
</template>

<script>
import HelloWorld from "./components/HelloWorld.vue";

const props = {
  viewModel: Object,
  __window__: Object
};

export default {
  props,
  data() {
    return this.viewModel;
  },
  name: "app",
  components: {
    HelloWorld
  }
};
</script>

<style lang="less">
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
#app .logo {
  width: 200px;
}
</style>
