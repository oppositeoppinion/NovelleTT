using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;
using static Naninovel.Command;

public class ItemsHandler : MonoBehaviour
{
    public static ItemsHandler Instance;
    [SerializeField] private List<Image> _slots;
    [SerializeField] private List<Image> _items;
    [SerializeField] private List<String> _itemsListName;
    [SerializeField] private List<Image> _itemsListImage;
    //here supposed to be dictionary, but its takes too much time to ork with dictionatrys without Odin Serializer
    private void Awake()
    {
        if(Instance == null) Instance = this;
        else Destroy(this);
    }
    private void Start()
    {
        AllSlotsToDefault();
    }

   

    private void AllSlotsToDefault()
    {
        foreach (var item in _slots)
        {
            item.color = new Color(1, 1, 1, 0.1f);
        }
        foreach (var item in _items)
        {
            item.enabled = false;
        }
    }
    
    public void GetItem(string itemName)
    {
        Debug.Log("entering getattestate");
        if (_itemsListName.Contains(itemName))
        {
            Debug.Log("item is present");
            _items[0].enabled = true;
            _items[0].sprite = _itemsListImage[0].sprite;
        }
    }
    public void GiveItem()
    {
        AllSlotsToDefault();
    }
    [ContextMenu("get item func test")]

    public void DBG()
    {
        Debug.Log("dbg");
        GetItem("Attestate");
    }
}
