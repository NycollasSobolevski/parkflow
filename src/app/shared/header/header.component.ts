import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-header',
  imports: [],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent {
  @Output() menuToggle = new EventEmitter<void>();

  onToggleMenu(event: Event) {
    event.stopPropagation(); // Impede a propagação do evento para o documento
    this.menuToggle.emit(); // Emite o evento para o componente pai
  }
}