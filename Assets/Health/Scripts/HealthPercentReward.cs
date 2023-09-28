using System;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Health
{
    [Serializable]
    public class HealthPercentReward : IReward
    {
        [field: SerializeField]
        public int Vlaue { get; private set; }


        public ISpendable Consumer => HealthManage.Instance;


        public void Apply()
        {
            int currentHealth = Consumer.Count;
            float additionalHealth = (float)Vlaue / 100f;
            currentHealth += Mathf.RoundToInt(additionalHealth);
            Consumer.Add(currentHealth);
        }
    }
}
