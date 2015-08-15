//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

public class ListInventory : Inventory
{
	/// <summary>
	/// The contents of the Inventory.
	/// </summary>
	private List<InventoryItem> contents;

	/// <summary>
	/// Initializes a new instance of the <see cref="ListInventory"/> class.
	/// </summary>
	public ListInventory ()
	{
		this.contents = new List<InventoryItem> ();
	}

	/// <summary>
	/// Adds the specified item to the Inventory.
	/// </summary>
	/// <param name="item">the item to be added</param>
	public void Add(InventoryItem item){
		this.contents.Add(item);
	}

	/// <summary>
	/// Removes the specified item from the Inventory.
	/// </summary>
	/// <param name="item">the item to be removed.</param>
	/// <returns><c>true</c> if the item was actually in the list; otherwise, <c>false</c>.</returns>
	public bool Remove(InventoryItem item)
	{
		return contents.Remove(item);
	}

	public override List<InventoryItem> GetContents()
	{
		return new List<InventoryItem> (contents);
	}

	public override List<T> GetContents<T>()
	{
		List<T> tempList = new List<T> ();
		foreach (InventoryItem item in this.contents) {
			if (item is T){
				tempList.Add((T)item);
			}
		}
		return tempList;
	}

	public override double GetTotalWeight ()
	{
		double tempWeight = 0.0;

		foreach (InventoryItem item in this.contents) {
			tempWeight += item.Weight;
		}

		return tempWeight;
	}

	public override void Draw (UnityEngine.Rect place)
	{
		throw new NotImplementedException ();
	}
}