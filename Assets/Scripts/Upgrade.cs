using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Upgrade : MonoBehaviour
{
    public abstract void GetUpgrade(GameObject player);
    public abstract void Dissapear();
}
