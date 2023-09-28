using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestShop.Core
{
    public interface ISpendable
    {
        public int Count { get; }


        public void Add(int amount);



        public void Spend(int amount);
    }
}