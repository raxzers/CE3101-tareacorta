import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LchefComponent } from './lchef.component';

describe('LchefComponent', () => {
  let component: LchefComponent;
  let fixture: ComponentFixture<LchefComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LchefComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LchefComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
