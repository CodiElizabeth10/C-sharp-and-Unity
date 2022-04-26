using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Download : MonoBehaviour
{
    // Start is called before the first frame update
    public static Download Instance { get; private set; }

    [RuntimeInitializeOnLoadMethod]
    private static void Init()
    {

    }
    }
