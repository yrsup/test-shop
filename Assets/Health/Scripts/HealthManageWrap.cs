using System;
using TestShop.Core;

namespace TestShop.Health
{
    [Serializable]
    public class HealthManageWrap : ISpendable
    {
        public int Count => HealthManage.Instance.Count;


        public void Add(int amount)
        {
            HealthManage.Instance.Add(amount);
        }


        public void Spend(int amount)
        {
            HealthManage.Instance.Spend(amount);
        }
    }
}