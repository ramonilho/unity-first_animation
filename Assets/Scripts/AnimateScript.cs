using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateScript : MonoBehaviour {

	public float velocity;
	Animator animator;
	SpriteRenderer spriteRender;

	void Start () {
		animator = GetComponent<Animator> ();

		spriteRender = GetComponent<SpriteRenderer> ();
	}

	void Update () {
		float inputX = Input.GetAxisRaw ("Horizontal");

		// Move character
		float moveX = inputX * velocity * Time.deltaTime;
		transform.Translate (moveX, 0.0f, 0.0f);

		// Sprite orientation
		if (moveX > 0.0f) {
			spriteRender.flipX = false;
		} else if (moveX < 0.0f) {
			spriteRender.flipX = true;
		}

		// Plays animation
		animator.SetFloat("pMove", Mathf.Abs(inputX));
	}
}
