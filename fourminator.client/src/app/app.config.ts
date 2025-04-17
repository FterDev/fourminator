import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import {provideTranslateService} from "@ngx-translate/core";
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';

export const appConfig: ApplicationConfig = {
  providers: [
    provideZoneChangeDetection({ eventCoalescing: true }),
    provideTranslateService({
      defaultLanguage: 'en'
    }),
    provideRouter(routes)
  ]
};
