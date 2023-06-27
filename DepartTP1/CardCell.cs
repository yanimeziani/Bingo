using System;
namespace DepartTP1
{
    public class CardCell
    {
        private byte value;
        private bool isMarked;

        public byte Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public bool IsMarked
        {
            get { return this.isMarked; }
            set { this.isMarked = value; }
        }

        public CardCell(byte value)
        {
            this.Value = value;
        }

        public void MarkCell(byte number)
        {
            if(this.Value == number)
            {
                this.IsMarked = true;
            }
        }
    }
}

