import { Address } from './address';
import { Data } from '@angular/router';
import { PositionType } from './../enums/position-type';
export class EmployeeGroup {
  id: number;
  amount: number;
  positionType: PositionType;
  gatheringTime: Data;
  gatheringAddress: Address;
  salary: number;
  hours: number;

  constructor(id: number, amount: number, positionType: PositionType,
    gatheringTime: Data, gatheringAddress: Address, salary: number, hours: number
  ){
    this.id = id;
    this.amount = amount;
    this.positionType = positionType;
    this.gatheringTime = gatheringTime;
    this.gatheringAddress = gatheringAddress;
    this.salary = salary;
    this.hours = hours;
  }
}
