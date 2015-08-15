//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
public interface InventoryItem {
	/// <summary>
	/// Gets or sets a value indicating whether this instance is rotated.
	/// </summary>
	/// <value><c>true</c> if this instance is rotated; otherwise, <c>false</c>.</value>
	bool IsRotated{ get; set; }
	/// <summary>
	/// Gets or sets the size.
	/// </summary>
	/// <value>The size.</value>
	Vector2 Size{ get; set; }
	/// <summary>
	/// Gets or sets the stack count.
	/// </summary>
	/// <value>The stack count.</value>
	int StackCount{ get; set;}
	/// <summary>
	/// Gets or sets the max stack count.
	/// </summary>
	/// <value>The max stack count.</value>
	int MaxStackCount{ get; set; }
	/// <summary>
	/// Gets or sets the weight.
	/// </summary>
	/// <value>The weight.</value>
	double Weight{ get; set; }

	bool Equals(InventoryItem that);
}
