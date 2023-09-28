using System;
using TestShop.Core;

namespace TestShop.Rating
{
    [Serializable]
    public class RatingManageWrap : ISpendable
    {
        public int Count => RatingManage.Instance.Count;


        public string Type => RatingManage.Instance.Type;


        public void Add(int amount)
        {
            RatingManage.Instance.Add(amount);
        }


        public void Spend(int amount)
        {
            RatingManage.Instance.Spend(amount);
        }


        public void AddValueChangeListener(Action onValueChange)
        {
            RatingManage.Instance.AddValueChangeListener(onValueChange);
        }


        public void RemoveValueChangeListener(Action onValueChange)
        {
            RatingManage.Instance.RemoveValueChangeListener(onValueChange);
        }
    }
}