using System.Collections;
using System.Collections.Generic;
using TestShop.Core;
using UnityEngine;


namespace TestShop.Gold
{
    public class GoldManage : ISpendable
    {
        public static GoldManage Instance { get; } = new GoldManage();

        public int Count { get; private set; }


        public void Add(int amount)
        {
            Count += amount;
            Debug.LogError($"Gold add: {amount}. Current Count={Count}");
        }


        public void Spend(int amount)
        {
            Count -= amount;
            Debug.LogError($"Gold spend: {amount}. Current Count={Count}");
        }
    }
}

