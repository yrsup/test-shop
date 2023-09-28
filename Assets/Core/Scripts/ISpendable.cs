using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestShop.Core
{
    public interface ISpendable
    {
        public string Type { get; }


        public int Count { get; }


        public void Add(int amount);



        public void Spend(int amount);


        public void AddValueChangeListener(Action onValueChange);

        public void RemoveValueChangeListener(Action onValueChange);
    }
}