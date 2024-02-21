import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent {

  public eventos: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('https://localhost:7150/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );

    this.eventos = [
      {
        Tema: 'Angular',
        Local: 'Rio de Janeiro'
      },
      {
        Tema: '.NET 5',
        Local: 'São Paulo'
      },
      {
        Tema: 'Angular e Suas Novidades',
        Local: 'Belo Horizonte'
      }
    ]
  }

}
