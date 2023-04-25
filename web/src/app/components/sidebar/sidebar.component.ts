import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss'],
})
export class SidebarComponent implements OnInit {
  workingPosition?: string | null = 'Working position';
  name?: string | null = 'User Name';
  imageUrl?: string = './assets/images/default_avatar.png';
  isAdmin?: boolean = true;

  constructor() {}

  ngOnInit(): void {
    // this.imageUrl = String(localStorage.getItem('profile_img_url'))?.replace(
    //   's96-c',
    //   's198-c'
    // );
    // this.name = String(localStorage.getItem('user_name'));
  }
}
