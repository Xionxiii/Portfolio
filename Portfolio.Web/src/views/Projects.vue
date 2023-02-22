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
        <v-text-field v-model="project.$params.search" prepend-inner-icon="fa fa-search" label="Search through the Projects" clearable autofocus />
      </v-col>

    </v-row>

  </v-container>
</template>

<script lang="ts">
import { ListViewModel } from "coalesce-vue";

  export default class Projects extends Vue {
    project = new ListViewMod
  }

</script>