// @ts-check
//
// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Determines whether or not you need a licence to operate a certain kind of vehicle.
 *
 * @param {string} kind
 * @returns {boolean} whether a license is required
 */
export function needsLicense(kind) {
  return kind === "car" || kind === "truck"
}

/**
 * Helps choosing between two options by recommending the one that
 * comes first in dictionary order.
 *
 * @param {string} option1
 * @param {string} option2
 * @returns {string} a sentence of advice which option to choose
 */
export function chooseVehicle(option1, option2) {
  let result = option1.localeCompare(option2);
  // •	Se a primeira string for “menor” alfabeticamente do que a segunda, o valor retornado será -1.
	// •	Se as duas strings forem iguais, o valor retornado será 0.
	// •	Se a primeira string for “maior” alfabeticamente do que a segunda, o valor retornado será 1.
  if(result === -1)
    return option1 + " is clearly the better choice.";
  else
    return option2 + " is clearly the better choice.";

}
  

/**
 * Calculates an estimate for the price of a used vehicle in the dealership
 * based on the original price and the age of the vehicle.
 *
 * @param {number} originalPrice
 * @param {number} age
 * @returns {number} expected resell price in the dealership
 */
export function calculateResellPrice(originalPrice, age) {
  if(age > 10){
    return originalPrice * .5
  }
  else if(age < 3){ 
    return originalPrice * .8;
  } 
  else{
    return originalPrice * .7; 
  }
} 
