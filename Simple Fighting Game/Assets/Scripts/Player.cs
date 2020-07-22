using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    //0 idle
    //1 left punch
    //2 left hook
    //3 right punch
    //4 right hook
    //5 combo attack 1
    //6 elbow attack
    //7 ready fight idle
    //8 combo attack 2
    public int state;
    public Animator animator;
    public const string PARAMETER = "aksi";
    
    
    void Awake(){
        animator = GetComponent<Animator>();
     
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeState(int value){
        // Debug.Log("hit"+value);
        state++;
        if (state == 5)
            state = 1;
        animator.SetInteger(PARAMETER,state);
       
    }

    public void ElbowAttack(Vector2 delta){
        Debug.Log(delta);
        if (delta.x < delta.y && delta.y >= 100){
             animator.SetInteger(PARAMETER,6);
        }
    }

}
