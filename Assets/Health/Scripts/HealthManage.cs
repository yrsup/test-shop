using System;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Health
{
    public class HealthManage : ISpendable
    {
        private event Action ValueChanged;
        public static HealthManage Instance { get; } = new HealthManage();


        public string Type => "Health";


        public int Count { get; private set; }


        public void Add(int amount)
        {
            Count += amount;
            ValueChanged?.Invoke();
            Debug.LogError($"Health add: {amount}. Current Count={Count}");
        }


        public void Spend(int amount)
        {
            Count -= amount;
            ValueChanged?.Invoke();
            Debug.LogError($"Health spend: {amount}. Current Count={Count}");
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