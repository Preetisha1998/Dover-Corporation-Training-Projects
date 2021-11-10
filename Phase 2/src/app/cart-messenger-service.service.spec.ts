import { TestBed } from '@angular/core/testing';

import { CartMessengerServiceService } from './cart-messenger-service.service';

describe('CartMessengerServiceService', () => {
  let service: CartMessengerServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CartMessengerServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
