using System;
using Server.Targeting;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class CarrotCakeMix : CookableFood
	{
		public override int LabelNumber{ get{ return 1041002; } } // cake mix

		[Constructable]
		public CarrotCakeMix() : base( 0x103F, 75 )
		{
			Name = "carrot cake mix";
			Weight = 1.0;
			Hue = 248;
		}

		public CarrotCakeMix( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
		
		public override Food Cook()
		{
			return new CarrotCake();
		}

		/*
		public override Food BeforeAddFood( Food food, Mobile from)
		{
			food.HitsBonus += (int)(from.Skills[SkillName.Cooking].Value * 0.1);
			return food;
		}*/
	}
}