using System;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Rating
{
    public class RatingManage : ISpendable
    {
        private event Action ValueChanged;
        public static RatingManage Instance { get; } = new RatingManage();


        public string Type => "Rating";


        public int Count { get; private set; }


        public void Add(int amount)
        {
            Count += amount;
            ValueChanged?.Invoke();
            Debug.Log($"Rating add: {amount}. Current Count={Count}");
        }


        public void Spend(int amount)
        {
            Count -= amount;
            ValueChanged?.Invoke();
            Debug.Log($"Rating spend: {amount}. Current Count={Count}");
        }


        public void AddValueChangeListener(Action onValueChange)
        {
            ValueChanged += onValueChange;
        }


        public void RemoveValueChangeListener(Action onValueChange)
        {
            ValueChanged -= onValueChange;
        }
    }
}