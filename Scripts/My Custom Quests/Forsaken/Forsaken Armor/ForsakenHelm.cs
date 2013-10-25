/////////////////////////////////////
//**Generated by Ryan**//
/////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class HelmoftheForsaken : PlateHelm, ITokunoDyable
	{
	 	public override int ArtifactRarity{ get{ return 10; } }
	 	public override int InitMinHits{ get{ return 255; } }
	 	public override int InitMaxHits{ get{ return 255; } }

	 	[Constructable]
	 	public HelmoftheForsaken()
	 	{
	 	 	Name = "Helm of the Forsaken";
	 	 	Hue = 1418;
	 	 	ArmorAttributes.MageArmor = 1;
	 	 	ArmorAttributes.SelfRepair = 3;
            PhysicalBonus = 10;
            PoisonBonus = 10;
            EnergyBonus = 10;
            ColdBonus = 10;
            FireBonus = 10;
			Attributes.BonusDex = 2;
			Attributes.BonusHits = 3;
			Attributes.CastRecovery = 1;
			Attributes.CastSpeed = 1;
			Attributes.DefendChance = 5;
			Attributes.Luck = 100;
			Attributes.NightSight = 1;
            Attributes.ReflectPhysical = 10;
			Attributes.SpellDamage = 10;
	 	}

	 	public HelmoftheForsaken(Serial serial) : base( serial )
	 	{
	 	}
	 	public override void Serialize( GenericWriter writer )
	 	{
	 	 	base.Serialize( writer );

	 	 	writer.Write( (int) 0 );
	 	}
	 	public override void Deserialize(GenericReader reader)
	 	{
	 	 	base.Deserialize( reader );

	 	 	int version = reader.ReadInt();
	 	}
	}
}