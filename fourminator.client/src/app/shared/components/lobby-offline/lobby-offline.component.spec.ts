import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LobbyOfflineComponent } from './lobby-offline.component';

describe('LobbyOfflineComponent', () => {
  let component: LobbyOfflineComponent;
  let fixture: ComponentFixture<LobbyOfflineComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LobbyOfflineComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LobbyOfflineComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
