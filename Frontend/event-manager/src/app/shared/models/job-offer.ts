import { PositionType } from './../enums/position-type';
export class JobOffer {
  id: number;
  positionType: PositionType;
  event: Event;
  salary: number;
  hour: number;

  constructor(id: number, positionType: PositionType, event: Event, salary: number, hour: number){
    this.id = id;
    this.positionType = positionType;
    this.event = event;
    this.salary = salary;
    this.hour = hour;
  }
}
