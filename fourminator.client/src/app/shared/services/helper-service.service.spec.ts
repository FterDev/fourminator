import { TestBed } from '@angular/core/testing';

import { HelperService } from './helper-service.service';

describe('HelperServiceService', () => {
  let service: HelperService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HelperService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should return a uniqueIdentifier in lower or equal 9999', () => {

    const heighestNumer = 9999;

    const res = service.generateUniqueIdentifier();

    expect(res).toBeLessThanOrEqual(heighestNumer);
  });

  it('should return a uniqueIdentifier in heigher or equal 1111', () => {

    const lowesNumber = 1111;

    const res = service.generateUniqueIdentifier();

    expect(res).toBeGreaterThanOrEqual(lowesNumber);
  });


  it('should return a guid in correct format', () => {

    const guidRegex = /^[0-9a-f]{8}-[0-9a-f]{4}-4[0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$/i;

    const res = service.generateGuid();

    expect(res).toMatch(guidRegex);
  })




});

