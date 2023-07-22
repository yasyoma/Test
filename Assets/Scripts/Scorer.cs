using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits;
    void OnCollisionEnter(Collision other)
    {
        hits = hits + 1;
        Debug.Log("Ти вдарився таку кількість разів:" + hits);
    }
}
