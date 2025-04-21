import { Component, HostListener } from '@angular/core';
import { HeaderComponent } from "./shared/header/header.component";
import { SidebarComponent } from "./shared/sidebar/sidebar.component";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [HeaderComponent, SidebarComponent],
})
export class AppComponent {
  menuAberto = false;

  @HostListener('document:click', ['$event'])
  fecharMenu(event: MouseEvent) {
    const alvo = event.target as HTMLElement;
    if (
      this.menuAberto &&
      !alvo.closest('.sidebar') &&
      !alvo.closest('#menu-button')
    ) {
      this.menuAberto = false;
    }
  }

  toggleMenu() {
    this.menuAberto = !this.menuAberto;
  }

  fecharMenuAoClicar() {
    this.menuAberto = false;
  }
}
