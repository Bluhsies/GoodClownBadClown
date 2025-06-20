using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Occlusion : MonoBehaviour
{

    public GameObject Audiolistener;
    private float MaxDistOcclusion;
    public bool UseOcclusion = false;
    public string RTPC_LoPass = "RTPC_Occlusion_LoPass";
    public string RTPC_Volume = "RTPC_Occlusion_Volume";
    public float LoPass_Max = 1;
    public float Volume_Max = 1;
    public bool UseDebug = false;
    public string NameOfListener = "MainCamera";
    public string[] IgnoreTypeOccluder;


    // Start is called before the first frame update
    void Start()
    {
        MaxDistOcclusion = GetComponent<SphereCollider>().radius;
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if (!UseOcclusion || Audiolistener == null) { return; }

        Vector3 direction = Audiolistener.transform.position - this.transform.position;
        RaycastHit OutInfo;
        bool hit = Physics.Raycast(this.transform.position, direction, out OutInfo, MaxDistOcclusion);

        if (hit)
        {
            if (UseDebug) { print(OutInfo.collider.gameObject.name); }
            for (int i = 0; i < IgnoreTypeOccluder.Length; i++)
            {
                if (OutInfo.collider.gameObject.name != NameOfListener && OutInfo.collider.gameObject.name != IgnoreTypeOccluder[i])
                {

                    AkSoundEngine.SetRTPCValue(RTPC_LoPass, LoPass_Max, gameObject);
                    AkSoundEngine.SetRTPCValue(RTPC_Volume, Volume_Max, gameObject);


                }
                else
                {

                    AkSoundEngine.SetRTPCValue(RTPC_LoPass, 0, gameObject);
                    AkSoundEngine.SetRTPCValue(RTPC_Volume, 0, gameObject);

                }
            }
        }

    }

}
