using System;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Rating
{
    [Serializable]
    public class RatingReward : IReward
    {
        [field: SerializeField]
        public int Vlaue { get; private set; }


        public ISpendable Consumer => RatingManage.Instance;


        public void Apply()
        {
            Consumer.Add(Vlaue);
        }
    }
}
