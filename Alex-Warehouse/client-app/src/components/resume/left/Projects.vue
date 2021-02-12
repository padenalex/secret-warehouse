<template>
    <div class="projects">
      <h3>Projects</h3>
      <q-tabs no-caps active-color="primary" indicator-color="transparent" class="text-grey" >
        <q-tab name="images" label="Images" icon="settings" style="width: 150px; height: 150px;"></q-tab>
        <q-tab name="videos" label="Videos" icon="settings" style="width: 150px; height: 150px;"></q-tab>
        <q-tab name="articles" label="Articles" icon="settings" style="width: 150px; height: 150px;"></q-tab>
      </q-tabs>
    </div>
</template>

<script>
export default {
name: "Projects"
}
</script>

<style scoped>
h3 {
  margin-left: 2%;
  margin-top: 0;
  margin-bottom: 0;
}

</style>