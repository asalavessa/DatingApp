import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Dating App';
  users: any;

  constructor(private http: HttpClient) {}
  ngOnInit() {
    this.getUsers();                                  //Good practice to write the code outside the "ngOnInit" method,
  }                                                   //and then call that code as a method when needed

  getUsers() {
    this.http.get("https://localhost:5001/api/users").subscribe(response => {
      this.users = response;
    }, error => {
        console.log(error);
    })
  }
}
