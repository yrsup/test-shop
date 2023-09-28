using System;
using TestShop.Core;

namespace TestShop.Shop.Ui
{
    public class SpendableListener
    {
        private readonly Action onValueChanged;
        private readonly ISpendable spendable;



        public SpendableListener(ISpendable spendable, Action onValueChanged)
        {
            this.spendable = spendable;
            this.onValueChanged = onValueChanged;
        }


        public void StartListen()
        {
            spendable.AddValueChangeListener(OnValueChanged);
        }


        public void StopListen()
        {
            spendable.RemoveValueChangeListener(OnValueChanged);
        }


        private void OnValueChanged()
        {
            onValueChanged?.Invoke();
        }
    }
}
