import { Paitent } from "./paitent.model";
import { Pharmacy } from "./pharmacy.model";
import { Prescriber } from "./prescriber.model";

export interface Medication {
  medicationId: number;
  medicationName: string;
  dose: number;
  isGeneric: boolean;
  instruction: string;
  refilAmmount: number;
  frequency: number;
  cost: number;
  patient: Paitent;
  prescriber: Prescriber;
  pharmacy: Pharmacy;
  pharmacyId: number,
  prescriberId: number
}
