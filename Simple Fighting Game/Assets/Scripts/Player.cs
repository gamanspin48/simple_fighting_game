using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    //0 idle
    //1 left punch
    //2 right punch
    //3 left hook
    //4 right hook
    //5 combo attack
    //6 elbow attack
    //7 ready fight idle
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

}
