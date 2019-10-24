import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from './models/employees';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  private apiURL = 'http://localhost:61388/api/Employee';

  constructor(private httpClient: HttpClient) { }

  public createEmployee(employee: Employee) {
    return this.httpClient.post(`${this.apiURL}`, employee);
   }

  public updateEmployee(employee: Employee) {
    return this.httpClient.put(`${this.apiURL}/${employee.employeeID}`, employee);
   }

  public getEmployeeById(id: number) {
    return this.httpClient.get(`${this.apiURL}/${id}`);
   }

  public getEmployees() {
    // return this.httpClient.get<Employee[]>(`${this.apiURL}`);
    return this.httpClient.get(`${this.apiURL}`);
  }
}
