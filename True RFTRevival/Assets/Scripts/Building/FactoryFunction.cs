using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ProgressIndicator))]
public class FactoryFunction : MonoBehaviour
{
    [SerializeField] BuildingStorage Storage;
    [SerializeField] List<Storage> ItemRequired;
    [SerializeField] GameObject ItemProduced;
    [SerializeField] ProgressIndicator Indicator;
    IEnumerator run;
    void Awake(){
        Storage.ab.AddListener();
    }
    void MakeProduct(){

    }
    IEnumerator Progress(){
        for(int i = 0 ; i < 5 ; i++){
            yield return new WaitForSeconds(1.0f);
        }
    }
}
