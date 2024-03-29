import { HttpClient } from '@angular/common/http';
import { Component, ViewChild, AfterViewInit, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { merge, Observable, of as observableOf } from 'rxjs';
import { catchError, map, startWith, switchMap } from 'rxjs/operators';
import { User } from 'src/app/data/User.model';
import { AuthService } from 'src/app/services/auth.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-users-page',
  templateUrl: './users-page.component.html',
  styleUrls: ['./users-page.component.scss'],
})
export class UsersPageComponent implements OnInit {
  users: User[] = [];
  filteredUsers = this.users;
  p: number = 1;
  sortByNameASC: Boolean = true;
  userSearch: String = '';

  constructor(
    private userService: UserService,
    private router: Router,
    private authService: AuthService
  ) {}

  ngOnInit(): void {
    this.getUsers();
  }

  private getUsers() {
    this.userService.getAllUsers().subscribe((response) => {
      this.users = response.data;
      this.sortByName();
      this.filteredUsers = this.users;
    });
  }

  filterUsers() {
    if (this.userSearch) {
      this.filteredUsers = this.users.filter((u) =>
        u.full_name.toUpperCase().includes(this.userSearch.toUpperCase())
      );
    } else {
      this.filteredUsers = this.users;
    }
  }

  loadUserProfile(userId: number) {
    this.authService.getUserId().subscribe((response) => {
      if (response == userId) {
        this.router.navigate(['app/my-profile']);
      } else {
        this.router.navigate(['app/user-profile', userId]);
      }
    });
  }

  public sortByName() {
    if (this.sortByNameASC) {
      this.users.sort((a, b) =>
        a.first_name > b.first_name ? 1 : b.first_name > a.first_name ? -1 : 0
      );
    } else {
      this.users.sort((a, b) =>
        a.first_name < b.first_name ? 1 : b.first_name < a.first_name ? -1 : 0
      );
    }

    this.sortByNameASC = !this.sortByNameASC;
  }
}
