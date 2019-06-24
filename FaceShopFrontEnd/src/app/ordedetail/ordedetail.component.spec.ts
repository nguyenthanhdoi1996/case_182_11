import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrdedetailComponent } from './ordedetail.component';

describe('OrdedetailComponent', () => {
  let component: OrdedetailComponent;
  let fixture: ComponentFixture<OrdedetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrdedetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrdedetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
