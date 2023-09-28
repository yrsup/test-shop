using System;
using System.Collections;
using System.Collections.Generic;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Gold
{
    [Serializable]
    public class GoldReward : IReward
    {
        [field: SerializeField]
        public int Vlaue { get; private set; }


        public ISpendable Consumer => GoldManage.Instance;


        public void Apply()
        {
            Consumer.Add(Vlaue);
        }
    }
}
