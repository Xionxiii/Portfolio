import Vue from "vue";
import Router from "vue-router";
import { CAdminTablePage, CAdminEditorPage } from "coalesce-vue-vuetify2/lib";

Vue.use(Router);

export default new Router({
  mode: "history",
  routes: [
    {
      path: "/",
      name: "home",
      component: () => import("./views/Home.vue"),
    },
    {
      path: "/coalesce-example",
      name: "coalesce-example",
      component: () => import("./views/CoalesceExample.vue"),
      props: { title: "Coalesce Example" },
    },
    {
      path: "/projects",
      name: "Projects Page",
      component: () => import("./views/Projects.vue"),
      props: (route) => ({ id: +route.params.id }),
    },

    // Coalesce admin routes
    {
      path: "/admin/:type",
      name: "coalesce-admin-list",
      component: CAdminTablePage,
      props: (r) => ({
        type: r.params.type,
      }),
    },
    {
      path: "/admin/:type/edit/:id?",
      name: "coalesce-admin-item",
      component: CAdminEditorPage,
      props: (r) => ({
        type: r.params.type,
        id: r.params.id,
      }),
    },
  ],
});
