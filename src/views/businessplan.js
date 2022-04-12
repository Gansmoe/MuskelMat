import { Page } from "../page.js";

export const businessPlan = new Page("Businessplan");

businessPlan.createElement("h1", "Affärsplan");
businessPlan.createElement("p", "Denna app ska vara en receptbank för den träningsintresserade. Man ska kunna mata in sitt dagliga kalori- och proteinbehov och sedan få en veckomatsedel baserat på detta. I veckomatsedeln ska det ingå frukost, lunch, middag och två mellanmål, men om man vill ska man bara kunna få fram t.ex. middag och lunch. Tanken är att man ska slippa lägga väldigt mycket tid på att leta i receptbanker efter kalorisnåla, mättande, proteinrika men goda maträtter.");