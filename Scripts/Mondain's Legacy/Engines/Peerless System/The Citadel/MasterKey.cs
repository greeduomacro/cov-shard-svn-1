using System;
using Server;

namespace Server.Items
{
	public class TheCitadelKey : MasterKey
	{
		public override int LabelNumber{ get{ return 1074344; } } // black order key
		public override int Lifespan{ get{ return 600; } }
		
		public TheCitadelKey() : base( 0x1012 )
		{
			Hue = 0x489;
		}
		
		public TheCitadelKey( Serial serial ) : base( serial )
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
		
		public override bool CanOfferConfirmation( Mobile from )
		{
			if ( from.Region != null && from.Region.IsPartOf( "TheCitadel" ) )
				return base.CanOfferConfirmation( from );
				
			return false;
		}
	}
}