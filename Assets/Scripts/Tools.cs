using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tools
{
    public static Transform FindFromAllChildren(this Transform father, string targetName)
    {
        Transform target = father.Find(targetName);
        if (target != null)
            return target;

        for (int i = 0; i < father.childCount; i++)
        {
            target = father.GetChild(i).FindFromAllChildren(targetName);

            if (target != null)
                return target;
        }

        return target;
    }
}
