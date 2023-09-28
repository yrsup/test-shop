using System;
using TestShop.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TestShop.Shop.Ui
{
    public class SpendableBar : MonoBehaviour 
    {
        [SerializeField] private TextMeshProUGUI nameLabel;
        [SerializeField] private TextMeshProUGUI countLabel;
        [SerializeField] private Button addButton;
        [SerializeField] private Button removeButton;
        private ISpendable spendable;


        public void Initialize(ISpendable spendable, Action<ISpendable> onAdd, Action<ISpendable> onRemove)
        {
            this.spendable = spendable;
            nameLabel.text = spendable.Type;

            addButton.onClick.RemoveAllListeners();
            addButton.onClick.AddListener(() => onAdd?.Invoke(spendable));
            removeButton.onClick.RemoveAllListeners();
            removeButton.onClick.AddListener(() => onRemove?.Invoke(spendable));

            UpdateCount();
        }


        public void UpdateCount()
        {
            countLabel.text = spendable.Count.ToString();
        }
    }
}
