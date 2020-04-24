using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        onEnable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Menu Enabling
    void onEnable() {
        var a = AssetDatabase.LoadAssetAtPath( "Assets/hierarchy.uxml"); 
        VisualElement row = a.CloneTree(); 

        var label = row.Query(className: "test");
        label.RegisterCallback<MouseUpEvent>( evt => evt.StopPropagation()); 

        rootVisualElement.Add(row);
    }
}
