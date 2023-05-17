import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AccordionComponent } from './components/accordion/accordion.component';
import { ConfigurationItemComponent } from './components/accordion/configuration-item/configuration-item.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { HeaderComponent } from './components/header/header.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { SidebarButtonComponent } from './components/sidebar/sidebar-button/sidebar-button.component';
import { BenefitsPageComponent } from './pages/benefits-page/benefits-page.component';
import { ConfigurationPageComponent } from './pages/configuration-page/configuration-page.component';
import { LoginPageComponent } from './pages/login-page/login-page.component';
import { MyProfilePageComponent } from './pages/my-profile-page/my-profile-page.component';
import { RegisterUserPageComponent } from './pages/register-user-page/register-user-page.component';
import { UserProfilePageComponent } from './pages/user-profile-page/user-profile-page.component';
import { UsersPageComponent } from './pages/users-page/users-page.component';
import { VacationsPageComponent } from './pages/vacations-page/vacations-page.component';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { AngularSvgIconModule } from 'angular-svg-icon';
import { AppRoutingModule } from './app-routing/app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    AppComponent,
    AccordionComponent,
    ConfigurationItemComponent,
    DashboardComponent,
    HeaderComponent,
    SidebarComponent,
    SidebarButtonComponent,
    BenefitsPageComponent,
    ConfigurationPageComponent,
    LoginPageComponent,
    MyProfilePageComponent,
    RegisterUserPageComponent,
    UserProfilePageComponent,
    UsersPageComponent,
    VacationsPageComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule,
    HttpClientModule,
    AngularSvgIconModule.forRoot(),
    AppRoutingModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
