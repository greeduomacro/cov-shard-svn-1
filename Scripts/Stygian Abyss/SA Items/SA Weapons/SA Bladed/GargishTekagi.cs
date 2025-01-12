using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x48CE, 0x48CF )]
	public class GargishTekagi : BaseKnife
	{
        public override int LabelNumber { get { return 1097510; } } ///gargish tekagi

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.DualWield; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.TalonStrike; } }

		public override int AosStrengthReq{ get{ return 10; } }
		public override int AosMinDamage{ get{ return 10; } }
		public override int AosMaxDamage{ get{ return 12; } }
		public override int AosSpeed{ get{ return 53; } }
		
		#region Mondain's Legacy
		public override float MlSpeed{ get{ return 2.00f; } }
		#endregion

		public override int OldStrengthReq{ get{ return 10; } }
		public override int OldMinDamage{ get{ return 10; } }
		public override int OldMaxDamage{ get{ return 12; } }
		public override int OldSpeed{ get{ return 53; } }

		public override int DefHitSound{ get{ return 0x238; } }
		public override int DefMissSound{ get{ return 0x232; } }

		public override int InitMinHits{ get{ return 35; } }
		public override int InitMaxHits{ get{ return 60; } }

		public override SkillName DefSkill{ get{ return SkillName.Fencing; } }
		public override WeaponType DefType{ get{ return WeaponType.Piercing; } }
		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Pierce1H; } }

         public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }

		[Constructable]
		public GargishTekagi() : base( 0x48CE )
		{
			Weight = 5.0;
			Layer = Layer.TwoHanded;
		}

		public GargishTekagi( Serial serial ) : base( serial )
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
	}
}