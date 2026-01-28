using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    // Start is called before the first frame update
    public static Locator Instance { get; private set;  }
    public static W4Pigeon Player { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this) {
            Destroy(this);
            return;
        }
        
        Instance = this;

        GameObject playerObj = GameObject.FindWithTag("Player");
        Player = playerObj.GetComponent<W4Pigeon>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
