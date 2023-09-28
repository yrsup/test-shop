using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
