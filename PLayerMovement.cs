using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{

	public CharacterController2D controller;
	public Animator animator;
	float HorizontalMove = 0f;

	public float runspeed = 40f;
	bool crouch = false;
	bool jump = false;
	bool shoot = false;
	// Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
		HorizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

		animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));
		animator.SetBool("IsShooting", shoot);
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

		if (Input.GetButtonDown("Shoot"))
		{
			shoot = true;
		} else if (Input.GetButtonUp("Shoot"))
		{
			shoot = false;
		}
		
		
			
}

	 public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}

	private void FixedUpdate()
	{

		controller.Move(HorizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;

	}

}
