using System;
using Server.Network;
using Server.Prompts;
using Server.Items;

namespace Server.Items
{
	public class LetterToSnyden : Item
	{
		[Constructable]
        public LetterToSnyden ()
            : base(0x14ED)
		{
			base.Weight = 1.0;
			base.Name = "Letter to Snyden of Cove";
		}

		public LetterToSnyden( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile m )
		{
			m.SendMessage( "Finlor's Letter to Snyden of Cove." );
		}
	}
}


