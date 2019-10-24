import { Component, OnInit } from '@angular/core';
import { UserServiceService } from '../user-service.service';
import { Employee } from '../models/employees';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';


@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {


  private employees: Observable<Employee[]>;
  public filterData: Observable<Employee[]>;

  constructor(private userService: UserServiceService) { }

  ngOnInit() {
    this.employees = this.userService.getEmployees()
      .pipe(map(res => {
        return res;
      }));
    this.filterData = this.employees;
  }

  onChange(event: any) {
    console.log(event.target.value);
    this.search(event.target.value);
  }


  search(term: string) {
    if (term === '') {
      console.log('term is blank');
      this.filterData = this.employees;
    }
    this.filterData = this.employees.pipe(map(employee => employee.filter(emp => emp.firstName.includes(term))));
    console.log(this.filterData);
  }
}
