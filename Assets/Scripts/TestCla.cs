using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class TestCla : MonoBehaviour
{
    public GameObject createObj;

    private void Start()
    {
        print(transform.FindFromAllChildren("Target").name);
        print(transform.FindFromAllChildren("Target2").name);
        print(transform.FindFromAllChildren("target3").name);       
    }

    private void Update()
    {
        ClickToCreate();
    }

    private void ClickToCreate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (createObj == null)
                createObj = GameObject.CreatePrimitive(PrimitiveType.Cube);

            Vector3 screenPos = Input.mousePosition;
            screenPos.z = 20;
            Vector3 pos = Camera.main.ScreenToWorldPoint(screenPos);

            Instantiate(createObj, pos, transform.rotation);
        }
    }
}
