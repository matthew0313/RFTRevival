using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuildingStorage : MonoBehaviour
{
    [SerializeField] GameObject OutputPoint;
    public ItemName AcceptedInput;
    public List<Storage> Storage = new List<Storage>();
    public UnityEvent ab;
    public void _Input(ItemName a){
        Input(a);
        ab.Invoke();
    }
    public void Input(ItemName a){
        bool exist = false;
        for(int i = 0 ; i < Storage.Count ; i++){
            if(Storage[i].Item.HasFlag(a)){
                Storage[i].Amount++;
                exist = true;
                break;
            }
        }
        if(!exist){
            Storage b = new Storage();
            b.Item = a;
            b.Amount = 1;
            Storage.Add(b);
        }
    }
}
[System.Serializable] public class Storage{
    public ItemName Item;
    public int Amount;
}