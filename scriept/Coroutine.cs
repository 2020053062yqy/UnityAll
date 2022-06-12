using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    IEnumerator CoroutinEx()
    {
        Debug.Log("1111111111111111111");
        Debug.Log(Time.time);
        yield return new WaitForSeconds(2f);
        Debug.Log("2222222222222222222");
        Debug.Log(Time.time);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CoroutinEx");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
