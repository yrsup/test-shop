using System;
using TestShop.Core;
using UnityEngine;


namespace TestShop.Gold
{
    public class GoldManage : ISpendable
    {
        private event Action ValueChanged;
        public static GoldManage Instance { get; } = new GoldManage();


        public int Count { get; private set; } = 15;


        public string Type => "Gold";


        public void Add(int amount)
        {
            Count += amount;
            ValueChanged?.Invoke();
            Debug.Log($"Gold add: {amount}. Current Count={Count}");
        }


        public void AddValueChangeListener(Action onValueChange)
        {
            ValueChanged += onValueChange;
        }


        public void RemoveValueChangeListener(Action onValueChange)
        {
            ValueChanged -= onValueChange;
        }


        public void Spend(int amount)
        {
            Count -= amount;
            ValueChanged?.Invoke();
            Debug.Log($"Gold spend: {amount}. Current Count={Count}");
        }
    }
}

