using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculBuahSayur : MonoBehaviour
{
    public float jeda = 1.5f;
    public float ukuranTetap = 1.0f; // Ukuran tetap yang diinginkan
    float timer;
    public GameObject[] objekBuahSayur;

    // Start is called before the first frame update
    void Start()
    {
        timer = jeda;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            int random = Random.Range(0, objekBuahSayur.Length);

            // Set vertical position to be the same as the spawner's position
            Vector3 randomPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            GameObject newObject = Instantiate(objekBuahSayur[random], randomPos, transform.rotation);
            newObject.transform.localScale = new Vector3(ukuranTetap, ukuranTetap, ukuranTetap); // Menggunakan ukuran tetap
            timer = jeda;
        }
    }
}
