import { Component, OnInit , Inject} from '@angular/core';
import { ActivatedRoute , Router} from '@angular/router';
import { HttpClient } from '@angular/common/http';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
export interface DialogData {
  Id: number;
  Order: any;
}
@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {
  subRoute: any;
  order: any;
  product: any;
  id: number;
  showAddNew = false;
  orderdetai: any;
  orderItem: any;
  constructor(
    private route: ActivatedRoute,
    private http: HttpClient,
    public dialog: MatDialog,
    public router: Router,
  ) { }

  async ngOnInit() {
     this.subRoute = await this.route.params.subscribe(params => {
      this.id = params.id;
     });
     this.http.get('https://localhost:44346/api/Order/GetAllByUserId/' + this.id).subscribe(x => {
        this.order = x;
        console.log(x);
      });
  }
   showCreateModal(id) {
    this.router.navigate(["home/orderDetail", id]);
  }
  closeDialog() {
    this.showAddNew = false;
  }
//   openDialog(id: Number, item): void {
//     console.log(id,item);
// // tslint:disable-next-line: no-use-before-declare
//     const dialogRef = this.dialog.open(DialogOverviewExampleDialog, {
//       width: '80%',
//       data: { Id: id, Order: item},
//     });
//     dialogRef.afterClosed().subscribe(result => {
//       console.log('The dialog was closed');
//      // this.orderdetail = result;
//     });
//   }
}
// @Component({
//   selector: 'dialog-overview-example-dialog',
//   templateUrl: 'order-dialog.html',
// })
// // tslint:disable-next-line: component-class-suffix
// export class DialogOverviewExampleDialog implements OnInit {
//   orderdetai: any;
//   order: any
//   constructor(
//     private http: HttpClient,
//     public dialogRef: MatDialogRef<DialogOverviewExampleDialog>,
//     @Inject(MAT_DIALOG_DATA) public data: DialogData) {}
//     ngOnInit() {

//     this.order = this.data.Order;
//     console.log(this.order);
//   }
//   onNoClick(): void {
//     this.dialogRef.close();
//   }

// }
