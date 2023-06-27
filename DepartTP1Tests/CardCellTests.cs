using Microsoft.VisualStudio.TestTools.UnitTesting;
using DepartTP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartTP1.Tests
{
    public class CardCellTests
    {
        private void MakeSureThisMethodCompiles()
        {
            CardCell cell = new CardCell(7);

            int value = cell.Value;
            bool isMarked = cell.IsMarked;
            cell.MarkCell(7);
        }

        /*
         * Placez vos tests ici
         */
    }
}