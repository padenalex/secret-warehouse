<template>
<div class="contacts">
  <h3>Contacts</h3>
  <div id="contact-list">
    <div class="row justify-center full-height full-width text-center" style="max-width: 100%">
      <q-list style="text-align: center; justify-content: center">
        <q-item clickable v-ripple>
          <q-item-section avatar>
            <q-icon color="primary" name="bluetooth"></q-icon>
          </q-item-section>

          <q-item-section style="font-weight: bolder">Email</q-item-section>
        </q-item>

        <q-item clickable v-ripple>
          <q-item-section avatar>
            <q-avatar color="teal" text-color="white" icon="bluetooth"></q-avatar>
          </q-item-section>

          <q-item-section style="font-weight: bolder">Discord</q-item-section>
        </q-item>

        <q-item clickable v-ripple>
          <q-item-section avatar>
            <q-avatar rounded color="purple" text-color="white" icon="bluetooth"></q-avatar>
          </q-item-section>

          <q-item-section style="font-weight: bolder">Github</q-item-section>
        </q-item>

        <q-item clickable v-ripple>
          <q-item-section avatar>
            <q-avatar color="primary" text-color="white">
              R
            </q-avatar>
          </q-item-section>

          <q-item-section style="font-weight: bolder">Linkedin</q-item-section>
        </q-item>
      </q-list>
    </div>
  </div>
  <q-separator/>
</div>
</template>

<script>
export default {
name: "Contacts"
}
</script>

<style scoped>
h3 {
  margin: 0;
  margin-left: 5%;
  font-weight: bolder;
}

.contacts {
  margin: 5%;
}
</style>