using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D Rigid; //public=seen in inspector  private=invisible in inspector   
    //USE AND DECLARE SHIT HERE FROM NOW ON ^^^^^^^^^^^^
    public float JumpForce; //float=decimals
                            //public int JumpForceInt; //int= whole number

    //public Animator Anim;

    //public GameObject GameOverText;
    // Use this for initialization


    public float FuelLevel = 100;
    public float BurnRate;

    public Image FuelBar;



	void Start () {
        //Rigid = gameObject.GetComponent<RigidBody2D>();  //use this if you declared it grabs the component inside the <>   
        //dont use shit like this^ again!!!^^^^^^
        
	}
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetKeyDown(KeyCode.Space) == true)
        // {

        // Anim.SetBool("SpaceCheck", true);
        //Anim.SetBool("JumpDown", true);
        //  }

        FuelLevel = FuelLevel - BurnRate * Time.deltaTime;

        if(FuelLevel <= 0)
        {
            Destroy(this.gameObject);
        }

        FuelBar.fillAmount = FuelLevel / 100;

        if (Input.GetKey(KeyCode.Space) == true)
        {
            Rigid.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
           // Anim.SetBool("SpaceCheck", false);
            //Anim.SetBool("JumpUp", true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Rock")
        {
            Destroy(gameObject);
            //GameOverText.SetActive(true);
        }   

        if (collision.gameObject.tag == "Fuel")
        {
            FuelLevel = FuelLevel + 30;
        }
    }


  
}
