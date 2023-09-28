using System;
using TestShop.Core;


namespace TestShop.Gold
{
    [Serializable]
    public class GoldManageWrap : ISpendable
    {
        public int Count => GoldManage.Instance.Count;


        public void Add(int amount)
        {
            GoldManage.Instance.Add(amount);
        }


        public void Spend(int amount)
        {
            GoldManage.Instance.Spend(amount);
        }
    }
}

