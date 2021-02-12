import Vue from "vue";
import VueRouter, { RouteConfig } from "vue-router";
import Resume from "../views/Resume.vue";
import About from "../views/About.vue";

Vue.use(VueRouter);

const routes: Array<RouteConfig> = [
  {
    path: "/",
    name: "Resume",
    component: Resume
  },
  {
    path: "/about",
    name: "About",
    component: About
  }
];

const router = new VueRouter({
  routes
});

export default router;
