using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Turn : StateMachineBehaviour
{
    public GameObject Self;
    public GameObject Player;
    public GameObject PointEncrage;
    public float TurnDirection;
    public static float TurnCD;
    public static float AttackCD;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PointEncrage = GameObject.FindGameObjectWithTag("PointEncrage");
        Self = Player.GetComponent<Deplacement>().adversaire;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AttackCD -= 1 * Time.deltaTime;
        TurnCD -= 1 * Time.deltaTime;
        if (TurnCD <= 0)
        {
            TurnCD = Random.Range(Self.GetComponent<Enemy>().turnCD.x, Self.GetComponent<Enemy>().turnCD.y);
            animator.SetTrigger("Turn");
        }
        if (AttackCD <= 0)
        {
            AttackCD = Self.GetComponent<Enemy>().attackCD;
            animator.SetTrigger("Turn");
        }
        Self.transform.RotateAround(PointEncrage.transform.position, new Vector3(0, 0, TurnDirection), 20 * Time.deltaTime);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
