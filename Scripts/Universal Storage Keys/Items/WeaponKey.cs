using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects

namespace Server.Items
{
	//item inherited from BaseResourceKey
	public class WeaponKey : BaseStoreKey
	{
		public override int DisplayColumns{ get{ return 1; } }
		
		public override bool CanUseFromPack{ get{ return false; } }
		
		public override bool CanUseFromHouse{ get{ return true; } }
		
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
				//NOTE: if you're looking to add new stash entry list types, make sure to include the appropriate "using" directives at the top of this file, or use the full class path
				
				entry.Add
				( 
					new StashEntry
					(
						typeof( BaseWeapon ), "Weapons", 500, new StashSortData
						(											//add the column information
							new StashSortEntry[]		//the first entry is what is displayed by default
							{ 
								new StashSortEntry( "Resource", "Resource" ), 
								new StashSortEntry( "Crafter", "Crafter" ),
								new StashSortEntry( "Min Damage", "MinDamage" ),
								new StashSortEntry( "Max Damage", "MaxDamage" ),
								new StashSortEntry( "Speed", "Speed" ),
								new StashSortEntry( "Range", "MaxRange" ),
								new StashSortEntry( "Req. Skill", "Skill" )
							}, 
							new StashSortEntry[]	//the second entry is what is also available to the user when they customize the gump
							{
								new StashSortEntry( "Slayer", "Slayer" ),
								new StashSortEntry( "Alt Slayer", "Slayer2" ),
								new StashSortEntry( "Str Requirement", "StrRequirement" ),
								
								new StashSortEntry( "Durability", "HitPoints" ), 
								new StashSortEntry( "Max Durability", "MaxHitPoints" ),
								
								new StashSortEntry( "Physical Damage", new string[]{ "AosElementDamage", "Physical" } ),
								new StashSortEntry( "Fire Damage", new string[]{ "AosElementDamage", "Fire" } ),
								new StashSortEntry( "Cold Damage", new string[]{ "AosElementDamage", "Cold" } ),
								new StashSortEntry( "Energy Damage", new string[]{ "AosElementDamage", "Energy" } ),
								new StashSortEntry( "Poison Damage", new string[]{ "AosElementDamage", "Poison" } ),
								
								new StashSortEntry( "Durability Bonus", new string[]{ "WeaponAttributes", "DurabilityBonus" } ),
								new StashSortEntry( "Lower Stats", new string[]{ "WeaponAttributes", "LowerStatReq" } ),
								new StashSortEntry( "Mage Weapon", new string[]{ "WeaponAttributes", "MageWeapon" } ),
								new StashSortEntry( "Self Repair", new string[]{ "WeaponAttributes", "SelfRepair" } ),
								
								new StashSortEntry( "Life Leech", new string[]{ "WeaponAttributes", "HitLeechHits" } ),
								new StashSortEntry( "Stamina Leech", new string[]{ "WeaponAttributes", "HitLeechStam" } ),
								new StashSortEntry( "Mana Leech", new string[]{ "WeaponAttributes", "HitLeechMana" } ),
								
								new StashSortEntry( "Physical Area", new string[]{ "WeaponAttributes", "HitPhysicalArea" } ),
								new StashSortEntry( "Fire Area", new string[]{ "WeaponAttributes", "HitFireArea" } ),
								new StashSortEntry( "Cold Area", new string[]{ "WeaponAttributes", "HitColdArea" } ),
								new StashSortEntry( "Energy Area", new string[]{ "WeaponAttributes", "HitEnergyArea" } ),
								new StashSortEntry( "Poison Area", new string[]{ "WeaponAttributes", "HitPoisonArea" } ),
								
								new StashSortEntry( "Hit Dispel", new string[]{ "WeaponAttributes", "HitDispel" } ),
								new StashSortEntry( "Hit Harm", new string[]{ "WeaponAttributes", "HitHarm" } ),
								new StashSortEntry( "Hit Fireball", new string[]{ "WeaponAttributes", "HitFireball" } ),
								new StashSortEntry( "Hit Lightning", new string[]{ "WeaponAttributes", "HitLightning" } ),
								
								new StashSortEntry( "Physical Bonus", new string[]{ "WeaponAttributes", "ResistPhysicalBonus" } ),
								new StashSortEntry( "Fire Bonus", new string[]{ "WeaponAttributes", "ResistFireBonus" } ),
								new StashSortEntry( "Cold Bonus", new string[]{ "WeaponAttributes", "ResistColdBonus" } ),
								new StashSortEntry( "Energy Bonus", new string[]{ "WeaponAttributes", "ResistEnergyBonus" } ),
								new StashSortEntry( "Poisin Bonus", new string[]{ "WeaponAttributes", "ResistPoisonBonus" } ),
								
								new StashSortEntry( "Str Bonus", new string[]{ "Attributes", "BonusStr" } ),
								new StashSortEntry( "Dex Bonus", new string[]{ "Attributes", "BonusDex" } ),
								new StashSortEntry( "Int Bonus", new string[]{ "Attributes", "BonusInt" } ),
								new StashSortEntry( "HP Bonus", new string[]{ "Attributes", "BonusHits" } ),
								new StashSortEntry( "Stamina Bonus", new string[]{ "Attributes", "BonusStam" } ),
								new StashSortEntry( "Mana Bonus", new string[]{ "Attributes", "BonusMana" } ),
								new StashSortEntry( "FCR", new string[]{ "Attributes", "CastRecovery" } ),
								new StashSortEntry( "FC", new string[]{ "Attributes", "CastSpeed" } ),
								new StashSortEntry( "HCI", new string[]{ "Attributes", "AttackChance" } ),
								new StashSortEntry( "DCI", new string[]{ "Attributes", "DefendChance" } ),
								new StashSortEntry( "LMC", new string[]{ "Attributes", "LowerManaCost" } ),
								new StashSortEntry( "LRC", new string[]{ "Attributes", "LowerRegCost" } ),
								new StashSortEntry( "Luck", new string[]{ "Attributes", "Luck" } ),
								new StashSortEntry( "Enhance Potions", new string[]{ "Attributes", "EnhancePotions" } ),
								new StashSortEntry( "Night Sight", new string[]{ "Attributes", "NightSight" } ),
								new StashSortEntry( "Reflect Phys Damage", new string[]{ "Attributes", "Reflect Physical" } ),
								new StashSortEntry( "Hits Regen", new string[]{ "Attributes", "RegenHits" } ),
								new StashSortEntry( "Stam Regen", new string[]{ "Attributes", "RegenStam" } ),
								new StashSortEntry( "Mana Regen", new string[]{ "Attributes", "RegenMana" } ),
								new StashSortEntry( "Spell Channeling", new string[]{ "Attributes", "SpellChanneling" } ),
								new StashSortEntry( "Spell Damage", new string[]{ "Attributes", "SpellDamage" } ),
								new StashSortEntry( "Damage Increase", new string[]{ "Attributes", "WeaponDamage" } ),
								new StashSortEntry( "Swing Speed Increase", new string[]{ "Attributes", "WeaponSpeed" } ),
								new StashSortEntry( "Skill 1", new string[]{ "SkillBonuses", "Skill_1_Name" }, new string[]{ "SkillBonuses", "Skill_1_Value" } ),
								new StashSortEntry( "Skill 1 Name", new string[]{ "SkillBonuses", "Skill_1_Name" } ),
								new StashSortEntry( "Skill 1 Value", new string[]{ "SkillBonuses", "Skill_1_Value" } ),
								new StashSortEntry( "Skill 2", new string[]{ "SkillBonuses", "Skill_2_Name" }, new string[]{ "SkillBonuses", "Skill_2_Value" } ),
								new StashSortEntry( "Skill 2 Name", new string[]{ "SkillBonuses", "Skill_2_Name" } ),
								new StashSortEntry( "Skill 2 Value", new string[]{ "SkillBonuses", "Skill_2_Value" } ),
								new StashSortEntry( "Skill 3", new string[]{ "SkillBonuses", "Skill_3_Name" }, new string[]{ "SkillBonuses", "Skill_3_Value" } ),
								new StashSortEntry( "Skill 3 Name", new string[]{ "SkillBonuses", "Skill_3_Name" } ),
								new StashSortEntry( "Skill 3 Value", new string[]{ "SkillBonuses", "Skill_3_Value" } ),
								new StashSortEntry( "Skill 4", new string[]{ "SkillBonuses", "Skill_4_Name" }, new string[]{ "SkillBonuses", "Skill_4_Value" } ),
								new StashSortEntry( "Skill 4 Name", new string[]{ "SkillBonuses", "Skill_4_Name" } ),
								new StashSortEntry( "Skill 4 Value", new string[]{ "SkillBonuses", "Skill_4_Value" } ),
								new StashSortEntry( "Skill 5", new string[]{ "SkillBonuses", "Skill_5_Name" }, new string[]{ "SkillBonuses", "Skill_5_Value" } ),
								new StashSortEntry( "Skill 5 Name", new string[]{ "SkillBonuses", "Skill_5_Name" } ),
								new StashSortEntry( "Skill 5 Value", new string[]{ "SkillBonuses", "Skill_5_Value" } )
							} 
						)	 
					) 
				);				
 				
				return entry;
			}
		}
		
		
		
		[Constructable]
		public WeaponKey() : base( 0 )
		{
			ItemID = 10326;
			Name = "Weapon Rack";
		}
		
		
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();

			//properties of this storage device
			store.Label = "Weapon Rack";
			
			store.OfferDeeds = false;
			return store;
		}
		
		//serial constructor
		public WeaponKey( Serial serial ) : base( serial )
		{
		}
		
		//events
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( 0 );
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}



}