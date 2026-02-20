import { Component, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ApiService } from './core/services/api';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App implements OnInit {

  protected readonly title = signal('ecommerce-app');
  public message = '';

  constructor(private api: ApiService) {
  }

  ngOnInit(): void {
    this.load();
  }

  load() {
    this.api.getHealth().subscribe({
      next: (data: any) => {
        if (data.success) {
          console.log('API Health Response:', data.success, data.message);
          this.message = data.message;
        }
      },
      error: (error) => {
        this.message = `Error fetching API health: ${error.message}`;
      }
    });
  }
}
