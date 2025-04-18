import { Component } from '@angular/core';
import { NewPlayerFormComponent } from "../../shared/components/new-player-form/new-player-form.component";

@Component({
  selector: 'fm-new-player',
  imports: [NewPlayerFormComponent],
  templateUrl: './new-player.component.html',
  styleUrl: './new-player.component.scss'
})
export class NewPlayerComponent {

}
