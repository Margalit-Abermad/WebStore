import { TestBed } from '@angular/core/testing';

import { SignInServiceService } from './sign-in-service.service';

describe('SignInServiceService', () => {
  let service: SignInServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SignInServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
