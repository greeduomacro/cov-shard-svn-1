using System;
using Server.Misc;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x1515, 0x1530 )]
    public class CloakOfTheNecromancer : Cloak, ITokunoDyable 
	{ 
		private SkillMod m_SkillMod0; 
		private SkillMod m_SkillMod1; 
		private SkillMod m_SkillMod2; 
		private StatMod m_StatMod0; 
		
		[Constructable] 
		public CloakOfTheNecromancer() : base( 2206 )
		{ 
			Name = "Cloak Of The Necromancer"; 
			DefineMods();
		}

		private void DefineMods()
		{
			m_SkillMod0 = new DefaultSkillMod( SkillName.SpiritSpeak, true, 5 );
			m_SkillMod1 = new DefaultSkillMod( SkillName.EvalInt, true, 5 );
			m_SkillMod2 = new DefaultSkillMod( SkillName.Necromancy, true, 5 );
			m_StatMod0 = new StatMod( StatType.Int, "MagiCloak", 5, TimeSpan.Zero );
		}

		private void SetMods( Mobile wearer )
		{			
			wearer.AddSkillMod( m_SkillMod0 ); 
			wearer.AddSkillMod( m_SkillMod1 ); 
			wearer.AddSkillMod( m_SkillMod2 ); 
			wearer.AddStatMod( m_StatMod0 ); 
		}

		public override bool OnEquip( Mobile from ) 
		{ 
			SetMods( from );
			return true;  
		} 

	

		public override void OnRemoved( object parent ) 
		{ 
			if ( parent is Mobile ) 
			{ 
				Mobile m = (Mobile)parent;
				m.RemoveStatMod( "MagiCloak" ); 

				if ( m.Hits > m.HitsMax )
					m.Hits = m.HitsMax; 

				if ( m_SkillMod0 != null ) 
					m_SkillMod0.Remove(); 

				if ( m_SkillMod1 != null ) 
					m_SkillMod1.Remove(); 

				if ( m_SkillMod2 != null ) 
					m_SkillMod2.Remove(); 
			} 
		} 

		public override void OnSingleClick( Mobile from ) 
		{ 
			this.LabelTo( from, Name ); 
		} 

		public CloakOfTheNecromancer( Serial serial ) : base( serial ) 
		{ 
			DefineMods();
			
			if ( Parent != null && this.Parent is Mobile ) 
				SetMods( (Mobile)Parent );
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
