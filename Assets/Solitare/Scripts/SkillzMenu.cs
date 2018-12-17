using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkillzMenu : DefaultMenu
{

	// Use this for initialization
	void Start ()
	{
        
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public override void OnButtonClick(Button bt)
	{
	}

	public override void OnToggleChange (Toggle tg)
	{
	}

	public override void OnScreenChange(float w, float h)
	{
		if(w > h)
		{
			/*float ar = Util.Round(w / h,2);
			bool is43 = ar <= Util.Round(4.0f/3.0f, 2);

			if( is43 )
			{
				// === Landscape 4:3 ===
				replaceSprite("Background_Image", "Sprites/4.3_landscape_bg");
			}
			else
			{
				// === Landscape 16:9 ===
				replaceSprite("Background_Image", "Sprites/16.9_landscape_bg");
			}*/
		}
		else
		{
			float ar = Util.Round(h / w,2);
			bool is43 = ar <= Util.Round(4.0f/3.0f, 2);

			if( is43)
			{
				// === Portrait 4:3 ===
				ReplaceSprite("Background_Image", "Sprites/4.3_portrait_bg");
			}
			else
			{
				// === Portrait 16:9 ===
				ReplaceSprite("Background_Image", "Sprites/16.9_portrait_bg");
			}
		}
	}
}
