<template>
  <div>
    <li v-for="item in progress" :key="item">
      <q-linear-progress dark stripe rounded size="20px" :buffer="buffer" :value="item" color="red" class="qmtsm"/>
    </li>
  </div>
</template>

<script>
export default {
  data () {
    return {
      progress: 4,
      progressBuffer: 41,
      buffer: 17
    }
  },
}
</script>
