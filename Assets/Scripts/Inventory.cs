using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Inventory : MonoBehaviour
{
    //public Image[] itemImages = new Image[numItemSlots];
    public Dictionary<string, Dictionary<string, ArrayList>> inventory = new Dictionary<string, Dictionary<string, ArrayList>>();
    private Dictionary<string, ArrayList> fp = new Dictionary<string, ArrayList>();
    private Dictionary<string, ArrayList> pj = new Dictionary<string, ArrayList>();

	private void Start()
	{
        inventory.Add("ForcePush", null);
        inventory.Add("Projectile", null);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        //inventory.Add(collision.name, )
	}
	//public Item[] items = new Item[numItemSlots];
	//public const int numItemSlots = 4;
	//public void AddItem(Item itemToAdd)
	//{
	//    for (int i = 0; i < items.Length; i++)
	//    {
	//        if (items[i] == null)
	//        {
	//            items[i] = itemToAdd;
	//            itemImages[i].sprite = itemToAdd.sprite;
	//            itemImages[i].enabled = true;
	//            return;
	//        }
	//    }
	//}
	//public void RemoveItem(Item itemToRemove)
	//{
	//    for (int i = 0; i < items.Length; i++)
	//    {
	//        if (items[i] == itemToRemove)
	//        {
	//            items[i] = null;
	//            itemImages[i].sprite = null;
	//            itemImages[i].enabled = false;
	//            return;
	//        }
	//    }
	//}
}