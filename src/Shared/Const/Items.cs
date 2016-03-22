﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Const
{
	public enum InventoryCategory
	{
		Weapon = 1,
		Armor = 2,
		SubWeapon = 3,
		Costume = 4,
		Accessory = 5,
		Consumable = 6,
		Gem = 7,
		Material = 8,
		Card = 9,
		Collection = 10,
		Book = 11,
		Quest = 12,
		PetWeapon = 13,
		PetArmor = 14,
		Unknown = 15,
	}

	/// <remarks>
	/// We're using this enum to save which slot an item is equipped on,
	/// should the values change, the values in the database would be
	/// incorrect. Should this enum change again, we should think about
	/// saving the slots as string or creating an intermediary enum.
	/// </remarks>
	public enum EquipSlot : byte
	{
		HairAccessory,
		SubsidiaryAccessory,
		Hair, // [i11025 (2016-02-26)]
		_Outer1,
		Top,
		Costume,
		Shoes,
		_Helmet,
		Armband,
		LeftHand,
		RightHand,
		Gloves,
		_Ring1,
		_Ring2,
		_Outer2,
		Pants,
		_Ring3,
		_Ring4,
		Bracelet1,
		Bracelet2,
		Necklace,
	}

	public enum InventoryItemRemoveMsg : byte
	{
		Given = 0, // 0,1,2,6,10
		Destroyed = 3,
		Equipped = 5,
		Used = 7, // 7,8
	}

	public enum InventoryType : byte
	{
		Inventory = 0,
		Warehouse = 1,
	}

	public enum InventoryAddType : byte
	{
		PickUp = 3, // ?
		NotNew = 4,
	}

	public static class Items
	{
		/// <summary>
		/// Ammount of equip slots.
		/// </summary>
		/// <remarks>
		/// [i11025 (2016-02-26)] 20->21, Hair slot?
		/// </remarks>
		public const int EquipSlotCount = 21;

		/// <summary>
		/// Ids of the items equipped by default.
		/// (Literally empty items, NoHat, NoWeapon, etc.)
		/// </summary>
		public static readonly int[] DefaultItems = new int[EquipSlotCount] { 2, 2, 12101, 8, 6, 7, 10000, 11000, 9999996, 9999996, 4, 9, 9, 4, 9, 9, 9, 9, 9, 10, 2 };
	}
}
