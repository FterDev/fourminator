import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewPlayerFormComponent } from './new-player-form.component';
import { TranslateFakeLoader, TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { RouterModule } from '@angular/router';

describe('NewPlayerFormComponent', () => {
  let component: NewPlayerFormComponent;
  let fixture: ComponentFixture<NewPlayerFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewPlayerFormComponent,
                  TranslateModule.forRoot({
                    loader: {
                      provide: TranslateLoader,
                      useClass: TranslateFakeLoader
                    }}),
                  RouterModule.forRoot([]),

                ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewPlayerFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
