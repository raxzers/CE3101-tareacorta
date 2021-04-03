import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChContentComponent } from './ch-content.component';

describe('ChContentComponent', () => {
  let component: ChContentComponent;
  let fixture: ComponentFixture<ChContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
