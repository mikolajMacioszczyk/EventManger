import { EmployeeGroup } from "./employee-group";

export class EventManagement {
  id: number;
  event: Event;
  employeeGroups: EmployeeGroup[];

  constructor(id: number, event: Event, employeeGroups: EmployeeGroup[]){
    this.id = id;
    this.event = event;
    this.employeeGroups = employeeGroups;
  }
}
