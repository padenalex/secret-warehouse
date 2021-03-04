import Vue from "vue";
import VueRouter, { RouteConfig } from "vue-router";
import Resume from "../views/Resume.vue";
import About from "../views/About.vue";
import Tasks from "../views/Tasks.vue";

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
  },
  {
    path: "/tasks",
    name: "Tasks",
    component: Tasks
  }
];

const router = new VueRouter({
  routes
});

export default router;
