<template>
  <div id="timeline-box">
    <div class="q-pa-lg">

      <q-timeline :layout="layout" :side="side" color="secondary">
        <q-timeline-entry heading>Work History</q-timeline-entry>


        <q-separator inset="item"/>
        <q-timeline-entry
            title="Swish Identity, Inc."
            subtitle="May 2020 - Current"
            side="left"
            icon="delete"
        >
          <div>
            <p>More secure KYC for both parties at lower cost. A Digital Identity Platform.</p>
            <p>We are working to build a full stack of identity verification products from the ground up.
            </p>
          </div>
        </q-timeline-entry>

        <q-separator inset="item"/>

        <q-timeline-entry
            title="Rocketr.net | Co-Founder"
            subtitle="2016 - Mar 2020"
            side="left"
            avatar="https://cdn.quasar.dev/img/avatar3.jpg"
        >
          <div>
            Rocketr.net is primarily a digital storefront. <br/>

            <br/>The storefront allows users to create a shop on the internet for free. It also automates the delivery process of various digital product types and simplifies payment processing by combining multiple processors under one gateway.<br/>

            <br/>Our gateway allows users to consolidate orders from multiple payment methods such as Paypal, Stripe, & Bitcoin under one platform.<br/>
          </div>
        </q-timeline-entry>

        <q-separator inset="item"/>
        <q-timeline-entry
            title="Miscellaneous"
            subtitle="x <= 2016"
            side="left"
        >
          <div>
            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
          </div>
        </q-timeline-entry>

      </q-timeline>
    </div>
  </div>
</template>

<script>
export default {
  name: "Timeline",
  data () {
    return {
      layout: 'comfortable',
      side: 'right'
    }
  }
}
</script>

<style scoped>

</style>