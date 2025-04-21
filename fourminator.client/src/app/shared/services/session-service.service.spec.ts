import { TestBed } from '@angular/core/testing';

import { SessionServiceService } from './session-service.service';
import Session from '../data/session';

describe('SessionServiceService', () => {
  let service: SessionServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SessionServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should create an item in localStorage', () => {
    const storageName = 'fm-session';
    const nickname = 'test';
    const remember = true;

    service.setSession(nickname, remember);

    expect(JSON.parse(localStorage.getItem(storageName)!).user.nickname).toBe(nickname);
  });

  it('should create an item in sessionStorage', () => {
    const storageName = 'fm-session';
    const nickname = 'test';
    const remember = false;

    service.setSession(nickname, remember);

    expect(JSON.parse(sessionStorage.getItem(storageName)!).user.nickname).toBe(nickname);
  });


  it('should remove the item from sessionStorage', () => {
    const storageName = 'fm-session';
    const nickname = 'test';
    const remember = false;

    service.setSession(nickname, remember);

    service.deleteSession();

    expect(sessionStorage.getItem(storageName)).toEqual(null);
  });

  it('should remove the item from localStorage', () => {
    const storageName = 'fm-session';
    const nickname = 'test';
    const remember = false;

    service.setSession(nickname, remember);

    service.deleteSession();

    expect(localStorage.getItem(storageName)).toEqual(null);
  });




});
