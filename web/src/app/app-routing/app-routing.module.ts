import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from '../pages/login-page/login-page.component';
import { ConfigurationPageComponent } from '../pages/configuration-page/configuration-page.component';
import { BenefitsPageComponent } from '../pages/benefits-page/benefits-page.component';
import { RegisterUserPageComponent } from '../pages/register-user-page/register-user-page.component';
import { UserProfilePageComponent } from '../pages/user-profile-page/user-profile-page.component';
import { UsersPageComponent } from '../pages/users-page/users-page.component';
import { VacationsPageComponent } from '../pages/vacations-page/vacations-page.component';
import { DashboardComponent } from '../components/dashboard/dashboard.component';
import { MyProfilePageComponent } from '../pages/my-profile-page/my-profile-page.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full',
  },

  {
    path: 'login',
    component: LoginPageComponent,
    data: {
      requiresLogin: false,
    },
  },

  {
    path: 'app',
    component: DashboardComponent,
    children: [
      {
        path: 'my-profile',
        component: MyProfilePageComponent,
      },

      {
        path: 'configuration',
        component: ConfigurationPageComponent,
      },

      {
        path: 'users',
        component: UsersPageComponent,
      },

      {
        path: 'vacations',
        component: VacationsPageComponent,
      },

      {
        path: 'benefits',
        component: BenefitsPageComponent,
      },

      {
        path: 'register-user',
        component: RegisterUserPageComponent,
      },

      {
        path: 'user-profile/:id',
        component: UserProfilePageComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
