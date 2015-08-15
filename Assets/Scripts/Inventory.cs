using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Inventory : MonoBehaviour {

	/// <summary>
	/// Indicates whether this Inventory instance cares about item weights.
	/// </summary>
	private bool hasItemWeights;
	/// <summary>
	/// Gets a value indicating whether this Inventory instance has item weights.
	/// </summary>
	/// <value><c>true</c> if this instance has item weights; otherwise, <c>false</c>.</value>
	public  bool HasItemWeights { get { return hasItemWeights; } }

	/// <summary>
	/// Indicates whether this Inventory instance cares about stackable items.
	/// </summary>
	private bool hasStackSizes;
	/// <summary>
	/// Gets a value indicating whether this Inventory instance has stackable items.
	/// </summary>
	/// <value><c>true</c> if this instance has stack sizes; otherwise, <c>false</c>.</value>
	public  bool HasStackSizes { get { return hasItemWeights; } }

	/// <summary>
	/// Gets a List with the contents of this Inventory.
	/// </summary>
	/// <returns>The contents of this Inventory instance.</returns>
	public abstract List<InventoryItem> GetContents ();
	/// <summary>
	/// Gets a List of all the items in the Inventory of a specified type.
	/// </summary>
	/// <returns>The List of items of type T.</returns>
	/// <typeparam name="T">The type of items to list.</typeparam>
	public abstract List<T> GetContents<T> () where T : InventoryItem;

	/// <summary>
	/// Gets the total weight of all items in the Inventory instance.
	/// </summary>
	/// <returns>The total weight.</returns>
	public abstract double GetTotalWeight ();

	/// <summary>
	/// Draw the Inventory instance at the specified place.
	/// </summary>
	/// <param name="place">the place at which to draw the invent'ry</param>
	public abstract void Draw (Rect place);

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
}