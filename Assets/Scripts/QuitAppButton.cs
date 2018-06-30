using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class QuitAppButton : MonoBehaviour 
{	
	private void Start()
	{
		Button button = GetComponent<Button>();

		button.onClick.AddListener(HandleQuit);
	}

	private void HandleQuit()
	{
		Application.Quit();
	}
}
