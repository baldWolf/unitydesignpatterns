using UnityEngine;
using System.Collections;

public class DesAi : MonoBehaviour 
{
	//-------------------------------------
	// Constructor.
	//-------------------------------------

	public DesAi(DesAiLead lead)
	{
		lead.Add (this);
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void Initialise(DesAiLead lead)
	{
		lead.Add (this);
	}

	//-------------------------------------
	//
	//-------------------------------------

	void Awake()
	{
		
	}

	//-------------------------------------
	// Use this for initialization
	//-------------------------------------

	void Start () 
	{
	
	}

	//-------------------------------------
	// Update is called once per frame
	//-------------------------------------

	void Update () 
	{
	
	}

	//-------------------------------------
	// Set this Ai running.
	//-------------------------------------

	public void Running()
	{
		
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void MoveUp()
	{
		this.transform.position += Vector3.up;
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void MoveDown()
	{
		this.transform.position += Vector3.down;
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void MoveLeft()
	{
		this.transform.position += Vector3.left;
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void MoveRight()
	{
		this.transform.position += Vector3.right;
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void RotateLeft()
	{
		this.transform.Rotate (0, 5, 0);
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void RotateRight()
	{
		this.transform.Rotate (0, -5, 0);
	}
}
