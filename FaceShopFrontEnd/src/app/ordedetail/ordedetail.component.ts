import { Component, OnInit } from '@angular/core';
import { ActivatedRoute ,Router} from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ordedetail',
  templateUrl: './ordedetail.component.html',
  styleUrls: ['./ordedetail.component.css']
})
export class OrdedetailComponent implements OnInit {
  id: number;
  subRoute: any;
  order: any;
  orderdetai: any;
  index: number;
  constructor(
    private route: ActivatedRoute,
    private http: HttpClient,
    public router: Router,
  ) { }

  async ngOnInit() {
    this.subRoute = await this.route.params.subscribe(params => {
      this.id = params.id;
    });
    this.http.get('https://localhost:44346/api/Order/GetAllById/' + this.id).subscribe(x => {
    this.order = x;
    console.log(x);
    });
    await this.http.get('https://localhost:44346/api/OrderDetail/searchOrderDetailByOrderId/' + this.id).subscribe(x => {
      this.orderdetai = x;
      console.log(x);
    });
  }
  quaylai() {
    this.router.navigate(["/home"]);
  }
  huydonhang() {
    this.http.get('https://localhost:44346/api/Order/LockOrderByOrderId/' + this.id).subscribe(x => {
      this.router.navigate(["/home"]);
      console.log(x);
    });
    
  }
}
