using UnityEngine;

namespace TestShop.Core
{
    public interface IReward
    {
        public int Vlaue { get; }

        public ISpendable Consumer { get; }
    }
}