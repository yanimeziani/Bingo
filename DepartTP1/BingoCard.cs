using System;
using System.Reflection.Emit;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

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

		public BingoCard(int nbLines, NumberGenerator generator)
		{
			this.CardCells = new CardCell[nbLines,nbLines];
			FillCard(generator);
		}

		private void FillCard(NumberGenerator generator) {
			for(int row = 0;row < CardCells.GetLength(0); row++) {
                for (int column = 0; column < CardCells.GetLength(1); column++)
                {
					this.CardCells[row, column] = new CardCell(generator.Next());
                }
            }
		}

		public void MarkNumber(int number) {
            for (int row = 0; row < CardCells.GetLength(0); row++)
            {
                for (int column = 0; column < CardCells.GetLength(1); column++)
                {
					this.CardCells[row, column].MarkCell(number);
                }
            }
        }

        public int ComputeScore()
        {
            int score = 0;

            // Check rows
            for (int row = 0; row < CardCells.GetLength(0); row++)
            {
                if (RowComplete(row))
                    score += SumRow(row);
            }

            // Check columns
            for (int column = 0; column < CardCells.GetLength(1); column++)
            {
                if (ColumnComplete(column))
                    score += SumColumn(column);
            }

            return score;
        }

        private bool RowComplete(int row)
        {
            for (int column = 0; column < CardCells.GetLength(1); column++)
            {
                if (!CardCells[row, column].IsMarked)
                    return false;
            }

            return true;
        }

        private bool ColumnComplete(int column)
        {
            for (int row = 0; row < CardCells.GetLength(0); row++)
            {
                if (!CardCells[row, column].IsMarked)
                    return false;
            }

            return true;
        }

        private int SumRow(int row)
        {
            int sum = 0;

            for (int column = 0; column < CardCells.GetLength(1); column++)
            {
                sum += CardCells[row, column].Value;
            }

            return sum;
        }

        private int SumColumn(int column)
        {
            int sum = 0;

            for (int row = 0; row < CardCells.GetLength(0); row++)
            {
                sum += CardCells[row, column].Value;
            }

            return sum;
        }

        // Code pris en partie sur stackoverflow (Le stringbuilder)
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < CardCells.GetLength(0); row++)
            {
                for (int column = 0; column < CardCells.GetLength(1); column++)
                {
                    sb.Append(CardCells[row, column]);
                    if(CardCells[row, column].IsMarked) {
                        sb.Append("+");
                    }
                        
                    sb.Append("\t");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}

