using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageAnimation : MonoBehaviour
{
	//variables
	public Sprite[] sprites;
	public int framesPerSprite;
	public bool isLoop = true;

	private int spriteIndex = 0;
	private Image UIimage;
	private int animFrame = 0;

	void Awake()
	{
		//get the image renderer
		UIimage = GetComponent<Image>();
	}

	void Update()
	{
		//advance the frame
		animFrame++;
		if (animFrame < framesPerSprite) return;
		UIimage.sprite = sprites[spriteIndex];
		animFrame = 0;
		//reset the animation on loop
		spriteIndex++;
		if (spriteIndex >= sprites.Length)
		{
			if (isLoop) spriteIndex = 0;
		}
	}
}
