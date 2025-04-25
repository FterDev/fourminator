import { SessionService } from './../../services/session-service.service';
import { Component, inject, OnInit } from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatInputModule} from '@angular/material/input';
import { TranslatePipe } from '@ngx-translate/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import { Router } from '@angular/router';


type NewUserForm = {
  nickname: FormControl<string>,
  termsOfUse: FormControl<boolean>
}

@Component({
  selector: 'fm-new-player-form',
  imports: [MatCardModule, MatButtonModule, MatFormFieldModule, MatInputModule, MatCheckboxModule, TranslatePipe, ReactiveFormsModule, MatProgressSpinnerModule],
  templateUrl: './new-player-form.component.html',
  styleUrl: './new-player-form.component.scss'
})


export class NewPlayerFormComponent implements OnInit {

  public form!: FormGroup;
  public loading = true;

  private sessionService = inject(SessionService);
  private router = inject(Router);

  ngOnInit(): void {
    this.form = new FormGroup<NewUserForm>({
      nickname: new FormControl('', { nonNullable: true, validators: [Validators.required]}),
      termsOfUse: new FormControl(false, { nonNullable: true, validators: [Validators.requiredTrue]})
    })
  }


  submit()
  {
    if(this.form.valid)
    {
      this.sessionService.setSession(this.form.get('nickname')?.getRawValue(), true);
      this.router.navigate(['lobby']);
      return;
    }

  }
}
