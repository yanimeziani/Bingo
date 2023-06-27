using System;
namespace DepartTP1
{
	public class BingoCard
	{
		private CardCell[,] cardCells;

		public CardCell[,] CardCells
		{
			get { return cardCells; }
			set { this.cardCells = value; }
		}

		public BingoCard(byte nbLines, NumberGenerator generator)
		{
			this.CardCells = new CardCell[nbLines,nbLines];
		}
	}
}

