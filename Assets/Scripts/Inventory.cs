using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Inventory : MonoBehaviour {

	private bool hasItemWeights;
	public  bool HasItemWeights { get { return hasItemWeights; } }

	private bool hasStackSizes;
	public  bool HasStackSizes { get { return hasItemWeights; } }

	public abstract List<InventoryItem> GetContents ();
	public abstract List<T> GetContents<T> () where T : InventoryItem;
	public abstract double GetTotalWeight ();
	public abstract void Draw (Rect place);

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
}