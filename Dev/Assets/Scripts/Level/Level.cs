using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using BJW.Helpers;

public class Level : MonoBehaviour
{
	public Texture2D AlphaMatte;
	private SpriteRenderer _SpriteRenderer;

	void Start()
	{
		_SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		transform.localScale = new Vector3(
			GeneralHelper.GetScreenSizeInWorldUntits().x / _SpriteRenderer.bounds.size.x,
			GeneralHelper.GetScreenSizeInWorldUntits().y / _SpriteRenderer.bounds.size.y,
			0.0f
		);



		// TODO: Analyse level alpha matte using chain coding and establish a List<Vector2> of collider shapes
		// 1. use blocking at the resolution stored in BJW.Scene.Root.LevelColliderResolution
		// 2. test with a single block first


		// Create Level Colliders
		List<PolygonCollider2D> LevelColliders = LevelHelper.GenerateColliderGrid(BJW.Scene.LevelCollider, BJW.Scene.Root.LevelColliderResolution, transform.localScale);
		LevelHelper.ConvertAlphaToCollider(AlphaMatte, LevelColliders);
	}


	void Update()
	{
	
	}
}

