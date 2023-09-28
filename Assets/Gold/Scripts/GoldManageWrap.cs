using System;
using TestShop.Core;


namespace TestShop.Gold
{
    [Serializable]
    public class GoldManageWrap : ISpendable
    {
        public int Count => GoldManage.Instance.Count;


        public string Type => GoldManage.Instance.Type;


        public void Add(int amount)
        {
            GoldManage.Instance.Add(amount);
        }


        public void Spend(int amount)
        {
            GoldManage.Instance.Spend(amount);
        }


        public void AddValueChangeListener(Action onValueChange)
        {
            GoldManage.Instance.AddValueChangeListener(onValueChange);
        }


        public void RemoveValueChangeListener(Action onValueChange)
        {
            GoldManage.Instance.RemoveValueChangeListener(onValueChange);
        }
    }
}

