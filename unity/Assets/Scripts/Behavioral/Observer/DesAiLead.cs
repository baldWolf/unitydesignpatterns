using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DesAiLead : MonoBehaviour
{
	List<DesAi> m_listeners = new List<DesAi>();

	//-------------------------------------
	// Add ai to list.
	//-------------------------------------

	public void Add( DesAi Ai)
	{
		m_listeners.Add (Ai);
	}

	//-------------------------------------
	// Retrieve the current length of the ai list.
	//-------------------------------------

	public long GetAiCount()
	{
		return m_listeners.Count;
	}

	//-------------------------------------
	// Set ai's running.
	//-------------------------------------

	public void SetAiRunning()
	{
		int i = 0;
		while (i < m_listeners.Count) 
		{
			m_listeners [i].Running ();
			++i;
		}
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void SetAiMoveUp()
	{
		int i = 0;
		while (i < m_listeners.Count) 
		{
			m_listeners [i].MoveUp ();
			++i;
		}
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void SetAiMoveDown()
	{
		int i = 0;
		while (i < m_listeners.Count) 
		{
			m_listeners [i].MoveDown ();
			++i;
		}
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void SetAiMoveLeft()
	{
		int i = 0;
		while (i < m_listeners.Count) 
		{
			m_listeners [i].MoveLeft ();
			++i;
		}
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void SetAiRotateLeft()
	{
		int i = 0;
		while (i < m_listeners.Count) 
		{
			m_listeners [i].RotateLeft ();
			++i;
		}
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void SetAiMoveRight()
	{
		int i = 0;
		while (i < m_listeners.Count) 
		{
			m_listeners [i].MoveRight ();
			++i;
		}
	}

	//-------------------------------------
	//
	//-------------------------------------

	public void SetAiRotateRight()
	{
		int i = 0;
		while (i < m_listeners.Count) 
		{
			m_listeners [i].RotateRight ();
			++i;
		}
	}
}
