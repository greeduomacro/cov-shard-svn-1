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
	public class AG_PlanterEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_PlanterEastAddonDeed();
			}
		}

		[ Constructable ]
		public AG_PlanterEastAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 6811 );
			AddComponent( ac, 1, 0, 12 );
			ac = new AddonComponent( 3205 );
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 3204 );
			AddComponent( ac, 0, -1, 7 );
			ac = new AddonComponent( 3223 );
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 3224 );
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 3206 );
			AddComponent( ac, 1, 1, 12 );
			ac = new AddonComponent( 2824 );
			ac.Name = "Planter";
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 3376 );
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 2822 );
			ac.Name = "Planter";
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2823 );
			ac.Name = "Planter";
			AddComponent( ac, 0, 0, 0 );

		}

		public AG_PlanterEastAddon( Serial serial ) : base( serial )
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

	public class AG_PlanterEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_PlanterEastAddon();
			}
		}

		[Constructable]
		public AG_PlanterEastAddonDeed()
		{
			Name = "AG_PlanterEast";
		}

		public AG_PlanterEastAddonDeed( Serial serial ) : base( serial )
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