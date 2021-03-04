<template>
  <q-page class="flex flex-center">
    <div class="tasks">
      <h1>This is an task page</h1>
      <Todos/>
    </div>
  </q-page>
</template>

<script>
import Todos from "@/components/Todos";

export default {
  name: 'Tasks',
  components: {
    Todos,
  }
}
</script>
