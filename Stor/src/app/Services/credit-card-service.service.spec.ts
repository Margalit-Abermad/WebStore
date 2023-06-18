import { TestBed } from '@angular/core/testing';

import { CreditCardServiceService } from './credit-card-service.service';

describe('CreditCardServiceService', () => {
  let service: CreditCardServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CreditCardServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
