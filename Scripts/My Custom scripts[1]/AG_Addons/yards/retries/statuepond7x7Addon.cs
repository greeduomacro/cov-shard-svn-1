/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AG_statuepond7x7Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_statuepond7x7AddonDeed();
			}
		}

		[ Constructable ]
		public AG_statuepond7x7Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 3220 );
			AddComponent( ac, -2, -2, 1 );
			ac = new AddonComponent( 3219 );
			AddComponent( ac, 1, 3, 2 );
			ac = new AddonComponent( 3339 );
			AddComponent( ac, 2, -1, 1 );
			ac = new AddonComponent( 10911 );
			ac.Hue = 1150;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3333 );
			AddComponent( ac, 1, -2, 1 );
			ac = new AddonComponent( 3219 );
			AddComponent( ac, 3, 1, 2 );
			ac = new AddonComponent( 3149 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3149 );
			AddComponent( ac, 3, 3, 1 );
			ac = new AddonComponent( 3149 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 10084 );
			AddComponent( ac, 1, 1, 3 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, 2, -2, 1 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, -2, 2, 1 );
			ac = new AddonComponent( 3220 );
			AddComponent( ac, 3, -2, 1 );
			ac = new AddonComponent( 3219 );
			AddComponent( ac, -2, 0, 2 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 13446 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 3220 );
			AddComponent( ac, -2, 3, 1 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, -1, 3, 1 );
			ac = new AddonComponent( 10912 );
			ac.Hue = 1150;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 6378 );
			AddComponent( ac, 2, -1, 2 );
			ac = new AddonComponent( 3219 );
			AddComponent( ac, 0, -2, 2 );
			ac = new AddonComponent( 3339 );
			AddComponent( ac, 0, 3, 2 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 3149 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 13451 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 13451 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3333 );
			AddComponent( ac, -2, 1, 1 );
			ac = new AddonComponent( 13488 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 6378 );
			AddComponent( ac, 0, 3, 1 );
			ac = new AddonComponent( 10910 );
			ac.Hue = 1150;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3220 );
			AddComponent( ac, 3, 3, 1 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 6041 );
			AddComponent( ac, 1, 2, 0 );

		}

		public AG_statuepond7x7Addon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class AG_statuepond7x7AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_statuepond7x7Addon();
			}
		}

		[Constructable]
		public AG_statuepond7x7AddonDeed()
		{
			Name = "AG_statuepond7x7";
		}

		public AG_statuepond7x7AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}