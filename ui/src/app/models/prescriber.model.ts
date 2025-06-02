import { Medication } from "./medication.model";

export interface Prescriber {
  patientId: number;
  firstName: string;
  lastName: string;
  speciality: string;
  medications: Medication[];
}
