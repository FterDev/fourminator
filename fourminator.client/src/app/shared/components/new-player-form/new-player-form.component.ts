import { Component } from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatInputModule} from '@angular/material/input';
import { TranslatePipe } from '@ngx-translate/core';
@Component({
  selector: 'fm-new-player-form',
  imports: [MatCardModule, MatButtonModule, MatFormFieldModule, MatInputModule, MatCheckboxModule, TranslatePipe],
  templateUrl: './new-player-form.component.html',
  styleUrl: './new-player-form.component.scss'
})
export class NewPlayerFormComponent {

}
