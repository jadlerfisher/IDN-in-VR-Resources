//Using this script requires you to build a NavMesh
//Unity presents this procedure here: https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{

    public float m_range;
    // Update is called once per frame
    void Update()
    {


        this.GetComponent<NavMeshAgent>().SetDestination(this.transform.position * m_range * Random.insideUnitCircle);


    }
}
