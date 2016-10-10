using UnityEngine;
using System.Collections;

public class DesController : MonoBehaviour 
{
	// Ai Lead.
	[SerializeField]
	DesAiLead lead = null;

	// Ai Prefab.

	[SerializeField]
	GameObject m_aiPawns = null;

	//-------------------------------------
	//
	//-------------------------------------

	void Awake()
	{
		this.Initialise ();
	}

	//-------------------------------------
	// Use this for initialization
	//-------------------------------------

	void Start () 
	{

	}

	//-------------------------------------
	// Initialise the Ai's
	//-------------------------------------

	void Initialise()
	{
		int i = 0;

		while (i < 3) 
		{
			GameObject aiObject = (GameObject)Instantiate(
				m_aiPawns,
				new Vector3( ( i + (-3*i) ), 0, 5),
				new Quaternion());
			
			aiObject.GetComponent<DesAi> ().Initialise (lead);

			++i;
		}
	}

	//-------------------------------------
	// Update is called once per frame
	//-------------------------------------

	void Update()
	{
		if (Input.GetKeyUp (KeyCode.UpArrow)) 
		{
			//lead.SetAiMoveUp ();
		} 

		else if (Input.GetKeyUp (KeyCode.DownArrow)) 
		{
			//lead.SetAiMoveDown ();
		} 

		else if (Input.GetKeyUp (KeyCode.LeftArrow)) 
		{
			lead.SetAiRotateLeft ();
		} 

		else if (Input.GetKeyUp (KeyCode.RightArrow)) 
		{
			lead.SetAiRotateRight ();
		}
	}
}
