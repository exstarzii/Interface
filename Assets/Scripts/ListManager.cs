using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListManager : MonoBehaviour
{
    public ListRowElement listRowPrefub;
    public Transform container;
    public List<ListRowElement> rows;

    public void Start()
    {
        rows = new List<ListRowElement>(container.GetComponentsInChildren<ListRowElement>());
    }
    public void AddElemToList()
    {
        var prefub = Instantiate(listRowPrefub);
        prefub.transform.SetParent(container);
        rows.Add(prefub);
    }
    public void DelElemFromList()
    {
        if (rows.Count > 0)
        {
            var elem = rows.Last();
            elem.gameObject.SetActive(false);
            Destroy(elem.gameObject);
            rows.Remove(elem);
        }
    }

    public void CheckAllToggle(bool value)
    {
        foreach (var item in rows)
        {
            item.toggle.isOn = value;
        }
    }
    public void CheckAllEyeToggle(bool value)
    {
        foreach (var item in rows)
        {
            item.eyeToggle.isOn = value;
        }
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
