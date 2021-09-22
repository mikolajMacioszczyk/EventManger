import { PositionType } from './../enums/position-type';
export class Employee {
  id: number;
  firstName: string;
  lastName: string;
  birthDate: Date;
  positionType: PositionType;
  offerStatueses: JobOfferStatus[];

  constructor(id: number, firstName: string, lastName: string, birthDate: Date, positionType: PositionType, offerStatueses: JobOfferStatus[]){
    this.id = id;
    this.firstName = firstName;
    this.lastName = lastName;
    this.birthDate = birthDate;
    this.positionType = positionType;
    this.offerStatueses = offerStatueses;
  }
}
