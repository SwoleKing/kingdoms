using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedUnit : MonoBehaviour {

    public GameObject selectedUnit;

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void setSelectedUnit(GameObject selected)
    {
        if (selectedUnit == null)
        {
            selectedUnit = selected;
            selectedUnit.GetComponentInChildren<Select>().isSelected = true;
        }
        else
        {
            selectedUnit.GetComponentInChildren<Select>().isSelected = false;
            selectedUnit = selected;
            selectedUnit.GetComponentInChildren<Select>().isSelected = true;
        }
    }
}
