import { Routes } from '@angular/router';
import { LandingPageComponent } from './pages/landing-page/landing-page.component';
import { PageNotFoundComponent } from './shared/components/page-not-found/page-not-found.component';
import { NewPlayerComponent } from './pages/new-player/new-player.component';

export const routes: Routes = [
  {path: '', pathMatch: "full", component: LandingPageComponent, title: '4-MINATOR'},
  {path: 'new-player', component: NewPlayerComponent, title: 'New Player'},
  {path: '**', component: PageNotFoundComponent, title: '404'}
];
