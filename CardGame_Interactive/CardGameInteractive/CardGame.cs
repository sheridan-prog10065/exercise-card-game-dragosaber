﻿namespace CardGameInteractive
{
    /// <summary>
    /// Defines the card game that implements the game ligic and holds the card
    /// </summary>
    public class CardGame
    {
        /// <summary>
        /// Represents the deck of cards the game is using
        /// </summary>
        private CardDeck _cardDeck;

        /// <summary>
        /// The score of the game
        /// </summary>
        private Score _score;

        /// <summary>
        /// The last card played by the user
        /// </summary>
        private Card _playerCard;

        /// <summary>
        /// The last card played by the house
        /// </summary>
        private Card _houseCard;
    }
}
