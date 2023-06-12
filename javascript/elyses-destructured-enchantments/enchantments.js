/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Get the first card in the given deck
 *
 * @param {Card[]} deck
 *
 * @returns {Card} the first card in the deck
 */
export function getFirstCard(deck) {
  const [first] = deck;
  return first; 
}

/**
 * Get the second card in the given deck
 *
 * @param {Card[]} deck
 *
 * @returns {Card} the second card in the deck
 */
export function getSecondCard(deck) {
  const [first, second] = deck; 
  return second; 
}

/**
 * Switch the position of the first two cards in the given deck
 *
 * @param {Card[]} deck
 *
 * @returns {Card[]} new deck with reordered cards
 */
export function swapTopTwoCards(deck) {
  let newDeck = [...deck] 
  let [first, second] = deck; 
  let temp;
  temp = first; 
  newDeck[0] = second;
  newDeck[1] = temp; 

  return newDeck
}

/**
 * Put the top card of the given deck into a separate discard pile
 *
 * @param {Card[]} deck
 *
 * @returns {[Card, Card[]]} the top card of the given
 * deck and a new deck containing all the other cards
 */
export function discardTopCard(deck) {
  
  let newDeck = [];

  if(deck.length === 1) {newDeck = [deck[1], []]}
  newDeck = [deck[0], [...deck].slice(1)]

  return newDeck; 
}

/** @type Card[] **/
const FACE_CARDS = ['jack', 'queen', 'king'];

/**
 * Insert face cards into the given deck
 *
 * @param {Card[]} deck
 *
 * @returns {Card[]} new deck where the second,
 * third, and fourth cards are the face cards
 */
export function insertFaceCards(deck) {
  
  let newDeck = [...deck];

  newDeck.splice(1,0,'jack')
  newDeck.splice(2,0,'queen')
  newDeck.splice(3,0,'king')

  return newDeck;

}
