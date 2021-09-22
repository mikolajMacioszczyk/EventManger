import { Address } from './address';
export class Event {
  id: number;
  name: string;
  description: string;
  eventDate: Date;
  eventAddress: Address;
  poster: string;

  constructor( id: number, name: string, description: string,
    eventDate: Date, eventAddress: Address, poster: string
  ){
    this.id = id;
    this.name = name;
    this.description = description;
    this.eventDate = eventDate;
    this.eventAddress = eventAddress;
    this.poster = poster;
  }
}
