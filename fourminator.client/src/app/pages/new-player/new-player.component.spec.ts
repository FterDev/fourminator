import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewPlayerComponent } from './new-player.component';
import { TranslateFakeLoader, TranslateLoader, TranslateModule } from '@ngx-translate/core';

describe('NewPlayerComponent', () => {
  let component: NewPlayerComponent;
  let fixture: ComponentFixture<NewPlayerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewPlayerComponent, TranslateModule.forRoot({
              loader: {
                provide: TranslateLoader,
                useClass: TranslateFakeLoader
              }})],
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewPlayerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
