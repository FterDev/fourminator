
import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  imports: [RouterOutlet],
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {

  ngOnInit(): void {

  }

  title = 'fourminator.client';
}
