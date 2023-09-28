using System;
using TestShop.Core;

namespace TestShop.Health
{
    [Serializable]
    public class HealthManageWrap : ISpendable
    {
        public int Count => HealthManage.Instance.Count;


        public string Type => HealthManage.Instance.Type;


        public void Add(int amount)
        {
            HealthManage.Instance.Add(amount);
        }


        public void Spend(int amount)
        {
            HealthManage.Instance.Spend(amount);
        }


        public void AddValueChangeListener(Action onValueChange)
        {
            HealthManage.Instance.AddValueChangeListener(onValueChange);
        }


        public void RemoveValueChangeListener(Action onValueChange)
        {
            HealthManage.Instance.RemoveValueChangeListener(onValueChange);
        }
    }
}