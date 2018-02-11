using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour {

    public string unitName;

    public Image infoPanel;
    public Text nameText;

	// Use this for initialization
	void Start () {
        
        // unitName = "Archer";
        initInfoPanel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Initializes the info panel
    void initInfoPanel()
    {
        infoPanel.enabled = false;
        nameText.enabled = false;
    }

    void OnMouseDown()
    {
        // Selecting a unit will bring up the unit's card
        if (infoPanel.isActiveAndEnabled)
        {
            disableInfoPanel();
        }
        else
        {
            enableInfoPanel();
        }
    }

    void enableInfoPanel()
    {
        Debug.Log("Unit Selected");
        nameText.text = unitName;
        infoPanel.enabled = true;
        nameText.enabled = true;
    }

    void disableInfoPanel()
    {
        Debug.Log("Unit De-selected");
        infoPanel.enabled = false;
        nameText.enabled = false;

        // If you click on another unit, reopen the panel
        // with the new details
        if (nameText.text != unitName)
        {
            enableInfoPanel();
        }
    }
}
