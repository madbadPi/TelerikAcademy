namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private const int CellCapacity = 64;

        private ulong num;

        public BitArray64(ulong currentNum = 0)
        {
            this.num = currentNum;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > CellCapacity - 1 )
                {
                    throw new ArgumentOutOfRangeException("Invalid index.");
                }
                else
                {
                    //check the bit at position index
                    if ((this.num & (ulong)(1 << index)) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }               
            }
            set
            {
                if (index < 0 || index > CellCapacity - 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid index.");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid value.");
                }
                if (value == 1)
                {
                    //set 1 at position index
                    this.num = this.num | ((ulong)1 << index);
                }
                else
                {
                    //set 0 at position index
                    this.num = this.num & (~((ulong)1 << index));
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return this.num == (obj as BitArray64).num;
        }

        public static bool operator !=(BitArray64 firstNum, BitArray64 secondNum)
        {
            return !(firstNum.Equals(secondNum));
        }

        public static bool operator ==(BitArray64 firstNum, BitArray64 secondNum)
        {
            return firstNum.Equals(secondNum);
        }

        public override int GetHashCode()
        {
            return this.num.GetHashCode();
        }


        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < CellCapacity; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
