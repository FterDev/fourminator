import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';

import translateEn from '../../public/i18n/en.json';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {

  constructor(private translateService: TranslateService)
  {
    translateService.setTranslation('en', translateEn);
    translateService.setDefaultLang('en');
  }
  title = 'fourminator.client';
}
