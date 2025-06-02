import { Medication } from "./medication.model";

export interface Paitent {
  patientId: number;
  firstName: string;
  lastName: string;
  dateOfBirth: Date;
  insuranceId: number;
  isEnsured: boolean;
  medications: Medication[];
}
