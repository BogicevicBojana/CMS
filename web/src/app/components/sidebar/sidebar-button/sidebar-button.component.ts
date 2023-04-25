import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar-button',
  templateUrl: './sidebar-button.component.html',
  styleUrls: ['./sidebar-button.component.scss'],
})
export class SidebarButtonComponent implements OnInit {
  @Input() buttonText: string = '';
  @Input() iconSrc: string = '';
  @Input() passedRoutes?: string[];

  constructor(public router: Router) {}

  ngOnInit(): void {}
}
