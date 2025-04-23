import { Component, Input, Output, EventEmitter } from '@angular/core';
import {MatIconModule} from "@angular/material/icon"
@Component({
  selector: 'app-sidebar',
  imports: [MatIconModule],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent {
  @Input() menuAberto = false;
  @Output() fecharMenu = new EventEmitter<void>();
}
