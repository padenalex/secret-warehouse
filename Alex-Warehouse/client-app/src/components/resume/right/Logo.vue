<template>
  <div class="logo">
    <q-circular-progress
        indeterminate
        size=250px
        :thickness="0.2"
        color="pink"
        center-color="white"
        track-color="transparent"
        style="width:inherit; "

        class="q-ma-md"
    ></q-circular-progress>
  </div>
</template>

<script>
export default {
name: "Logo"
}
</script>

<style scoped>
.logo {
  text-align: center;
  background-color: #062b2b;
}
</style>