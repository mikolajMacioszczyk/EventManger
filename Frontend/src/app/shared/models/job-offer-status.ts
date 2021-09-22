import { OfferStatus } from './../enums/offer-status';
import { Employee } from './employee';
import { JobOffer } from './job-offer';

export class JobOfferStatus {
  id: number;
  employee: Employee;
  jobOffer: JobOffer;
  status: OfferStatus;

  constructor(id: number, employee: Employee, jobOffer: JobOffer, status: OfferStatus){
    this.id = id;
    this.employee = employee;
    this.jobOffer = jobOffer;
    this.status = status;
  }
}
