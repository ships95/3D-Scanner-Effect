using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerController : MonoBehaviour
{
    [Header("speed")]
    public float speed;

    [Header("destroy time")]
    public float delayDestroyTime;

    // Start is called before the first frame update
    void Start()
    {
        DestroyScanner();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = this.transform.localScale;
        float growing = this.speed * Time.deltaTime;
        this.transform.localScale = new Vector3(scale.x + growing, scale.y + growing, scale.z + growing);
    }

    private void DestroyScanner()
    {
        Destroy(this.gameObject, delayDestroyTime);
    }
}
