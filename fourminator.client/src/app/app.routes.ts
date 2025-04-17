import { Routes } from '@angular/router';
import { LandingPageComponent } from './pages/landing-page/landing-page.component';
import { PageNotFoundComponent } from './shared/components/page-not-found/page-not-found.component';

export const routes: Routes = [
  {path: '', pathMatch: "full", component: LandingPageComponent},
  {path: '**', component: PageNotFoundComponent}
];
