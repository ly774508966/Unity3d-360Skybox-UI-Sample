using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NavDrawer : MonoBehaviour {
	

	private Button[] button = new Button[3];
	public Material mat1;
	public Material mat2;
	private Button backButton;
	private Button nextButton;
	private Button menuButton;
	public Image bckgnd;
	public Image navDrawer;
	private Animator anim;


	void Start(){
		button = GetComponentsInChildren<Button> ();

		anim = navDrawer.GetComponent<Animator> ();

		menuButton = button[0];
		backButton = button[1];
		nextButton = button[2];


		menuButton.onClick.AddListener (taskOnMenuButtonClick);
		backButton.onClick.AddListener (taskOnBackButtonClick);
		nextButton.onClick.AddListener (taskOnNextButtonClick);
	}

	void taskOnMenuButtonClick(){
		navDrawer.gameObject.SetActive (true);
		anim.Play ("NavigationDrawerAnimation", -1, 0f);
		menuButton.gameObject.SetActive (false);
	}

	void taskOnBackButtonClick(){
		if (bckgnd.IsActive()) {
			navDrawer.gameObject.SetActive (true);
			anim.Play ("NavigationDrawerAnimation", -1, 0f);
			bckgnd.gameObject.SetActive (false);
		} else if(navDrawer.IsActive()) {
			navDrawer.gameObject.SetActive (false);
			menuButton.gameObject.SetActive (true);
		}
	}

	void taskOnNextButtonClick(){
		if (RenderSettings.skybox == mat1) {
			RenderSettings.skybox = mat2;
		} else {
			RenderSettings.skybox = mat1;
		}
	}
}