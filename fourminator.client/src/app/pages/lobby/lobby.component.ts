import { Component } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import {MatDividerModule} from '@angular/material/divider';
import { LobbyListingComponent } from "../../shared/components/lobby-listing/lobby-listing.component";
import { LobbyOfflineComponent } from "../../shared/components/lobby-offline/lobby-offline.component";

@Component({
  selector: 'fm-lobby',
  imports: [MatCardModule, MatDividerModule, LobbyListingComponent, LobbyOfflineComponent],
  templateUrl: './lobby.component.html',
  styleUrl: './lobby.component.scss'
})
export class LobbyComponent {

}
