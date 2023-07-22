using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCla : MonoBehaviour
{
    private void Start()
    {
        print(transform.FindFromAllChildren("Target").name);
        print(transform.FindFromAllChildren("Target2").name);
        print(transform.FindFromAllChildren("target3").name);       
    }
}
