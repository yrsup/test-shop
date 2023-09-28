using System.Collections;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Health
{
    public class HealthManage : ISpendable
    {
        public static HealthManage Instance { get; } = new HealthManage();


        public int Count { get; private set; }


        public void Add(int amount)
        {
            Count += amount;
            Debug.LogError($"Health add: {amount}. Current Count={Count}");
        }


        public void Spend(int amount)
        {
            Count -= amount;
            Debug.LogError($"Health spend: {amount}. Current Count={Count}");
        }
    }
}