import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface ApplicationUserViewModel extends $models.ApplicationUser {
  applicationUserId: number | null;
  name: string | null;
  birthDate: Date | null;
}
export class ApplicationUserViewModel extends ViewModel<$models.ApplicationUser, $apiClients.ApplicationUserApiClient, number> implements $models.ApplicationUser  {
  
  constructor(initialData?: DeepPartial<$models.ApplicationUser> | null) {
    super($metadata.ApplicationUser, new $apiClients.ApplicationUserApiClient(), initialData)
  }
}
defineProps(ApplicationUserViewModel, $metadata.ApplicationUser)

export class ApplicationUserListViewModel extends ListViewModel<$models.ApplicationUser, $apiClients.ApplicationUserApiClient, ApplicationUserViewModel> {
  
  constructor() {
    super($metadata.ApplicationUser, new $apiClients.ApplicationUserApiClient())
  }
}


export interface ProjectsViewModel extends $models.Projects {
  projectId: number | null;
  name: string | null;
  description: string | null;
}
export class ProjectsViewModel extends ViewModel<$models.Projects, $apiClients.ProjectsApiClient, number> implements $models.Projects  {
  
  constructor(initialData?: DeepPartial<$models.Projects> | null) {
    super($metadata.Projects, new $apiClients.ProjectsApiClient(), initialData)
  }
}
defineProps(ProjectsViewModel, $metadata.Projects)

export class ProjectsListViewModel extends ListViewModel<$models.Projects, $apiClients.ProjectsApiClient, ProjectsViewModel> {
  
  constructor() {
    super($metadata.Projects, new $apiClients.ProjectsApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  ApplicationUser: ApplicationUserViewModel,
  Projects: ProjectsViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  ApplicationUser: ApplicationUserListViewModel,
  Projects: ProjectsListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

