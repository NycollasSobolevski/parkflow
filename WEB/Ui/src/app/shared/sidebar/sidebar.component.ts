import { AllLinks, ILinks, Links } from './Links/utilLinks';
import { Component, Input, Output, EventEmitter } from '@angular/core';
import {MatIconModule} from "@angular/material/icon"
import UserService from '../../domain/user/user.service';
import { SysAdminLinks } from './Links/sysAdminLinks';
import { LocalAdminLinks } from './Links/localAdminLinks';
import { VigilantLinks } from './Links/vigilanteLinks';
import { UserLinks } from './Links/userlinks';
import { PublicLinks } from './Links/publicLinks';
@Component({
  selector: 'app-sidebar',
  imports: [MatIconModule],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent {
  @Input() menuAberto = false;
  @Output() fecharMenu = new EventEmitter<void>();
  protected links?: Links;

  constructor(
    private userService: UserService,
  ) { }

  ngOnInit(): void {
    switch (this.userService.getUserLevel()) {
      case 0:
        this.links = SysAdminLinks;
        break;
      case 1:
        this.links = LocalAdminLinks;
        break;
      case 2:
        this.links = VigilantLinks;
        break;
      case 3:
        this.links = UserLinks;
        break;
      default:
        this.links = PublicLinks;
    }
    this.links;
  }
}
