/* eslint-disable no-extra-semi */
// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
export function twoSum(array1, array2) {
  let num = String(array1).replace(/,/g, '');
  let num2 = String(array2).replace(/,/g,'');

  return Number(num) + Number(num2);
}

/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean} whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  const digits = String(value).split("").reverse().join('');
  
  return String(value) === digits; 

}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {

  if(input === null || input === undefined || input.trim().length === 0) { return "Required field"};
  
  if(Number.isNaN(Number(input)) || input === '0')
  {
    return "Must be a number besides 0"
  }
  else 
  {
    return ''
  }

}
