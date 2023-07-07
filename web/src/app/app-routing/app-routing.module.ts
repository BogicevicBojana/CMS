import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from '../pages/login-page/login-page.component';
import { ConfigurationPageComponent } from '../pages/configuration-page/configuration-page.component';
import BenefitsPageComponent from '../pages/benefits-page/benefits-page.component';
import { RegisterUserPageComponent } from '../pages/register-user-page/register-user-page.component';
import { UserProfilePageComponent } from '../pages/user-profile-page/user-profile-page.component';
import { UsersPageComponent } from '../pages/users-page/users-page.component';
import { VacationsPageComponent } from '../pages/vacations-page/vacations-page.component';
import { DashboardComponent } from '../components/dashboard/dashboard.component';
import { MyProfilePageComponent } from '../pages/my-profile-page/my-profile-page.component';
import { AccessGuard } from '../access.guard';

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
    canActivate: [AccessGuard],
    component: DashboardComponent,

    data: {
      requiresLogin: true,
    },

    children: [
      {
        path: 'my-profile',
        canActivate: [AccessGuard],
        component: MyProfilePageComponent,
        data: {
          requiresLogin: true,
        },
      },

      {
        path: 'configuration',
        canActivate: [AccessGuard],
        component: ConfigurationPageComponent,
        data: {
          requiresLogin: true,
        },
      },

      {
        path: 'users',
        canActivate: [AccessGuard],
        component: UsersPageComponent,
        data: {
          requiresLogin: true,
        },
      },

      {
        path: 'vacations',
        canActivate: [AccessGuard],
        component: VacationsPageComponent,
        data: {
          requiresLogin: true,
        },
      },

      {
        path: 'benefits',
        canActivate: [AccessGuard],
        component: BenefitsPageComponent,
        data: {
          requiresLogin: true,
        },
      },

      {
        path: 'register-user',
        canActivate: [AccessGuard],
        component: RegisterUserPageComponent,
        data: {
          requiresLogin: true,
        },
      },

      {
        path: 'user-profile/:id',
        canActivate: [AccessGuard],
        component: UserProfilePageComponent,
        data: {
          requiresLogin: true,
        },
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
