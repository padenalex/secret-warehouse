<template>
  <q-layout view="hhh lpr fff" class="bg-img">

    <q-page-container>
      <RouterView></RouterView>
    </q-page-container>


  </q-layout>
</template>

<script>
import Resume from "@/views/Resume";

export default {
  name: 'App',
  components: {
    
  },
  data () {
    return {
    }
  }
}
</script>
<style>
.bg-img {
  background-image: url(https://onlyvectorbackgrounds.com/wp-content/uploads/2019/01/Simple-Vector-Empty-Frame-Background-Purple.jpg);
  background-repeat: no-repeat;
  background-size: cover;
}
</style>