using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Inventory : MonoBehaviour
{
    //public Image[] itemImages = new Image[numItemSlots];
    public Dictionary<string, Dictionary<string, ArrayList>> inventory = new Dictionary<string, Dictionary<string, ArrayList>>();
    private ArrayList fp = new ArrayList();
    private ArrayList pj = new ArrayList();
    private ArrayList sh = new ArrayList();
    public Queue q = new Queue();

	private void Start()
	{
        
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.tag == "Enemy"){
            if (collision.name.Contains("force"))
            {
                fp.Add(collision.name);
                q.Enqueue(collision.name);
            }
            else if (collision.name.Contains("projectile"))
            {
                pj.Add(collision.name);
                q.Enqueue(collision.name);
            }
            else
            {
                sh.Add(collision.name);
                q.Enqueue(collision.name);
            }
            
        }
	}

    public void UseAbility() {
        q.Dequeue();
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