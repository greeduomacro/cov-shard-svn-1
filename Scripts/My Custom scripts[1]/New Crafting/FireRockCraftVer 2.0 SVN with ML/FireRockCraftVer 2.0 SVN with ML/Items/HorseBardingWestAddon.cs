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
    public class HorseBardingWestAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HorseBardingWestAddonDeed();
			}
		}

		[ Constructable ]
		public HorseBardingWestAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4982 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4983 );
			AddComponent( ac, 1, 0, 0 );

		}

        public HorseBardingWestAddon(Serial serial)
            : base(serial)
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

    public class HorseBardingWestAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HorseBardingWestAddon();
			}
		}

		[Constructable]
		public HorseBardingWestAddonDeed()
		{
			Name = "HorseBardingWest";
		}

        public HorseBardingWestAddonDeed(Serial serial)
            : base(serial)
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