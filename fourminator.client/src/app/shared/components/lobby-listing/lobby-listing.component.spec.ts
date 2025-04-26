import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LobbyListingComponent } from './lobby-listing.component';

describe('LobbyListingComponent', () => {
  let component: LobbyListingComponent;
  let fixture: ComponentFixture<LobbyListingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LobbyListingComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LobbyListingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
