using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick (){
        FadeManager.Instance.LoadScene ("StageChoice", 0.3f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
