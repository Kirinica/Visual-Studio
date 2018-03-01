using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MegaChallengeWar
{
    public class Battle
    {
        private List<Card> _bounty;
        private StringBuilder _sb;
        private object card;

        public Battle(Card card)
        {
            _bounty = new List<Card>();
            _sb = new StringBuilder();
        }

        public Battle()
        {
        }

        public string PerformBattle(Player player1, Player player2)
        {
            Card player1Card = GetCard(player1);
            Card player2Card = GetCard(player2);

            performEvaluation(player1, player2, player1Card, player2Card);
            return _sb.ToString();

        }
        private Card GetCard(Player player)
        {
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            _bounty.Add(card);
            return card;
        }
        private void performEvaluation(Player player1, Player player2, Card card1, Card card2)
        {
            displayBattleCards(card1, card2);
            if (card1.CardValue() == card2.CardValue())
                war(player1, player2);
            if (card1.CardValue() > card2.CardValue())
               awardWinner(player1);
            else
               awardWinner(player2);

        }

        private void awardWinner(Player player)
        {
            if (_bounty.Count == 0) return;
            displayBountyCards();
            player.Cards.AddRange(_bounty);
            _bounty.Clear();
        }

        private void displayBattleCards(Card card1, Card card2)
        {
            throw new NotImplementedException();
        }

        private void war(Player player1, Player player2)
        {
            GetCard(player1);
            Card warcard1 = GetCard(player1);
            GetCard(player1);

            GetCard(player2);
            Card warcard2 = GetCard(player2);
            GetCard(player2);

            performEvaluation(player1, player2, warcard1, warcard2);
        }

        private void displayBattleCArds(Card card1, Card card2)
        {
            _sb.Append("</br>Battle Cards: ");
            _sb.Append(card1.Kind);
            _sb.Append(" ");
            _sb.Append(card1.Suit);
            _sb.Append(" versus ");
            _sb.Append(card2.Kind);
            _sb.Append(" of ");
            _sb.Append(card2.Suit);
        }

        private void displayBountyCards()
        {
            _sb.Append("</br>Bounty ...");
            foreach (var card in _bounty)
            {

            }
            _sb.Append("</br>&nbsp;&nbsp;&nbsp;&nbsp;");
            _sb.Append(card.Kind);
            _sb.Append(" of ");
            _sb.Append(card.Suit);
        }
    }
}