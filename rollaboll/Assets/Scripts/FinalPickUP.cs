using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPickUP : MonoBehaviour
{
    public GameObject FPick = null;
    // Start is called before the first frame update
    void Start()
    {
        FPick.SetActive(false);
    }

    public void MakeFinalVisible()
    {
        FPick.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
