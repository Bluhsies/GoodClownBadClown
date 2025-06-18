using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ShootBall : MonoBehaviour
{

        [SerializeField] private ObjectPooler sc;
        public float projectilePower = 10f;

    public AnimateHandOnInput hand;

    public void Update()
        {



            sc.SpawnPrefab();

            FireFood();
        


        }


        public void FireFood()
        {

            Rigidbody projectile = sc.ballPrefab.GetComponent<Rigidbody>();

            projectile.AddForce(sc.spawnPosition.TransformDirection(Vector3.forward) * Mathf.Clamp(projectilePower, 10f, 25f), ForceMode.Impulse);

            

        }


        public void SpawnBall()
        {

            sc.SpawnPrefab();

        }


}
