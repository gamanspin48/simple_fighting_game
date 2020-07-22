using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{   
    public Animator animator;
    public bool isBlocking;
    public const string PARAM_STATE = "aksi";
    public const string PARAM_BLOCK = "isBlocking";
    // Start is called before the first frame update

    void Awake(){
        animator = GetComponent<Animator>();
     
    }

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hitted(int state){
        Debug.Log("hitted");
        float rand = Random.Range(0.0f, 1.0f);
        // if (rand > 0.0f && rand <= 0.2f)
        //     isBlocking = true;
        animator.SetInteger(PARAM_STATE,state);
        animator.SetBool(PARAM_BLOCK,isBlocking);
        
    }

    public void Reset(){
        animator.SetInteger(PARAM_STATE,0);
        animator.SetBool(PARAM_BLOCK,false);
    }


}
