<template>
  <v-container>
    <v-row>
      <v-col>
        Projects Page
      </v-col>
      <v-spacer />
      <v-col class="text-right">
        <v-btn @click="showEdit=true" color="primary">
          <!--need to add a component for this-->
        </v-btn>
      </v-col>
      <AddProjectDialog v-model="showEdit" :project="currProject" />
    </v-row>
    <!--Search bar-->
    <v-row>
      <v-col>
        <v-text-field v-model="projects.$params.search" prepend-inner-icon="fa fa-search" label="Search through the Projects" clearable autofocus />
      </v-col>
    </v-row>
    <c-loader-status :loaders="{'': [projects.$load]}"/>
    <v-sheet width="100%" color="transparent" v-for="typeProjects in projectsByType" :key="typeProjects[0].projectType">
      <v-card flat color="transparent">
        <v-card-title>
          {{typeProjects[0].projectType}} Projects
        </v-card-title>
        <v-card-text>
          <v-row>
            <v-col cols="10" lg="5" v-for="project in typeProjects" :key="project.projectId">
              <!--make a project component-->
            </v-col>
          </v-row>
        </v-card-text>
      </v-card>

    </v-sheet>

  </v-container>
</template>

<script lang="ts">
import { bindToQueryString, ListViewModel } from "coalesce-vue";
  import { Component, Vue } from "vue-property-decorator";
  import * as ViewModels from "@/viewmodels.g";
  import * as $models from "@/models.g";
  import _ from 'lodash';
  export default class Projects extends Vue {
    projects = new ViewModels.ProjectsListViewModel();
    currProject = new ViewModels.ProjectsViewModel();
    showEdit = false;

    created() {
      this.loadProjects();
      bindToQueryString(this, this.projects.$params, "search")
  }

    async loadProjects() {
      this.projects.$pageSize = 100;
      this.projects.$startAutoLoad(this, { wait: 150 });
      await this.projects.$load();
    }

    get projectsByType(): ViewModels.ProjectsViewModel[][] {
      const typeProjects: ViewModels.ProjectsViewModel[][] = _.chain(
        this.projectsArray
      )
        .groupBy((t) => (t.projectType ?? "No Type")).values().value();
      return typeProjects;
    }


    get projectsArray() {
      const projectsArray = this.projects.$items;
      return projectsArray;
      }

  }

</script>