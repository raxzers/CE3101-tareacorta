import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LadminComponent } from './ladmin.component';

describe('LadminComponent', () => {
  let component: LadminComponent;
  let fixture: ComponentFixture<LadminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LadminComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LadminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
