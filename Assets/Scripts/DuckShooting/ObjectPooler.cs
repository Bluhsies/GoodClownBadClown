using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{


    public GameObject ballPrefab;
    public int poolSize;
    public Dictionary<GameObject, bool> pool = new Dictionary<GameObject, bool>();
    public Transform spawnPosition;
    public Transform tempPosition;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = (GameObject)Instantiate(ballPrefab, tempPosition.position, Quaternion.identity);

            pool.Add(obj, true);

            obj.SetActive(false);
        }
    }

    public void SpawnPrefab()
    {

        foreach (KeyValuePair<GameObject, bool> obj in pool)
        {
            if (obj.Value == true)
            {
                ballPrefab = obj.Key;
                break;
            }
        }

        pool[ballPrefab] = false;

        ballPrefab.SetActive(true);

        ballPrefab.transform.position = spawnPosition.position;

        StartCoroutine(ReturnPrefab(ballPrefab));
    }


    IEnumerator ReturnPrefab(GameObject selPrefab)
    {


        yield return new WaitForSeconds(5.0f);
        selPrefab.transform.position = tempPosition.position;
        selPrefab.SetActive(false);
        selPrefab.GetComponent<Rigidbody>().velocity = Vector3.zero;

        pool[selPrefab] = true;

    }


   
   

}
