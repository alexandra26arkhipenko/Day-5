using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JaggedArraySort2
{
    class Formater : IComparer<int[]>
    {
        private Comparison<int[]> delegateForm;

        public Formater(Comparison<int[]> delegateForm)
        {
            this.delegateForm = delegateForm;
        }

         public int Compare(int[] x, int[] y)
        {
           return delegateForm(x, y);
        }
    }
}
