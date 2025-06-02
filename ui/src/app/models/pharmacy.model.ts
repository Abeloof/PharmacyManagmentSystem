import { Medication } from "./medication.model";

export interface Pharmacy {
  pharmacyId: number;
  name: string;
  state: string;
  city: string;
  medications: Medication[];
}
