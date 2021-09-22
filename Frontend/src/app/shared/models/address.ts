export class Address {
  id: number;
  city: string;
  street: string;
  number: number;

  constructor(id: number, city: string, street: string, number: number){
    this.id = id;
    this.city = city;
    this.street = street;
    this.number = number;
  }
}
