using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIHandler : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] ItemDataBaseSO Database;
    [SerializeField] GameObject itembutton;
    [SerializeField] ScrollRect itemsscroll;
    [SerializeField] CanvasGroup previewpanel;
    [SerializeField] List<GameObject> IntantiateButtoms = new();
    [SerializeField] Image iconitem;
    [SerializeField] TextMeshProUGUI amountitem;
    [SerializeField] TextMeshProUGUI nameitem;

    private void Start()
    {
        Instiantiatebuttons();
        ShowItems();
    }

    public void Instiantiatebuttons()
    {
        for (int i = 0; i < Database.Items1.Count; i++)
        {
            IntantiateButtoms.Add(Instantiate(itembutton, itemsscroll.content));
            IntantiateButtoms[i].SetActive(false);
        }
    }
    public void ShowItems()
    {
        foreach (var item in inventory.Items)
        {
            ItemdataSO itemdata = Database.SearchItemByID(item.Key);
            GameObject SearchedButtom = IntantiateButtoms.Find(item => item.activeSelf == false);
            SearchedButtom.SetActive(true);
            SearchedButtom.transform.Find("Image").GetComponent<Image>().sprite = itemdata.Sprite;
            SearchedButtom.transform.Find("Amount").GetComponent<TextMeshProUGUI>().text = item.Value.ToString();
            SearchedButtom.GetComponent<Button>().onClick.AddListener(delegate
            {
                Showpreviewpanel();
                Showitempreview(itemdata,item.Value);

            });
        }
    }
    public void Showitempreview(ItemdataSO itemdata, int amount)
    {
        iconitem.sprite = itemdata.Sprite;
        nameitem.text = itemdata.name;
        amountitem.text = amount.ToString();
    }
    public void Showpreviewpanel()
    {
        previewpanel.alpha = 1;
        previewpanel.interactable = true;
        previewpanel.blocksRaycasts = true;
    }
}
