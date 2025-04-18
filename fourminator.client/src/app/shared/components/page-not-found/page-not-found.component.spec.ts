import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PageNotFoundComponent } from './page-not-found.component';
import { TranslateModule, TranslateLoader, TranslateFakeLoader } from '@ngx-translate/core';

import { By } from '@angular/platform-browser';

describe('PageNotFoundComponent', () => {
  let component: PageNotFoundComponent;
  let fixture: ComponentFixture<PageNotFoundComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PageNotFoundComponent, TranslateModule.forRoot({
        loader: {
          provide: TranslateLoader,
          useClass: TranslateFakeLoader
        }
      })],

    })
    .compileComponents();
    fixture = TestBed.createComponent(PageNotFoundComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should have 404 h2', () => {
    const h2Element = fixture.debugElement.query(By.css('h2'));
    expect(h2Element.nativeElement.textContent).toContain('404');
  });

  it('should have translate placeholder h3', () => {
    const h3Element = fixture.debugElement.query(By.css('h3'));
    expect(h3Element.nativeElement.textContent).toContain('app.system.notfound.message');
  });
});
