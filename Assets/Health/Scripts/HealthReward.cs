using System;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Health
{
    [Serializable]
    public class HealthReward : IReward
    {
        [field: SerializeField]
        public int Vlaue { get; private set; }


        public ISpendable Consumer => HealthManage.Instance;


        public void Apply()
        {
            Consumer.Add(Vlaue);
        }
    }
}
