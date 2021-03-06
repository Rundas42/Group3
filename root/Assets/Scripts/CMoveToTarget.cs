﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class CMoveToTarget : MonoBehaviour 
{
    public Animator anim;
    public GameObject player;
    public GameObject p;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = transform.GetChild(0).gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        //Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    
 
    void FixedUpdate()
    {

        NavMeshAgent nma = GetComponent<NavMeshAgent>();
        nma.SetDestination(player.transform.position);
      
        anim.SetFloat("move", nma.velocity.magnitude);
        float dist = Vector3.Distance(gameObject.transform.position, player.transform.position);
        anim.SetFloat("distance", dist);
        if (dist < 1.2)
        {
            //anim.SetTrigger("attack");           
        }

    }

    
}
