using System;
namespace DepartTP1
{
    public class CardCell
    {
        private int value;
        private bool isMarked;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public bool IsMarked
        {
            get { return this.isMarked; }
            set { this.isMarked = value; }
        }

        public CardCell(int value)
        {
            this.Value = value;
        }

        public void MarkCell(int number)
        {
            if(this.Value == number)
            {
                this.IsMarked = true;
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}

