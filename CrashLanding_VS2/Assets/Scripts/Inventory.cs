using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

  public static Inventory instance;

  public delegate void OnItemChanged();
  public OnItemChanged onItemChangedCallback;

  void Awake (){
    if (instance != null){
      Debug.LogWarning("More than one instance of Inventory found!");
      return;
    }

    instance = this;
  }

  public List<Item> items = new List<Item>();

  public void Add (Item item){

    items.Add(item);

    if(onItemChangedCallback != null)
      onItemChangedCallback.Invoke();
  }

}
