﻿
using GameFormatReader.Common;
using OpenTK;
using System.ComponentModel;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using WindEditor.ViewModel;

namespace WindEditor
{
	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class acorn_leaf : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("acorn_leaf", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public acorn_leaf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class agbsw0 : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			agbA = 0,
			agbAT = 1,
			agbMARK = 2,
			agbA2 = 3,
			agbF2 = 4,
			agbF = 5,
			Tingle_Bomb_Trigger = 6,
			agbMW = 7,
			agbCSW = 8,
			agbR = 9,
			agbB = 10,
			agbD = 11,
			agbFA = 12,
			Unknown_13 = 13,
			Unknown_14 = 14,
		}


		[WProperty("Tingle Tuner Region", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Tingle Bomb Trigger", "GBA Message to Send After Bombed", true, "", SourceScene.Room)]
		public int GBAMessagetoSendAfterBombed
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("GBAMessagetoSendAfterBombed");
			}
		}

		[WProperty("Tingle Bomb Trigger", "Bombed Switch", true, "When this region is bombed with a Tingle Bomb, it will set this switch.", SourceScene.Room)]
		public int BombedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("BombedSwitch");
			}
		}

		[WProperty("agbsw0", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("agbsw0", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("agbsw0", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("agbsw0", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFF0000 | (value_as_int << 16 & 0xFFFF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("agbsw0", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public agbsw0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			GBAMessagetoSendAfterBombed = -1;
			BombedSwitch = -1;
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_5 = -1;
			if (Name == "agbA") {
				Type = TypeEnum.agbA;
			}
			if (Name == "agbAT") {
				Type = TypeEnum.agbAT;
			}
			if (Name == "agbMARK") {
				Type = TypeEnum.agbMARK;
			}
			if (Name == "agbA2") {
				Type = TypeEnum.agbA2;
			}
			if (Name == "agbF2") {
				Type = TypeEnum.agbF2;
			}
			if (Name == "agbF") {
				Type = TypeEnum.agbF;
			}
			if (Name == "agbTBOX") {
				Type = TypeEnum.Tingle_Bomb_Trigger;
			}
			if (Name == "agbMW") {
				Type = TypeEnum.agbMW;
			}
			if (Name == "agbCSW") {
				Type = TypeEnum.agbCSW;
			}
			if (Name == "agbR") {
				Type = TypeEnum.agbR;
			}
			if (Name == "agbB") {
				Type = TypeEnum.agbB;
			}
			if (Name == "agbD") {
				Type = TypeEnum.agbD;
			}
			if (Name == "agbFA") {
				Type = TypeEnum.agbFA;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class alldie : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("All Enemies Dead Switch Setter", "Switch to Set", true, "The switch that will be set once there are no living enemies left in the room.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public alldie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class am : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Wandering = 0,
			Guards_an_area = 1,
		}


		[WProperty("Armos Knight", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("Armos Knight", "Guarded Area Radius (Hundreds)", true, "", SourceScene.Room)]
		public int GuardedAreaRadiusHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("GuardedAreaRadiusHundreds");
			}
		}

		[WProperty("Armos Knight", "Switch Activates Armos Knight?", true, "If this is checked, the 'Disable Spawn Switch' parameter below instead causes the Armos Knight to become active and attack the player, rather than disabling the Armos Knight from spawning.", SourceScene.Room)]
		public bool SwitchActivatesArmosKnight
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchActivatesArmosKnight");
			}
		}

		[WProperty("Armos Knight", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public am(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			GuardedAreaRadiusHundreds = -1;
			DisableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class am2 : Actor
	{
		// Auto-Generated Properties from Templates
		public int Unused_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unused_1");
			}
		}

		[WProperty("Armos", "Sight Range (Hundreds)", true, "This number multiplied by 100 is the range it can see Link within.", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("Armos", "Switch Activates Armos?", true, "If this is checked, the 'Disable Spawn Switch' parameter below instead causes the Armos to become active and attack the player, rather than disabling the Armos from spawning.", SourceScene.Room)]
		public bool SwitchActivatesArmos
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchActivatesArmos");
			}
		}

		[WProperty("Armos", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public am2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unused_1 = -1;
			SightRangeHundreds = -1;
			DisableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class amiprop : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("amiprop", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("amiprop", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public amiprop(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class andsw0 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Normal = 0,
			Check_for_unset_after_set = 1,
			Time_limit_check = 2,
			Normal_with_65_frames_delayed_set = 3,
		}


		[WProperty("andsw0", "Type", true, "'Normal' just checks all the switches it should and then sets 'Switch to Set'.\n'Check for unset after set' does the same, but if any of the switches to check are ever unset, 'Switch to Set' will also be unset.\n'Time limit check' starts a time limit once the first switch to check has been set, you must set the other ones within it.\n'Normal with 65 frames delayed set' waits 65 frames after the last switch to check is set before setting 'Switch to Set'.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("andsw0", "First Switch to Check", true, "The first switch index to check. If this is 0, use (Switch to Set + 1) as the first switch to check instead.\nThe other switches it checks are sequential after the first one. For example, if the first switch is 5, and 'Num Switches to Check' is 3, it will check switches 5, 6, and 7.", SourceScene.Room)]
		public int FirstSwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("FirstSwitchtoCheck");
			}
		}

		[WProperty("andsw0", "Num Switches to Check", true, "How many switches to check.", SourceScene.Room)]
		public int NumSwitchestoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("NumSwitchestoCheck");
			}
		}

		[WProperty("andsw0", "Switch to Set", true, "The switch to be set once all the switches to check have been set.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("andsw0", "Event", true, "The event to start once all the switches to check have been set.", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Event");
			}
		}

		[WProperty("andsw0", "Time Limit (Half Seconds)", true, "For the 'Time limit check' type, this number times 15 frames is how long the player has to set all the switches after the first switch is set.", SourceScene.Room)]
		public int TimeLimitHalfSeconds
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("TimeLimitHalfSeconds");
			}
		}

		// Constructor
		public andsw0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			FirstSwitchtoCheck = -1;
			NumSwitchestoCheck = -1;
			SwitchtoSet = -1;
			Event = null;
			TimeLimitHalfSeconds = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class andsw2 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
		}


		[WProperty("andsw2", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("andsw2", "First Switch to Check", true, "The first switch index to check. The other switches it checks are after this one sequentially.\nFor example, if this is 5 and 'Num Switches to Check' is 3, it will check switches 5, 6, and 7.", SourceScene.Room)]
		public int FirstSwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("FirstSwitchtoCheck");
			}
		}

		[WProperty("andsw2", "Num Switches to Check", true, "", SourceScene.Room)]
		public int NumSwitchestoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("NumSwitchestoCheck");
			}
		}

		[WProperty("andsw2", "Switch to Set", true, "The switch to be set once all the switches to check have been set.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("andsw2", "Event", true, "", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Event");
			}
		}

		[WProperty("andsw2", "Time Limit (Half Seconds)", true, "", SourceScene.Room)]
		public int TimeLimitHalfSeconds
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("TimeLimitHalfSeconds");
			}
		}

		// Constructor
		public andsw2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			FirstSwitchtoCheck = -1;
			NumSwitchestoCheck = -1;
			SwitchtoSet = -1;
			Event = null;
			TimeLimitHalfSeconds = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class arrow_iceeff : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public arrow_iceeff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class arrow_lighteff : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("arrow_lighteff", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public arrow_lighteff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class atdoor : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("atdoor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public atdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class att : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("att", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public att(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class auction : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public auction(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bb : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Flying_around = 0,
			Instantly_targets_Link = 3,
			Sits_in_place_A = 4,
			Carrying_a_Moblin = 5,
			Carrying_a_Bokoblin = 6,
			Sits_in_place_B = 7,
		}


		[WProperty("Kargaroc", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("Kargaroc", "Sight Range (Hundreds)", true, "", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("Kargaroc", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("Kargaroc", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("Kargaroc", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public bb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "YXZ";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeHundreds = -1;
			Path = null;
			EnableSpawnSwitch = -1;
			DisableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bdk : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bdk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bdk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bdkobj : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bdkobj", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bdkobj", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bdkobj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class beam : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("beam", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("beam", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("beam", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("beam", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("beam", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x10000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x10000000 | (value_as_int << 28 & 0x10000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("beam", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x30000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x30000000 | (value_as_int << 28 & 0x30000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("beam", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xC0000000) >> 30);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xC0000000 | (value_as_int << 30 & 0xC0000000));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("beam", "Unknown_8", true, "", SourceScene.Room)]
		public int Unknown_8
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public beam(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_5 = -1;
			Unknown_6 = -1;
			Unknown_7 = -1;
			Unknown_8 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bflower : Actor
	{
		// Auto-Generated Properties from Templates
		public enum FlowerTypeEnum
		{
			Ripe = 0,
			Withered = 1,
		}


		[WProperty("Bomb Flower", "Flower Type", true, "", SourceScene.Room)]
		public FlowerTypeEnum FlowerType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				if (!Enum.IsDefined(typeof(FlowerTypeEnum), value_as_int))
					value_as_int = 0;
				return (FlowerTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("FlowerType");
				UpdateModel();
			}
		}

		[WProperty("Bomb Flower", "Watered Switch", true, "Withered bomb flowers will set this switch when you pour water on them. If the switch is still set when the room reloads, the withered bomb flower will still be ripe then.\nNo effect on bomb flowers that are ripe to begin with.", SourceScene.Room)]
		public int WateredSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("WateredSwitch");
			}
		}

		// Constructor
		public bflower(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "YXZ";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			WateredSwitch = -1;
			if (Name == "BFlower") {
				FlowerType = FlowerTypeEnum.Ripe;
			}
			if (Name == "VbakH") {
				FlowerType = FlowerTypeEnum.Withered;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bgn", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bgn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn2 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public bgn2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn3 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public bgn3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bigelf : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bigelf", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bigelf", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bigelf", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bigelf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bita : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bita", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bita", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bita(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bk : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Wandering = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Hiding_in_a_Pot = 3,
			Guarding = 4,
			Being_carried_by_a_Kargaroc = 5,
			Search_Light_Operator = 6,
			Jumping = 7,
			Guarding_and_Yawning = 10,
			Pink_Bokoblin_with_Telescope = 11,
			Debug = 15,
		}


		[WProperty("Bokoblin", "Type", true, "The behavior of the Bokoblin when it spawns.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Bokoblin", "Is Green", true, "If this is set, the Bokoblin is green. However, this is overriden by the Pink Bokoblin with Telescope type.", SourceScene.Room)]
		public bool IsGreen
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000020) >> 5);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000020 | (value_as_int << 5 & 0x00000020));
				OnPropertyChanged("IsGreen");
			}
		}
		public enum WeaponEnum
		{
			Unlit_Torch = 0,
			Machete_1 = 1,
			Lit_Torch = 2,
			Machete_2 = 3,
		}


		[WProperty("Bokoblin", "Weapon", true, "The weapon that the Bokoblin is holding when it spawns.\nNote: In the A_mori stage, Bokoblins will never spawn with a weapon regardless of what you set this parameter to.", SourceScene.Room)]
		public WeaponEnum Weapon
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				if (!Enum.IsDefined(typeof(WeaponEnum), value_as_int))
					value_as_int = 0;
				return (WeaponEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Weapon");
			}
		}

		[WProperty("Bokoblin", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("Bokoblin", "Path", true, "The path that the Bokoblin follows.", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("Bokoblin", "Invert Spawn Condition Switch", true, "If this is checked, the 'Spawn Condition Switch' parameter acts as a 'Disable Spawn Switch'.\nIf this isn't checked, the 'Spawn Condition Switch' parameter acts as an 'Enable Spawn Switch'.", SourceScene.Room)]
		public bool InvertSpawnConditionSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000010) >> 4);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000010 | (value_as_int << 4 & 0x00000010));
				OnPropertyChanged("InvertSpawnConditionSwitch");
			}
		}

		[WProperty("Bokoblin", "Spawn Condition Switch", true, "", SourceScene.Room)]
		public int SpawnConditionSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("SpawnConditionSwitch");
			}
		}

		[WProperty("Bokoblin", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public bk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_5 = -1;
			Path = null;
			SpawnConditionSwitch = -1;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bl : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Red_Bubble = 0,
			Blue_Bubble = 1,
			Path_Following_Red_Bubble = 2,
			Path_Following_Blue_Bubble = 3,
			Inanimate_Skull = 128,
		}


		[WProperty("bl", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("bl", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("bl", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("bl", "Float at Initial Height?", true, "If this is not checked, the Bubble will float near the ground below it instead of in the air where it is actually placed.", SourceScene.Room)]
		public bool FloatatInitialHeight
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("FloatatInitialHeight");
			}
		}

		// Constructor
		public bl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			EnableSpawnSwitch = -1;
			Path = null;
			if (Name == "bable_r") {
				Type = TypeEnum.Red_Bubble;
			}
			if (Name == "bable") {
				Type = TypeEnum.Blue_Bubble;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmd : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public bmd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmdfoot : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bmdfoot", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bmdfoot(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmdhand : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bmdhand", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bmdhand", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bmdhand", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000001F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000001F | (value_as_int << 0 & 0x0000001F));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bmdhand(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bo : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Normal = 0,
			Bud_dying = 1,
			Head_and_stem_dying = 2,
			Bugged_and_invisible = 3,
		}


		[WProperty("bo", "Type", true, "Use the 'Normal' type. The two dying types are spawned by it automatically when it dies.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("bo", "Leave Behind Baba Bud?", true, "", SourceScene.Room)]
		public bool LeaveBehindBabaBud
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("LeaveBehindBabaBud");
			}
		}

		// Constructor
		public bo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class boko : Actor
	{
		// Auto-Generated Properties from Templates
		public enum Unknown_1Enum
		{
			Boko_stick = 0,
			Bokoblin_scimitar = 1,
			Stalfos_mace = 2,
			Darknut_sword = 3,
			Moblin_spear = 4,
			Phantom_Ganon_sword = 5,
		}


		[WProperty("Dropped Enemy Weapon", "Unknown_1", true, "", SourceScene.Room)]
		public Unknown_1Enum Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				if (!Enum.IsDefined(typeof(Unknown_1Enum), value_as_int))
					value_as_int = 0;
				return (Unknown_1Enum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("Dropped Enemy Weapon", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public boko(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bomb2 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Explodes_instantly = 0,
			Explodes_after_a_delay = 1,
			Carried_by_the_player = 2,
		}


		[WProperty("bomb2", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("bomb2", "Player Can Pick Up", true, "", SourceScene.Room)]
		public bool PlayerCanPickUp
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				if (value_as_int == 0) {
					return true;
				} else {
					return false;
				}
			}

			set
			{
				int value_as_int = value ? 0 : 1;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("PlayerCanPickUp");
			}
		}

		// Constructor
		public bomb2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class boss_item : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Heart Container", "Stage Save Info ID", true, "The index of which stage save info in the save file this heart container should use.\nThis affects both which save info to use when checking if the boss is dead, and which save info to use for this heart container being picked up.\nDoes not need to be the same as the stage save info of the stage this heart container is placed in.", SourceScene.Room)]
		public int StageSaveInfoID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("StageSaveInfoID");
			}
		}

		// Constructor
		public boss_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			StageSaveInfoID = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bpw : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bpw", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bpw", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bpw", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bpw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class branch : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public branch(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bridge : Actor
	{
		// Auto-Generated Properties from Templates
		public int TypeBitfield
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("TypeBitfield");
				UpdateModel();
			}
		}

		[WProperty("Plank Bridge", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("Plank Bridge", "Path", true, "The path for the bridge to be stretched along.", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public bridge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			TypeBitfield = -1;
			Unknown_2 = -1;
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bst : Actor
	{
		// Auto-Generated Properties from Templates
		public enum ComponentTypeEnum
		{
			Head = 0,
			Left_Hand = 1,
			Right_Hand = 2,
		}

		public ComponentTypeEnum ComponentType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(ComponentTypeEnum), value_as_int))
					value_as_int = 0;
				return (ComponentTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ComponentType");
				UpdateModel();
			}
		}

		// Constructor
		public bst(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class btd : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public btd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwd : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bwd", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bwd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwdg : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public bwdg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwds : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("bwds", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bwds(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class canon : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("canon", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public canon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class cc : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Normal = 0,
			Falls_from_ceiling = 1,
			Bugged_and_does_not_appear = 2,
			Random_movement = 3,
			Hiding_in_pot = 4,
		}


		[WProperty("cc", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}
		public enum ColorTypeEnum
		{
			Green = 0,
			Red = 1,
			Blue = 2,
			Dark = 3,
			Yellow = 4,
			Green_and_attacks_instantly = 10,
			Red_and_attacks_instantly = 11,
			Blue_and_attacks_instantly = 12,
			Dark_and_attacks_instantly = 13,
			Yellow_and_attacks_instantly = 14,
			Red_and_attacks_instantly_and_more_vulnerabilities = 15,
		}


		[WProperty("cc", "Color Type", true, "The 'attacks instantly' types are used by Wizzrobes. The 'attacks instantly and more vulnerabilities' type can die from Boomerang/Grappling Hook/Hookshot for some reason, but this type is unused.", SourceScene.Room)]
		public ColorTypeEnum ColorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(ColorTypeEnum), value_as_int))
					value_as_int = 0;
				return (ColorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ColorType");
				UpdateModel();
			}
		}

		[WProperty("cc", "Sight Range (Tens)", true, "", SourceScene.Room)]
		public int SightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SightRangeTens");
			}
		}

		[WProperty("cc", "Enable Spawn Switch", true, "For most behavior types, if this switch is not 255 it must be set before the ChuChu will appear.\nFor the 'Random movement' behavior type (intended for Blu ChuChus), this switch instead works completely differently: This switch index in stage save info ID 14 will be used to keep track of whether the Blu Chu Jelly dropped by this ChuChu has been picked up by the player or not. Once that switch is set, this ChuChu will no longer drop Blue Chu Jelly.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public cc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeTens = -1;
			EnableSpawnSwitch = -1;
			if (Name == "c_green") {
				ColorType = ColorTypeEnum.Green;
			}
			if (Name == "c_red") {
				ColorType = ColorTypeEnum.Red;
			}
			if (Name == "c_blue") {
				ColorType = ColorTypeEnum.Blue;
			}
			if (Name == "c_black") {
				ColorType = ColorTypeEnum.Dark;
			}
			if (Name == "c_kiiro") {
				ColorType = ColorTypeEnum.Yellow;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class coming2 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public coming2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class coming3 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public coming3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dai : Actor
	{
		// Auto-Generated Properties from Templates
		public enum EventRegisterforPlacedItemIDEnum
		{
			Event_register_0xF8FF = 0,
			Event_register_0xF7FF = 1,
			Event_register_0xF6FF = 2,
			Event_register_0xF5FF = 3,
			Event_register_0xF4FF = 4,
			Event_register_0xF3FF = 5,
			Event_register_0xF2FF = 6,
			Event_register_0xF1FF = 7,
			Event_register_0xF0FF = 8,
			Event_register_0xEFFF = 9,
			Event_register_0xEEFF = 10,
			Event_register_0xEDFF = 11,
			Event_register_0xECFF = 12,
			Event_register_0xEBFF = 13,
			Event_register_0xEAFF = 14,
			Event_register_0xE9FF = 15,
			Event_register_0xE8FF = 16,
			Event_register_0xE7FF = 17,
			Event_register_0xE6FF = 18,
			Event_register_0xE5FF = 19,
			Event_register_0xE4FF = 20,
			Event_register_0xE3FF = 21,
			Event_register_0xE2FF = 22,
			Event_register_0xE1FF = 23,
			Event_register_0xE0FF = 24,
			Event_register_0xDFFF = 25,
			Event_register_0xDEFF = 26,
			Event_register_0xDDFF = 27,
			Event_register_0xDCFF = 28,
			Event_register_0xDBFF = 29,
			Event_register_0xDAFF = 30,
			Event_register_0xD9FF = 31,
			Event_register_0xD8FF = 32,
			Event_register_0xD7FF = 33,
			Event_register_0xD6FF = 34,
			Event_register_0xD5FF = 35,
			Event_register_0xD4FF = 36,
			Event_register_0xD3FF = 37,
			Event_register_0xD2FF = 38,
			Event_register_0xD1FF = 39,
		}


		[WProperty("Windfall Island Decorative Item Pedestal", "Event Register for Placed Item ID", true, "", SourceScene.Room)]
		public EventRegisterforPlacedItemIDEnum EventRegisterforPlacedItemID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(EventRegisterforPlacedItemIDEnum), value_as_int))
					value_as_int = 0;
				return (EventRegisterforPlacedItemIDEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("EventRegisterforPlacedItemID");
			}
		}

		// Constructor
		public dai(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class daiocta : Actor
	{
		// Auto-Generated Properties from Templates
		public enum NumberofEyesEnum
		{
			Four_eyes = 0,
			Eight_eyes = 1,
			Twelve_eyes = 2,
		}


		[WProperty("Big Octo", "Number of Eyes", true, "", SourceScene.Room)]
		public NumberofEyesEnum NumberofEyes
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(NumberofEyesEnum), value_as_int))
					value_as_int = 0;
				return (NumberofEyesEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("NumberofEyes");
			}
		}

		[WProperty("Big Octo", "Sight Range (Hundreds)", true, "The range within it will see the player and start the fight (not counting vertical distance).\nIf this is 255, it will default to 50 (5000 units) instead.\nIf this is less than 50, it will default to 50 (5000 units) instead.", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("Big Octo", "Post-Loss Spawn ID", true, "If the player loses the fight against the Big Octo, this spawn ID will be where in this room the player respawns from.\nIf this is 255, the normal behavior for respawning the player is used instead.", SourceScene.Room)]
		public int PostLossSpawnID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("PostLossSpawnID");
			}
		}

		[WProperty("Big Octo", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		[WProperty("Big Octo", "Death Event Waits for Great Fairy", true, "If this is checked, the cutscene played after the Big Octo is defeated will not end normally, and will instead wait for the Great Fairy's cutscene to start.\nIf there is no Great Fairy set up properly here, the game will softlock with no way to end the cutscene.", SourceScene.Room)]
		public bool DeathEventWaitsforGreatFairy
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				if (value_as_int == 1) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 0 : 1;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DeathEventWaitsforGreatFairy");
			}
		}

		// Constructor
		public daiocta(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeHundreds = -1;
			PostLossSpawnID = -1;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class daiocta_eye : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public daiocta_eye(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class deku_item : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Deku Leaf Item Pickup", "Item Pickup Flag", true, "", SourceScene.Room)]
		public int ItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ItemPickupFlag");
			}
		}

		// Constructor
		public deku_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			ItemPickupFlag = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_dk : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public demo_dk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_item : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("demo_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("demo_item", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public demo_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_kmm : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public demo_kmm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dk : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("dk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public dk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class door10 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Normal = 0,
			Boss = 1,
			Barred_until_all_enemies_dead = 2,
			Unknown_3 = 3,
			Locked = 4,
			Locked_and_barred = 5,
		}


		[WProperty("Door", "Type", true, "The type of door. Controls both the model and how it behaves in terms of preventing you from going through it with locks/bars.\nNote that the 'Boss'-type doors can never be entered via the back side, even if you have the big key or the door is already unlocked.\nAlso note that 'Locked'-type doors behave strangely if you set their 'Back Bars Switch' to anything besides 255.\n'Locked and barred'-type doors act like 'Locked' on the front and like 'Barred until all enemies dead' on the back, which means you'll always get the strange 'Locked' behavior mentioned above on the front if you want the back to work.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Door", "Front Room Number", true, "", SourceScene.Room)]
		public int FrontRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("FrontRoomNumber");
			}
		}

		[WProperty("Door", "Back Room Number", true, "", SourceScene.Room)]
		public int BackRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x0FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x0FC0 | (value_as_int << 6 & 0x0FC0));
				OnPropertyChanged("BackRoomNumber");
			}
		}

		[WProperty("Door", "Front Switch", true, "If this value is not 255, this door's front side will have some type of lock/bars on it, depending on the type of door.\nFor 'Normal'-type doors, it will have bars, and when something else sets this switch, the bars will open.\nFor 'Locked' and 'Locked and barred'-type doors, it will have a small key lock, and when the player unlocks it with a small key, the door will set this switch and use it to remember that the lock is gone. (If this switch is 255, it will still have a small key lock, but the lock will reappear after reloading the map the door is in.)\nFor 'Barred until all enemies dead'-type doors, the door will set this switch once all the enemies in the room are dead.\nFor 'Boss'-type doors, it will have a big key lock, and when the player unlocks it with a big key, the door will set this switch and use it to remember that the lock is gone.", SourceScene.Room)]
		public int FrontSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("FrontSwitch");
				UpdateModel();
			}
		}

		[WProperty("Door", "Back Bars Switch", true, "If this value is not 255, this door's back side will have bars on it.\nThis is the switch it will check and unlock the bars once it's set.\nNote that for 'Locked and barred'-type doors, it will instead set this switch once all the enemies in the back room are dead.", SourceScene.Room)]
		public int BackBarsSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("BackBarsSwitch");
				UpdateModel();
			}
		}

		[WProperty("Door", "Event ID", true, "", SourceScene.Room)]
		public int EventID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("EventID");
			}
		}

		[WProperty("Door", "Ship ID", true, "The ship spawn ID to place the ship at after passing through this door, or 63 for none.", SourceScene.Room)]
		public int ShipID
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("ShipID");
			}
		}
		public enum SpecialTypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_13 = 13,
			Unknown_14 = 14,
			Unknown_15 = 15,
			Unknown_16 = 16,
			Unknown_17 = 17,
			Normal = 255,
		}


		[WProperty("Door", "Special Type", true, "", SourceScene.Room)]
		public SpecialTypeEnum SpecialType
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFF00) >> 8);
				if (!Enum.IsDefined(typeof(SpecialTypeEnum), value_as_int))
					value_as_int = 0;
				return (SpecialTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_ZRotation = (short)(m_ZRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("SpecialType");
			}
		}

		// Constructor
		public door10(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			FrontRoomNumber = -1;
			BackRoomNumber = -1;
			FrontSwitch = -1;
			BackBarsSwitch = -1;
			EventID = -1;
			ShipID = -1;
			if (Name == "door10") {
				Type = TypeEnum.Normal;
			}
			if (Name == "door11") {
				Type = TypeEnum.Normal;
			}
			if (Name == "door20") {
				Type = TypeEnum.Boss;
			}
			if (Name == "door21") {
				Type = TypeEnum.Boss;
			}
			if (Name == "Zenshut") {
				Type = TypeEnum.Barred_until_all_enemies_dead;
			}
			if (Name == "keyshut") {
				Type = TypeEnum.Locked;
			}
			if (Name == "K_Zshut") {
				Type = TypeEnum.Locked_and_barred;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class door12 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Normal = 0,
			Locked = 1,
			Barred_until_all_enemies_dead = 2,
			Boss_locked = 3,
			Unknown_4 = 4,
			Unknown_5 = 5,
		}


		[WProperty("ET/WT Door", "Behavior Type", true, "How the door behaves in terms of preventing you from going through it with locks/bars.\nNote that the 'Boss locked'-type doors can never be entered via the back side, even if you have the big key or the door is already unlocked.\nAlso note that 'Locked'-type doors behave strangely if you set their 'Back Bars Switch' to anything besides 255.", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("BehaviorType");
				UpdateModel();
			}
		}
		public enum AppearanceTypeEnum
		{
			Earth_Temple_Normal = 7,
			Earth_Temple_Miniboss = 8,
			Earth_Temple_Boss = 9,
			Wind_Temple_Normal = 10,
			Wind_Temple_Miniboss = 11,
			Wind_Temple_Boss = 12,
		}


		[WProperty("ET/WT Door", "Appearance Type", true, "Which model is used for the door.\nNote that the two 'Boss' models also force this door to behave like a 'Boss locked'-type door, regardless of what Behavior Type you set.", SourceScene.Room)]
		public AppearanceTypeEnum AppearanceType
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFF00) >> 8);
				if (!Enum.IsDefined(typeof(AppearanceTypeEnum), value_as_int))
					value_as_int = 7;
				return (AppearanceTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_ZRotation = (short)(m_ZRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("AppearanceType");
				UpdateModel();
			}
		}

		[WProperty("ET/WT Door", "Front Room Number", true, "", SourceScene.Room)]
		public int FrontRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("FrontRoomNumber");
			}
		}

		[WProperty("ET/WT Door", "Back Room Number", true, "", SourceScene.Room)]
		public int BackRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x0FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x0FC0 | (value_as_int << 6 & 0x0FC0));
				OnPropertyChanged("BackRoomNumber");
			}
		}

		[WProperty("ET/WT Door", "Front Switch", true, "If this value is not 255, this door's front side will have some type of lock/bars on it, depending on the type of door.\nFor 'Normal'-type doors, it will have bars, and when something else sets this switch, the bars will open.\nFor 'Locked'-type doors, it will have a small key lock, and when the player unlocks it with a small key, the door will set this switch and use it to remember that the lock is gone.\nFor 'Barred until all enemies dead'-type doors, the door will set this switch once all the enemies in the room are dead.\nFor 'Boss locked'-type doors, it will have a big key lock, and when the player unlocks it with a big key, the door will set this switch and use it to remember that the lock is gone.", SourceScene.Room)]
		public int FrontSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("FrontSwitch");
				UpdateModel();
			}
		}

		[WProperty("ET/WT Door", "Back Bars Switch", true, "If this value is not 255, this door's back side will have bars on it.\nThis is the switch it will check and unlock the bars once it's set.", SourceScene.Room)]
		public int BackBarsSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("BackBarsSwitch");
				UpdateModel();
			}
		}

		[WProperty("ET/WT Door", "Event ID", true, "", SourceScene.Room)]
		public int EventID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("EventID");
			}
		}

		[WProperty("ET/WT Door", "Ship ID", true, "The ship spawn ID to place the ship at after passing through this door, or 63 for none.", SourceScene.Room)]
		public int ShipID
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("ShipID");
			}
		}

		// Constructor
		public door12(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			FrontRoomNumber = -1;
			BackRoomNumber = -1;
			FrontSwitch = -1;
			BackBarsSwitch = -1;
			EventID = -1;
			ShipID = -1;
			if (Name == "door12") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Earth_Temple_Normal;
			}
			if (Name == "door12M") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Earth_Temple_Miniboss;
			}
			if (Name == "door12B") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Earth_Temple_Boss;
			}
			if (Name == "door13") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Wind_Temple_Normal;
			}
			if (Name == "door13M") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Wind_Temple_Miniboss;
			}
			if (Name == "door13B") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Wind_Temple_Boss;
			}
			if (Name == "keyS12") {
				BehaviorType = BehaviorTypeEnum.Locked;
			}
			if (Name == "ZenS12") {
				BehaviorType = BehaviorTypeEnum.Barred_until_all_enemies_dead;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dr : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public dr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dr2 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public dr2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dummy : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public dummy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ep : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Has_brazier_1 = 0,
			Does_not_have_brazier_1 = 1,
			Does_not_have_brazier_2 = 2,
			Has_brazier_2 = 3,
		}


		[WProperty("Torch", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Torch", "Has Fireflies?", true, "", SourceScene.Room)]
		public bool HasFireflies
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000040) >> 6);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000040 | (value_as_int << 6 & 0x00000040));
				OnPropertyChanged("HasFireflies");
			}
		}

		[WProperty("Torch", "Is Wooden?", true, "If this is true and the Torch Type is brazier, the brazier is wooden instead of gold.", SourceScene.Room)]
		public bool IsWooden
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000080) >> 7);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000080 | (value_as_int << 7 & 0x00000080));
				OnPropertyChanged("IsWooden");
				UpdateModel();
			}
		}

		[WProperty("Torch", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("Torch", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("Torch", "On Switch", true, "The ID of the switch that, when set, lights the torch. If -1, the torch is lit by default.", SourceScene.Room)]
		public int OnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("OnSwitch");
			}
		}

		// Constructor
		public ep(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_4 = -1;
			Unknown_5 = -1;
			OnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fallrock : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public fallrock(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fallrock_tag : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("fallrock_tag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public fallrock_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fan : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("fan", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("fan", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public fan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ff : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("ff", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ff", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ff", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFF00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFF00FF | (value_as_int << 0 & 0xFFFF00FF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fganon : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Forsaken_Fortress_Encounter = 0,
			Maze_Encounter = 1,
			After_Light_Arrows_Encounter = 2,
			Clone = 3,
			Maze_Encounter_Immortal_for_Testing = 15,
		}


		[WProperty("Phantom Ganon", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("Phantom Ganon", "Which Clone", true, "1-4 for which of the clones this is. No effect on anything besides the 'Clone' behavior type.", SourceScene.Room)]
		public int WhichClone
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("WhichClone");
			}
		}

		[WProperty("Phantom Ganon", "Sight Range (Tens)", true, "The fight won't start until the player is within this number times ten units of where Phantom Ganon was placed.\nNote that this only affects the range on the X/Z plane. Phantom Ganon does not check difference in height between himself and the player, and will trigger the fight even if the player is very far above or below him.", SourceScene.Room)]
		public int SightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeTens");
			}
		}

		[WProperty("Phantom Ganon", "Disable Spawn on Death Switch", true, "Only works for the 'Forsaken Fortress' and 'After Light Arrows' behavior types.", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		[WProperty("Phantom Ganon", "Fight in Progress Switch", true, "He will set this switch when the fight starts and unset it when he's defeated.", SourceScene.Room)]
		public int FightinProgressSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("FightinProgressSwitch");
			}
		}

		// Constructor
		public fganon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			WhichClone = -1;
			SightRangeTens = -1;
			DisableSpawnonDeathSwitch = -1;
			FightinProgressSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fgmahou : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("fgmahou", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public fgmahou(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fire : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("fire", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}
		public enum Unknown_2Enum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
		}


		[WProperty("fire", "Unknown_2", true, "", SourceScene.Room)]
		public Unknown_2Enum Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				if (!Enum.IsDefined(typeof(Unknown_2Enum), value_as_int))
					value_as_int = 0;
				return (Unknown_2Enum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("fire", "Disable Spawn Chest Open Flag", true, "", SourceScene.Room)]
		public int DisableSpawnChestOpenFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0001F000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0001F000 | (value_as_int << 12 & 0x0001F000));
				OnPropertyChanged("DisableSpawnChestOpenFlag");
			}
		}
		public enum DisableSpawnConditionEnum
		{
			Checks_for_switch = 0,
			Checks_all_enemies_dead = 1,
		}


		[WProperty("fire", "Disable Spawn Condition", true, "", SourceScene.Room)]
		public DisableSpawnConditionEnum DisableSpawnCondition
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000E0000) >> 17);
				if (!Enum.IsDefined(typeof(DisableSpawnConditionEnum), value_as_int))
					value_as_int = 0;
				return (DisableSpawnConditionEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000E0000 | (value_as_int << 17 & 0x000E0000));
				OnPropertyChanged("DisableSpawnCondition");
			}
		}

		[WProperty("fire", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public fire(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			DisableSpawnChestOpenFlag = -1;
			Unknown_5 = -1;
			if (Name == "Fire") {
				DisableSpawnCondition = DisableSpawnConditionEnum.Checks_for_switch;
			}
			if (Name == "Zenfire") {
				DisableSpawnCondition = DisableSpawnConditionEnum.Checks_all_enemies_dead;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class floor : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Cracked Floor", "Disable Spawn on Destroyed Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DisableSpawnonDestroyedSwitch");
			}
		}

		// Constructor
		public floor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisableSpawnonDestroyedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fm : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Stalker_unused = 0,
			Follows_path = 1,
			Doesnt_follow_path = 2,
		}


		[WProperty("fm", "Type", true, "The unused Stalker type follows Link without coming out of the floor. That type only appears when its Enable Spawn Switch is set while in the same room as the Floormaster.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Type");
			}
		}
		public enum TargetingBehaviorTypeEnum
		{
			Target_Link_and_partner = 0,
			Target_Link_only = 1,
			Target_Partner_only = 2,
		}


		[WProperty("fm", "Targeting Behavior Type", true, "", SourceScene.Room)]
		public TargetingBehaviorTypeEnum TargetingBehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000C00) >> 10);
				if (!Enum.IsDefined(typeof(TargetingBehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (TargetingBehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000C00 | (value_as_int << 10 & 0x00000C00));
				OnPropertyChanged("TargetingBehaviorType");
			}
		}

		[WProperty("fm", "Path", true, "Only the \"Follows path\" type uses this path.", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("fm", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("fm", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		[WProperty("fm", "Link Captured Exit", true, "Which exit this Floormaster takes Link through when it captures him.", SourceScene.Room)]
		public ExitData LinkCapturedExit
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("LinkCapturedExit");
			}
		}

		[WProperty("fm", "Partner Captured Exit", true, "Which stage exit this Floormaster takes Medli/Makar through when it captures them.", SourceScene.Stage)]
		public ExitData PartnerCapturedExit
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<ExitData> list = stage.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<ExitData> list = stage.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_XRotation = (short)(m_XRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("PartnerCapturedExit");
			}
		}

		[WProperty("fm", "Sight Range (Hundreds)", true, "Defaults to a range of 3000 if you set this to 0 or 255.", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		// Constructor
		public fm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
			EnableSpawnSwitch = -1;
			DisableSpawnSwitch = -1;
			LinkCapturedExit = null;
			PartnerCapturedExit = null;
			SightRangeHundreds = -1;
			if (Name == "Fmaster") {
				Type = TypeEnum.Stalker_unused;
			}
			if (Name == "Fmastr1") {
				Type = TypeEnum.Follows_path;
			}
			if (Name == "Fmastr2") {
				Type = TypeEnum.Doesnt_follow_path;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class f_pc_profile_lst : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public f_pc_profile_lst(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ghostship : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("ghostship", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ghostship", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ghostship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gm : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Mothula = 0,
			Wing_that_falls_down_spinning = 1,
			Wing_that_floats_down_gently = 2,
		}


		[WProperty("Mothula or Mothula Wing", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}
		public enum MothulaTypeEnum
		{
			Miniboss_Winged_Mothula = 0,
			Wingless_Mothula = 1,
			Winged_Mothula = 2,
		}


		[WProperty("Mothula", "Mothula Type", true, "", SourceScene.Room)]
		public MothulaTypeEnum MothulaType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (!Enum.IsDefined(typeof(MothulaTypeEnum), value_as_int))
					value_as_int = 0;
				return (MothulaTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("MothulaType");
				UpdateModel();
			}
		}
		public int MissingWings
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("MissingWings");
				UpdateModel();
			}
		}

		[WProperty("Mothula", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}
		public enum WhichWingEnum
		{
			Unknown_0 = 0,
			Lower_Right_Wing = 1,
			Lower_Left_Wing = 2,
			Upper_Right_Wing = 3,
			Upper_Left_Wing = 4,
		}


		[WProperty("Mothula Wing", "Which Wing", true, "", SourceScene.Room)]
		public WhichWingEnum WhichWing
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(WhichWingEnum), value_as_int))
					value_as_int = 0;
				return (WhichWingEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("WhichWing");
				UpdateModel();
			}
		}

		[WProperty("gm", "Unknown_5", true, "", SourceScene.Room)]
		public bool Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				if (value_as_int == 0) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public gm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			MissingWings = -1;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gnd : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("gnd", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("gnd", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public gnd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class goal_flag : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("goal_flag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("goal_flag", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public goal_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class grass : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Grass = 0,
			Tree = 1,
			White_Flower = 2,
			Pink_Flower = 3,
		}


		[WProperty("Foliage", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000030) >> 4);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000030 | (value_as_int << 4 & 0x00000030));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}
		public enum SpawnPatternEnum
		{
			Single = 0,
			_7_Grass_Bunches = 1,
			_21_Grass_Bunches = 2,
			_3_Trees = 3,
			_7_White_Flowers = 4,
			_17_White_Flowers = 5,
			_7_Pink_Flowers = 6,
			_5_Trees = 7,
		}


		[WProperty("Foliage", "Spawn Pattern", true, "", SourceScene.Room)]
		public SpawnPatternEnum SpawnPattern
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(SpawnPatternEnum), value_as_int))
					value_as_int = 0;
				return (SpawnPatternEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("SpawnPattern");
			}
		}

		[WProperty("Grass and Flowers", "Dropped Item", true, "", SourceScene.Room)]
		public OnlyTableDroppedItemID DroppedItem
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000FC0) >> 6);
				if (!Enum.IsDefined(typeof(OnlyTableDroppedItemID), value_as_int))
					value_as_int = 0;
				return (OnlyTableDroppedItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000FC0 | (value_as_int << 6 & 0x00000FC0));
				OnPropertyChanged("DroppedItem");
			}
		}

		// Constructor
		public grass(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DroppedItem = OnlyTableDroppedItemID.No_item;
			if (Name == "kusax1") {
				Type = TypeEnum.Grass;
				SpawnPattern = SpawnPatternEnum.Single;
			}
			if (Name == "kusax7") {
				Type = TypeEnum.Grass;
				SpawnPattern = SpawnPatternEnum._7_Grass_Bunches;
			}
			if (Name == "kusax21") {
				Type = TypeEnum.Grass;
				SpawnPattern = SpawnPatternEnum._21_Grass_Bunches;
			}
			if (Name == "flower") {
				Type = TypeEnum.White_Flower;
				SpawnPattern = SpawnPatternEnum.Single;
			}
			if (Name == "flwr7") {
				Type = TypeEnum.White_Flower;
				SpawnPattern = SpawnPatternEnum._7_White_Flowers;
			}
			if (Name == "flwr17") {
				Type = TypeEnum.White_Flower;
				SpawnPattern = SpawnPatternEnum._17_White_Flowers;
			}
			if (Name == "pflower") {
				Type = TypeEnum.Pink_Flower;
				SpawnPattern = SpawnPatternEnum.Single;
			}
			if (Name == "pflwrx7") {
				Type = TypeEnum.Pink_Flower;
				SpawnPattern = SpawnPatternEnum._7_Pink_Flowers;
			}
			if (Name == "swood") {
				Type = TypeEnum.Tree;
				SpawnPattern = SpawnPatternEnum.Single;
			}
			if (Name == "swood3") {
				Type = TypeEnum.Tree;
				SpawnPattern = SpawnPatternEnum._3_Trees;
			}
			if (Name == "swood5") {
				Type = TypeEnum.Tree;
				SpawnPattern = SpawnPatternEnum._5_Trees;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gy : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public gy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gy_ctrl : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Follows_you_across_sectors = 0,
			Stays_in_sector = 1,
		}


		[WProperty("Gyorg Spawner", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Gyorg Spawner", "Number of Gyorgs", true, "How many Gyorgs to spawn. 15 defaults to 1 Gyorg.", SourceScene.Room)]
		public int NumberofGyorgs
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("NumberofGyorgs");
			}
		}

		[WProperty("Gyorg Spawner", "Sight Range (Thousands)", true, "This number multiplied by 1000 is the range it can see KoRL within and will start spawning Gyorgs.", SourceScene.Room)]
		public int SightRangeThousands
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeThousands");
			}
		}

		[WProperty("Gyorg Spawner", "Enable Spawn Switch", true, "If this switch is valid, the spawner will not start spawning Gyorgs until the switch is set.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public gy_ctrl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			NumberofGyorgs = -1;
			SightRangeThousands = -1;
			EnableSpawnSwitch = -1;
			if (Name == "GyCtrl") {
				Type = TypeEnum.Follows_you_across_sectors;
			}
			if (Name == "GyCtrlB") {
				Type = TypeEnum.Stays_in_sector;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class himo3 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("himo3", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("himo3", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("himo3", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("himo3", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("himo3", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public himo3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_5 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hitobj : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("hitobj", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public hitobj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hmlif : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			No_Eye = 0,
			Eye_on_Top = 1,
			Eye_on_Bottom = 2,
		}


		[WProperty("Moving Platform", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x78000000) >> 27);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x78000000 | (value_as_int << 27 & 0x78000000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Moving Platform", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("Moving Platform", "Enable Movement Switch", true, "The platform will not start moving until this switch is set.\nIf this is 255, the platform will start moving from the start instead.", SourceScene.Room)]
		public int EnableMovementSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("EnableMovementSwitch");
			}
		}

		[WProperty("Moving Platform", "Eye Shot Switch", true, "This switch is set when the player shoots the eye target with an arrow.\nNo effect for 'No Eye' type platforms.", SourceScene.Room)]
		public int EyeShotSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("EyeShotSwitch");
			}
		}

		[WProperty("Moving Platform", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("Moving Platform", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00300000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00300000 | (value_as_int << 20 & 0x00300000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("Moving Platform", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07C00000) >> 22);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x07C00000 | (value_as_int << 22 & 0x07C00000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("Moving Platform", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public hmlif(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
			EnableMovementSwitch = -1;
			EyeShotSwitch = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_5 = -1;
			Unknown_7 = -1;
			if (Name == "Hmlif") {
				Type = TypeEnum.No_Eye;
			}
			if (Name == "Hyuf1") {
				Type = TypeEnum.Eye_on_Top;
			}
			if (Name == "Hyuf2") {
				Type = TypeEnum.Eye_on_Bottom;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hot_floor : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("hot_floor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("hot_floor", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000002) >> 1);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000002 | (value_as_int << 1 & 0x00000002));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public hot_floor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hys : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Shootable Eye Target", "Switch to Set When Shot", true, "", SourceScene.Room)]
		public int SwitchtoSetWhenShot
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSetWhenShot");
			}
		}
		public enum SizeEnum
		{
			Small = 0,
			Large = 1,
		}


		[WProperty("Shootable Eye Target", "Size", true, "", SourceScene.Room)]
		public SizeEnum Size
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(SizeEnum), value_as_int))
					value_as_int = 0;
				return (SizeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Size");
				UpdateModel();
			}
		}

		// Constructor
		public hys(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSetWhenShot = -1;
			if (Name == "Hys") {
				Size = SizeEnum.Small;
			}
			if (Name == "Hys2") {
				Size = SizeEnum.Large;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class icelift : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Short_Ice_Platform = 0,
			Tall_Ice_Platform = 1,
		}


		[WProperty("Ice Platform", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Ice Platform", "Path to Follow", true, "", SourceScene.Room)]
		public Path_v2 PathtoFollow
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000FF0) >> 4);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00000FF0 | (value_as_int << 4 & 0x00000FF0));
				OnPropertyChanged("PathtoFollow");
			}
		}

		[WProperty("Ice Platform", "Do Not Freeze Player Switch", true, "If this switch is not 255, and it is also not set, this ice platform will modify its collision's attribute type to freeze the player.", SourceScene.Room)]
		public int DoNotFreezePlayerSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("DoNotFreezePlayerSwitch");
			}
		}

		// Constructor
		public icelift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			PathtoFollow = null;
			DoNotFreezePlayerSwitch = -1;
			if (Name == "Ylsic") {
				Type = TypeEnum.Short_Ice_Platform;
			}
			if (Name == "Yllic") {
				Type = TypeEnum.Tall_Ice_Platform;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ikari : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("ikari", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ikari", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ikari(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class item : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Item Pickup", "Item ID", true, "", SourceScene.Room)]
		public ItemID ItemID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(ItemID), value_as_int))
					value_as_int = 0;
				return (ItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ItemID");
				UpdateModel();
			}
		}

		[WProperty("Item Pickup", "Item Pickup Flag", true, "", SourceScene.Room)]
		public int ItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ItemPickupFlag");
			}
		}

		[WProperty("Item Pickup", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}
		public enum BehaviorTypeEnum
		{
			Fade_away = 0,
			Float_in_place_and_do_not_fade_away = 1,
			Unknown_2 = 2,
			Do_not_fade_away = 3,
		}


		[WProperty("Item Pickup", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03000000) >> 24);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x03000000 | (value_as_int << 24 & 0x03000000));
				OnPropertyChanged("BehaviorType");
			}
		}
		public enum ItemActionEnum
		{
			Normal = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Make_a_ding_sound = 5,
			Unknown_6 = 6,
			Unknown_7 = 7,
			Unknown_8 = 8,
			Unknown_9 = 9,
			Unknown_10 = 10,
			Unknown_11 = 11,
			Unknown_12 = 12,
		}


		[WProperty("Item Pickup", "Item Action", true, "", SourceScene.Room)]
		public ItemActionEnum ItemAction
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFC000000) >> 26);
				if (!Enum.IsDefined(typeof(ItemActionEnum), value_as_int))
					value_as_int = 0;
				return (ItemActionEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0xFC000000 | (value_as_int << 26 & 0xFC000000));
				OnPropertyChanged("ItemAction");
			}
		}

		[WProperty("Item Pickup", "Enable Activation Switch", true, "The player will not be able to pick this item up until this switch is set.\nIt will still be visible and animated, but touching it will not give the item.\nAlso note that the item will not begin to fade away before this switch is set either.", SourceScene.Room)]
		public int EnableActivationSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("EnableActivationSwitch");
			}
		}

		// Constructor
		public item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			ItemID = ItemID.No_item;
			ItemPickupFlag = -1;
			EnableSpawnSwitch = -1;
			EnableActivationSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class jbo : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("jbo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public jbo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kaji : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public kaji(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kamome : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_4 = 4,
			Unknown_5 = 5,
			Unknown_6 = 6,
			Unknown_7 = 7,
		}


		[WProperty("Seagull", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Seagull", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("Seagull", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("Seagull", "Enable Spawn Switch", true, "The seagull will only appear once this switch is set.\nThis parameter was never used in the vanilla game.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public kamome(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_2 = -1;
			Path = null;
			EnableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kanban : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kanban", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFF00000 | (value_as_int << 20 & 0xFFF00000));
				OnPropertyChanged("Unknown_1");
			}
		}
		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("MessageID");
			}
		}

		// Constructor
		public kanban(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = 0;
			MessageID = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kantera : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kantera", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kantera", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kantera", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public kantera(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kb : Actor
	{
		// Auto-Generated Properties from Templates
		public enum ColorEnum
		{
			Pink = 0,
			Speckled = 1,
			Black = 2,
			Bugged_Face_Pink = 3,
			Pink_B = 4,
			Speckled_B = 5,
			Black_B = 6,
			Bugged_Face_Pink_B = 7,
			Small_Big_Pink = 8,
			Small_Big_Speckled = 9,
			Small_Big_Black = 10,
			Small_Big_Bugged_Face_Pink = 11,
			Small_Big_Pink_B = 12,
			Small_Big_Speckled_B = 13,
			Small_Big_Black_B = 14,
			Small_Big_Bugged_Face_Pink_B = 15,
		}


		[WProperty("kb", "Color", true, "", SourceScene.Room)]
		public ColorEnum Color
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(ColorEnum), value_as_int))
					value_as_int = 0;
				return (ColorEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Color");
				UpdateModel();
			}
		}

		[WProperty("kb", "Sight Range (Hundreds)", true, "", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("kb", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("kb", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("kb", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public kb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeHundreds = -1;
			Unknown_3 = -1;
			Path = null;
			Unknown_5 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kddoor : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Door", "Switch Bit", true, "", SourceScene.Room)]
		public int SwitchBit
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchBit");
			}
		}

		[WProperty("Door", "Type", true, "", SourceScene.Room)]
		public int Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Door", "Event ID", true, "", SourceScene.Room)]
		public int EventID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("EventID");
			}
		}

		[WProperty("Door", "Switch Bit 2", true, "", SourceScene.Room)]
		public int SwitchBit2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("SwitchBit2");
			}
		}

		[WProperty("Door", "From Room Number", true, "", SourceScene.Room)]
		public int FromRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("FromRoomNumber");
			}
		}

		[WProperty("Door", "To Room Number", true, "", SourceScene.Room)]
		public int ToRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x0FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x0FC0 | (value_as_int << 6 & 0x0FC0));
				OnPropertyChanged("ToRoomNumber");
			}
		}

		[WProperty("Door", "Ship ID", true, "", SourceScene.Room)]
		public int ShipID
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("ShipID");
			}
		}

		[WProperty("Door", "Arg 1", true, "", SourceScene.Room)]
		public int Arg1
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Arg1");
			}
		}

		// Constructor
		public kddoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchBit = -1;
			Type = -1;
			EventID = -1;
			SwitchBit2 = -1;
			FromRoomNumber = -1;
			ToRoomNumber = -1;
			ShipID = -1;
			Arg1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ki : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Hanging_from_ceiling = 0,
			Flying_around = 1,
			Launch_forward_on_spawn = 2,
			Immediately_targets_Link = 3,
			Instantly_dies_twice = 30,
			Hanging_from_ceiling_passive = 128,
		}


		[WProperty("ki", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}
		public enum SightRangeEnum
		{
			_300 = 0,
			_800 = 1,
			_1500 = 2,
			_3000 = 3,
		}


		[WProperty("ki", "Sight Range", true, "", SourceScene.Room)]
		public SightRangeEnum SightRange
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00007F00) >> 8);
				if (!Enum.IsDefined(typeof(SightRangeEnum), value_as_int))
					value_as_int = 3;
				return (SightRangeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00007F00 | (value_as_int << 8 & 0x00007F00));
				OnPropertyChanged("SightRange");
			}
		}

		[WProperty("ki", "Is Fire Keese?", true, "", SourceScene.Room)]
		public bool IsFireKeese
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00008000) >> 15);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00008000 | (value_as_int << 15 & 0x00008000));
				OnPropertyChanged("IsFireKeese");
			}
		}

		[WProperty("ki", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("ki", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public ki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
			EnableSpawnSwitch = -1;
			if (Name == "keeth") {
				IsFireKeese = false;
			}
			if (Name == "Fkeeth") {
				IsFireKeese = true;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kita : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kita", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kita", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public kita(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class klft : Actor
	{
		// Auto-Generated Properties from Templates
		public enum Unknown_1Enum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
		}


		[WProperty("klft", "Unknown_1", true, "", SourceScene.Room)]
		public Unknown_1Enum Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(Unknown_1Enum), value_as_int))
					value_as_int = 0;
				return (Unknown_1Enum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("klft", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("klft", "At Point 1 Switch", true, "The lift will use this switch to remember which end of the pulley rope it was last left on.\nIt will start at point 0. When the player leaves the room, it will set this switch if it's at point 1, or unset it if it's at point 0.\nIf this switch is 255 or 0, it will be ignored and not set/unset, the lift will always start at point 0.", SourceScene.Room)]
		public int AtPoint1Switch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("AtPoint1Switch");
			}
		}

		// Constructor
		public klft(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
			AtPoint1Switch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kmon : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public kmon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kn : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kn", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kn", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public kn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class knob00 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_5 = 5,
			Unknown_6 = 6,
		}


		[WProperty("knob00", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Type");
			}
		}
		public enum StyleEnum
		{
			Outset = 0,
			Pirate_Ship = 1,
			Windfall = 2,
			Rito_Aerie = 3,
			Private_Oasis = 4,
			Forsaken_Fortress = 5,
			Nintendo_Gallery = 6,
			Fancy = 7,
		}


		[WProperty("Door", "Style", true, "", SourceScene.Room)]
		public StyleEnum Style
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				if (!Enum.IsDefined(typeof(StyleEnum), value_as_int))
					value_as_int = 0;
				return (StyleEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("Style");
				UpdateModel();
			}
		}

		[WProperty("Door", "Message ID", true, "", SourceScene.Room)]
		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("Door", "Room Number", true, "", SourceScene.Room)]
		public int RoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("RoomNumber");
			}
		}

		[WProperty("knob00", "Type 2", true, "Unused, seems to just make it update its transformation (both visual and collision) every frame?", SourceScene.Room)]
		public bool Type2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				if (value_as_int == 1) {
					return true;
				} else {
					return false;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Type2");
			}
		}

		// Constructor
		public knob00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			MessageID = -1;
			RoomNumber = -1;
			if (Name == "KNOB00") {
				Type = TypeEnum.Unknown_0;
			}
			if (Name == "KNOB01") {
				Type = TypeEnum.Unknown_1;
			}
			if (Name == "KNOB02") {
				Type = TypeEnum.Unknown_2;
			}
			if (Name == "KNOB03") {
				Type = TypeEnum.Unknown_3;
			}
			if (Name == "KNOB00D") {
				Type = TypeEnum.Unknown_0;
			}
			if (Name == "KNOB01D") {
				Type = TypeEnum.Unknown_1;
			}
			if (Name == "KNOB02D") {
				Type = TypeEnum.Unknown_2;
			}
			if (Name == "KNOB03D") {
				Type = TypeEnum.Unknown_3;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kokiie : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kokiie", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kokiie", "Fallen Switch", true, "", SourceScene.Room)]
		public int FallenSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("FallenSwitch");
			}
		}

		// Constructor
		public kokiie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			FallenSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class komore : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public komore(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ks : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Group_that_chases_player = 0,
			Group_that_stays_put = 1,
			Single_Morth_that_stays_put = 2,
			Single_Morth_that_chases_player = 3,
			Unknown_1 = 4,
			Unknown_2 = 5,
			Group_in_a_pot = 6,
		}


		[WProperty("ks", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("ks", "Number in Group", true, "The number of Morths in this group. If you set this to 0 or higher than 21 it will just be a single Morth instead.", SourceScene.Room)]
		public int NumberinGroup
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("NumberinGroup");
			}
		}

		[WProperty("ks", "Pot Sight Range (Tens)", true, "This number multiplied by 10 is the range around the pot the Morths are in that they'll notice the player and break out of the pot.", SourceScene.Room)]
		public int PotSightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("PotSightRangeTens");
			}
		}

		// Constructor
		public ks(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			NumberinGroup = -1;
			PotSightRangeTens = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kt : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kt", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kui : Actor
	{
		// Auto-Generated Properties from Templates
		public enum ModelTypeEnum
		{
			Wooden_Beam = 0,
			Invisible = 1,
			Dragon_Roost_Cavern_Grapple_Switch = 2,
			Tower_of_the_Gods_Bell = 3,
			Cabana_Grapple_Switch = 4,
		}


		[WProperty("Grapple Point", "Model Type", true, "Determines the grapple point's model (or lack thereof).", SourceScene.Room)]
		public ModelTypeEnum ModelType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(ModelTypeEnum), value_as_int))
					value_as_int = 0;
				return (ModelTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("ModelType");
				UpdateModel();
			}
		}

		[WProperty("Unknown", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("Unknown", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("Grapple Point", "Switch to Activate", true, "The switch to set when Link grapples the object.", SourceScene.Room)]
		public int SwitchtoActivate
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("SwitchtoActivate");
			}
		}

		// Constructor
		public kui(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_2 = -1;
			Unknown_3 = -1;
			SwitchtoActivate = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag00 : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum ColoEntryEnum
		{
			None = 255,
			Sunny = 0,
			Overcast = 1,
			_2 = 2,
			_3 = 3,
			_4 = 4,
			_5 = 5,
			_6 = 6,
			_7 = 7,
		}


		[WProperty("Weather Trigger", "Colo Entry", true, "", SourceScene.Room)]
		public ColoEntryEnum ColoEntry
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(ColoEntryEnum), value_as_int))
					value_as_int = 0;
				return (ColoEntryEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ColoEntry");
			}
		}
		public enum EffectTypeEnum
		{
			None = 0,
			Rain = 1,
			Snow = 2,
			Rolling_Smoke = 3,
			Rising_Smoke = 4,
			Rolling_Smoke_2 = 5,
			Forest_Particles = 6,
			Thunder = 7,
			Thunder_and_Rain = 8,
			Thunder_Rain_and_Rolling_Smoke = 9,
			Steam_1_Unused = 10,
			Steam_2 = 11,
		}


		[WProperty("Weather Trigger", "Effect Type", true, "", SourceScene.Room)]
		public EffectTypeEnum EffectType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(EffectTypeEnum), value_as_int))
					value_as_int = 0;
				return (EffectTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("EffectType");
			}
		}

		[WProperty("Weather Trigger", "Fade Radius", true, "", SourceScene.Room)]
		public int FadeRadius
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("FadeRadius");
			}
		}

		[WProperty("Weather Trigger", "Fade Height", true, "", SourceScene.Room)]
		public int FadeHeight
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("FadeHeight");
			}
		}

		[WProperty("Weather Trigger", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		[WProperty("Weather Trigger", "Invert Position Checks", true, "When this is checked, the weather effect will trigger OUTSIDE the cylinder of this object rather than INSIDE, meaning that the inside has 'normal' weather.", SourceScene.Room)]
		public bool InvertPositionChecks
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFF00) >> 8);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_XRotation = (short)(m_XRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("InvertPositionChecks");
			}
		}

		[WProperty("Weather Trigger", "Unknown_7", true, "", SourceScene.Room)]
		public bool Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				if (value_as_int == 0) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public kytag00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			FadeRadius = -1;
			FadeHeight = -1;
			SwitchtoCheck = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag01 : TriggerRegion
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public kytag01(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag02 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Wind Direction Setter", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public kytag02(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag03 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kytag03", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		// Constructor
		public kytag03(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag04 : TriggerRegion
	{
		// Auto-Generated Properties from Templates

		[WProperty("kytag04", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kytag04", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kytag04", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public kytag04(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag05 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kytag05", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag05(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag06 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public kytag06(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag07 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("kytag07", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag07(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lamp : Actor
	{
		// Auto-Generated Properties from Templates
		public enum AmountofSwingEnum
		{
			Large = 0,
			Small = 1,
		}


		[WProperty("Lantern", "Amount of Swing", true, "", SourceScene.Room)]
		public AmountofSwingEnum AmountofSwing
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(AmountofSwingEnum), value_as_int))
					value_as_int = 0;
				return (AmountofSwingEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("AmountofSwing");
			}
		}

		// Constructor
		public lamp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lbridge : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("lbridge", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public lbridge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class leaflift : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("leaflift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public leaflift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lod_bg : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("lod_bg", "Island Index", true, "", SourceScene.Room)]
		public int IslandIndex
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("IslandIndex");
			}
		}

		// Constructor
		public lod_bg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			IslandIndex = -1;
			if (Name == "LOD01") {
				IslandIndex = 1;
			}
			if (Name == "LOD02") {
				IslandIndex = 2;
			}
			if (Name == "LOD03") {
				IslandIndex = 3;
			}
			if (Name == "LOD04") {
				IslandIndex = 4;
			}
			if (Name == "LOD05") {
				IslandIndex = 5;
			}
			if (Name == "LOD06") {
				IslandIndex = 6;
			}
			if (Name == "LOD07") {
				IslandIndex = 7;
			}
			if (Name == "LOD08") {
				IslandIndex = 8;
			}
			if (Name == "LOD09") {
				IslandIndex = 9;
			}
			if (Name == "LOD10") {
				IslandIndex = 10;
			}
			if (Name == "LOD11") {
				IslandIndex = 11;
			}
			if (Name == "LOD12") {
				IslandIndex = 12;
			}
			if (Name == "LOD13") {
				IslandIndex = 13;
			}
			if (Name == "LOD14") {
				IslandIndex = 14;
			}
			if (Name == "LOD15") {
				IslandIndex = 15;
			}
			if (Name == "LOD16") {
				IslandIndex = 16;
			}
			if (Name == "LOD17") {
				IslandIndex = 17;
			}
			if (Name == "LOD18") {
				IslandIndex = 18;
			}
			if (Name == "LOD19") {
				IslandIndex = 19;
			}
			if (Name == "LOD20") {
				IslandIndex = 20;
			}
			if (Name == "LOD21") {
				IslandIndex = 21;
			}
			if (Name == "LOD22") {
				IslandIndex = 22;
			}
			if (Name == "LOD23") {
				IslandIndex = 23;
			}
			if (Name == "LOD24") {
				IslandIndex = 24;
			}
			if (Name == "LOD25") {
				IslandIndex = 25;
			}
			if (Name == "LOD26") {
				IslandIndex = 26;
			}
			if (Name == "LOD27") {
				IslandIndex = 27;
			}
			if (Name == "LOD28") {
				IslandIndex = 28;
			}
			if (Name == "LOD29") {
				IslandIndex = 29;
			}
			if (Name == "LOD30") {
				IslandIndex = 30;
			}
			if (Name == "LOD31") {
				IslandIndex = 31;
			}
			if (Name == "LOD32") {
				IslandIndex = 32;
			}
			if (Name == "LOD33") {
				IslandIndex = 33;
			}
			if (Name == "LOD34") {
				IslandIndex = 34;
			}
			if (Name == "LOD35") {
				IslandIndex = 35;
			}
			if (Name == "LOD36") {
				IslandIndex = 36;
			}
			if (Name == "LOD37") {
				IslandIndex = 37;
			}
			if (Name == "LOD38") {
				IslandIndex = 38;
			}
			if (Name == "LOD39") {
				IslandIndex = 39;
			}
			if (Name == "LOD40") {
				IslandIndex = 40;
			}
			if (Name == "LOD41") {
				IslandIndex = 41;
			}
			if (Name == "LOD42") {
				IslandIndex = 42;
			}
			if (Name == "LOD43") {
				IslandIndex = 43;
			}
			if (Name == "LOD44") {
				IslandIndex = 44;
			}
			if (Name == "LOD45") {
				IslandIndex = 45;
			}
			if (Name == "LOD46") {
				IslandIndex = 46;
			}
			if (Name == "LOD47") {
				IslandIndex = 47;
			}
			if (Name == "LOD48") {
				IslandIndex = 48;
			}
			if (Name == "LOD49") {
				IslandIndex = 49;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lstair : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("lstair", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public lstair(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lwood : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public lwood(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class machine : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("machine", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public machine(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class magma : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Magma", "Bubbles Path", true, "The magma's bubbles will appear on this path's points.", SourceScene.Room)]
		public Path_v2 BubblesPath
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("BubblesPath");
			}
		}

		// Constructor
		public magma(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			BubblesPath = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class majuu_flag : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("majuu_flag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("majuu_flag", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public majuu_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mant : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("mant", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mant(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mbdoor : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("mbdoor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mbdoor", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mbdoor", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public mbdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mdoor : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("mdoor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mdoor", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mdoor", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("mdoor", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public mdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mflft : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("mflft", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mflft", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public mflft(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mgameboard : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public mgameboard(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mmusic : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public mmusic(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mo2 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Blue_skin_without_lantern = 0,
			Brown_skin_with_lantern = 1,
			Carried_through_the_air = 5,
			Frozen_in_time = 15,
			Blue_skin_without_lantern_unused = 100,
		}


		[WProperty("mo2", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}
		public enum FrozeninTimePoseEnum
		{
			Attacking_pose = 0,
			Walking_pose = 1,
		}


		[WProperty("mo2", "Frozen in Time Pose", true, "", SourceScene.Room)]
		public FrozeninTimePoseEnum FrozeninTimePose
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(FrozeninTimePoseEnum), value_as_int))
					value_as_int = 0;
				return (FrozeninTimePoseEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("FrozeninTimePose");
			}
		}

		[WProperty("mo2", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("mo2", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("mo2", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public mo2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
			EnableSpawnSwitch = -1;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class movie_player : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public movie_player(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mozo : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("mozo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mozo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class msw : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("msw", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public msw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mt : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("mt", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mt", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00007F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00007F00 | (value_as_int << 8 & 0x00007F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mt", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00008000) >> 15);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00008000 | (value_as_int << 15 & 0x00008000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("mt", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("mt", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("mt", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public mt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Path = null;
			EnableSpawnSwitch = -1;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mtoge : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("mtoge", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mtoge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ac1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_ac1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ac1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ac1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ah : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_ah", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ah", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ah(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_aj1 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_255 = 255,
		}


		[WProperty("Sturgeon", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Sturgeon", "Unknown Switch", true, "", SourceScene.Room)]
		public int UnknownSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("UnknownSwitch");
			}
		}

		// Constructor
		public npc_aj1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			UnknownSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_auction : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_auction(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ba1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_ba1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ba1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bj1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_bj1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_bj1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_bj1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bm1 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum QuillTypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_255 = 255,
		}


		[WProperty("Quill (Bm1)", "Quill Type", true, "", SourceScene.Room)]
		public QuillTypeEnum QuillType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(QuillTypeEnum), value_as_int))
					value_as_int = 0;
				return (QuillTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("QuillType");
				UpdateModel();
			}
		}
		public enum SkettandAkootTypeEnum
		{
			Skett = 0,
			Akoot = 1,
			Unknown_255 = 255,
		}


		[WProperty("Skett and Akoot (Bm2)", "Skett and Akoot Type", true, "", SourceScene.Room)]
		public SkettandAkootTypeEnum SkettandAkootType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(SkettandAkootTypeEnum), value_as_int))
					value_as_int = 0;
				return (SkettandAkootTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SkettandAkootType");
				UpdateModel();
			}
		}
		public enum BashtandBishtandHoskitTypeEnum
		{
			Basht = 0,
			Bisht = 1,
			Hoskit = 2,
			Unknown_255 = 255,
		}


		[WProperty("Basht and Bisht and Hoskit (Bm3)", "Basht and Bisht and Hoskit Type", true, "", SourceScene.Room)]
		public BashtandBishtandHoskitTypeEnum BashtandBishtandHoskitType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BashtandBishtandHoskitTypeEnum), value_as_int))
					value_as_int = 0;
				return (BashtandBishtandHoskitTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BashtandBishtandHoskitType");
				UpdateModel();
			}
		}
		public enum IlariandPashliTypeEnum
		{
			Ilari_0 = 0,
			Ilari_1 = 1,
			Ilari_2 = 2,
			Pashli = 3,
			Unknown_255 = 255,
		}


		[WProperty("Ilari and Pashli (Bm4)", "Ilari and Pashli Type", true, "", SourceScene.Room)]
		public IlariandPashliTypeEnum IlariandPashliType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(IlariandPashliTypeEnum), value_as_int))
					value_as_int = 0;
				return (IlariandPashliTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("IlariandPashliType");
				UpdateModel();
			}
		}
		public enum NamaliandKogoliTypeEnum
		{
			Namali = 0,
			Kogoli = 1,
			Unknown_255 = 255,
		}


		[WProperty("Namali and Kogoli (Bm5)", "Namali and Kogoli Type", true, "", SourceScene.Room)]
		public NamaliandKogoliTypeEnum NamaliandKogoliType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(NamaliandKogoliTypeEnum), value_as_int))
					value_as_int = 0;
				return (NamaliandKogoliTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("NamaliandKogoliType");
				UpdateModel();
			}
		}
		public enum SpawnConditionEnum
		{
			Dins_Pearl_not_owned = 0,
			Got_Dins_Pearl_havent_left_DRI_yet = 1,
			Got_Dins_Pearl_left_DRI_is_daytime = 2,
			Got_Dins_Pearl_left_DRI_is_nighttime = 3,
			Always_spawns = 255,
		}


		[WProperty("npc_bm1", "Spawn Condition", true, "", SourceScene.Room)]
		public SpawnConditionEnum SpawnCondition
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(SpawnConditionEnum), value_as_int))
					value_as_int = 0;
				return (SpawnConditionEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SpawnCondition");
				UpdateModel();
			}
		}

		[WProperty("npc_bm1", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public npc_bm1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bmcon1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_bmcon1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_bmcon1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bms1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_bms1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_bms1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bmsw : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_bmsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bs1 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum WhichShopEnum
		{
			Bait_Bag_and_Bait_Shop_A = 0,
			Bait_Bag_and_Bait_Shop_B = 1,
			Arrows_and_Bait_Shop = 2,
			Arrows_Bombs_and_Potion_Shop = 3,
			Invalid_Shop = 255,
		}


		[WProperty("Beedle", "Which Shop", true, "", SourceScene.Room)]
		public WhichShopEnum WhichShop
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(WhichShopEnum), value_as_int))
					value_as_int = 3;
				return (WhichShopEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("WhichShop");
			}
		}

		[WProperty("Beedle", "Is Masked Beedle", true, "", SourceScene.Room)]
		public bool IsMaskedBeedle
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				if (value_as_int == 1) {
					return true;
				} else {
					return false;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("IsMaskedBeedle");
				UpdateModel();
			}
		}

		// Constructor
		public npc_bs1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_btsw : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_btsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_btsw2 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Baito (Outside)", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public npc_btsw2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_cb1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_cb1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_cb1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_co1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_co1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_co1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_de1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_de1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_de1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ds1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_ds1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ds1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_gk1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_gk1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_gk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_gp1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_gp1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_gp1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_gp1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_hi1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_hi1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_hi1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ho : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_ho(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_hr : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_hr", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
				UpdateModel();
			}
		}

		[WProperty("npc_hr", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("npc_hr", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_hr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			SwitchtoSet = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_jb1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_jb1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_jb1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ji1 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_ji1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kamome : TriggerRegion
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_kamome", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_kamome", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_kamome(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kf1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_kf1", "Unused Type", true, "", SourceScene.Room)]
		public int UnusedType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("UnusedType");
			}
		}

		[WProperty("npc_kf1", "Player Is Near Exit Switch", true, "The switch to check to know if the player is near the door leading out of the house. This is checked after the player destroys the fancy pots to know when they're trying to leave.", SourceScene.Room)]
		public int PlayerIsNearExitSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("PlayerIsNearExitSwitch");
			}
		}

		[WProperty("npc_kf1", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}
		public enum Unknown_4Enum
		{
			Unknown_0 = 0,
			Unknown_14 = 14,
		}


		[WProperty("npc_kf1", "Unknown_4", true, "", SourceScene.Room)]
		public Unknown_4Enum Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				if (!Enum.IsDefined(typeof(Unknown_4Enum), value_as_int))
					value_as_int = 0;
				return (Unknown_4Enum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public npc_kf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			UnusedType = -1;
			PlayerIsNearExitSwitch = -1;
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kg1 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_kg1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kg2 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_kg2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kk1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_kk1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_kk1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_kk1", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00030000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00030000 | (value_as_int << 16 & 0x00030000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("npc_kk1", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public npc_kk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_km1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_km1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_km1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ko1 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum ZillTypeEnum
		{
			Chasing_Zill = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Standing_Zill = 3,
			Sleeping_Zill = 4,
			Unknown_255 = 255,
		}


		[WProperty("Zill (Ko1)", "Zill Type", true, "", SourceScene.Room)]
		public ZillTypeEnum ZillType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(ZillTypeEnum), value_as_int))
					value_as_int = 0;
				return (ZillTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ZillType");
				UpdateModel();
			}
		}
		public enum JoelTypeEnum
		{
			Joel_with_Stick = 0,
			Unknown_1 = 1,
			Standing_Joel = 2,
			Sleeping_Joel = 3,
			Unknown_4 = 4,
			Unknown_255 = 255,
		}


		[WProperty("Joel (Ko2)", "Joel Type", true, "", SourceScene.Room)]
		public JoelTypeEnum JoelType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(JoelTypeEnum), value_as_int))
					value_as_int = 0;
				return (JoelTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("JoelType");
				UpdateModel();
			}
		}

		[WProperty("Zill and Joel", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public npc_ko1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kp1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_kp1", "Unused Type", true, "", SourceScene.Room)]
		public int UnusedType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("UnusedType");
			}
		}

		// Constructor
		public npc_kp1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			UnusedType = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ls1 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Looking_Out_of_Lookout = 0,
			Captured_in_FF1_on_Floor = 1,
			For_Cutscenes = 2,
			Telling_Link_to_See_Grandma = 3,
			Ending = 4,
			Unknown_255 = 255,
		}


		[WProperty("Aryll", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		// Constructor
		public npc_ls1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_md : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_md", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_md", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_md", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_md(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mk : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_mk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_mk", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_mk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mn : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_mn", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		[WProperty("npc_mn", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("npc_mn", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public npc_mn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			SwitchtoSet = -1;
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mt : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_mt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_nz : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_nz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ob1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_ob1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ob1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ob1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_os : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_os", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_os(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_p1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_p1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
				UpdateModel();
			}
		}

		[WProperty("npc_p1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_p1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_p2 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_p2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_1");
				UpdateModel();
			}
		}

		[WProperty("npc_p2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000003FC) >> 2);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000003FC | (value_as_int << 2 & 0x000003FC));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_p2", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0003FC00) >> 10);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0003FC00 | (value_as_int << 10 & 0x0003FC00));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_p2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_people : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Windfall Townsperson", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("Windfall Townsperson", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("Windfall Townsperson", "Unknown_3", true, "", SourceScene.Room)]
		public bool Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_people(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_pf1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_pf1", "Unused Type", true, "", SourceScene.Room)]
		public int UnusedType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("UnusedType");
			}
		}

		[WProperty("npc_pf1", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public npc_pf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			UnusedType = -1;
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_photo : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_photo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_photo", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_photo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_pm1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_pm1", "Unused Type", true, "", SourceScene.Room)]
		public int UnusedType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("UnusedType");
			}
		}

		// Constructor
		public npc_pm1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			UnusedType = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_roten : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_roten", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_roten", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
				UpdateModel();
			}
		}

		// Constructor
		public npc_roten(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_rsh1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_rsh1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_rsh1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_rsh1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_sarace : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_sarace(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_so : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_so(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_sv : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_sv(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_tc : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_tc", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_tc", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_tc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_tt : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public npc_tt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_uk : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Normal = 1,
			Hiding = 2,
		}


		[WProperty("npc_uk", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("npc_uk", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Path");
			}
		}
		public enum WhichKillerBeeEnum
		{
			Jin = 0,
			Jan = 1,
			JunRoberto = 2,
		}


		[WProperty("npc_uk", "Which Killer Bee", true, "", SourceScene.Room)]
		public WhichKillerBeeEnum WhichKillerBee
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				if (!Enum.IsDefined(typeof(WhichKillerBeeEnum), value_as_int))
					value_as_int = 0;
				return (WhichKillerBeeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("WhichKillerBee");
				UpdateModel();
			}
		}

		// Constructor
		public npc_uk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ym1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_ym1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ym1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_yw1 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_255 = 255,
		}


		[WProperty("Sue-Belle", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Sue-Belle", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public npc_yw1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_zk1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_zk1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_zk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_zl1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("npc_zl1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_zl1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class nz : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("nz", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("nz", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("nz", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public nz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class nzg : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Spawns_Rats = 0,
			Spawns_Bombchus = 1,
			Spawns_Rats_and_Bombchus = 2,
		}


		[WProperty("nzg", "Type", true, "The type that spawns just Rats also has the Rat Shopkeeper in it.\nThe type that spawns both Rats and Bombchus has a random 50% chance of which to spawn each time it spawns one.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("nzg", "Sight Range (Fives)", true, "This number multiplied by 5 is the range around the hole it will notice the player and start spawning Rats and/or Bombchus.", SourceScene.Room)]
		public int SightRangeFives
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SightRangeFives");
			}
		}

		[WProperty("nzg", "Maximum Number of Rats", true, "", SourceScene.Room)]
		public int MaximumNumberofRats
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("MaximumNumberofRats");
			}
		}
		public int Unused
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unused");
			}
		}

		// Constructor
		public nzg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeFives = -1;
			MaximumNumberofRats = -1;
			Unused = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_adnno : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_adnno(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ajav : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Jabun's Bombable Stone Wall", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_ajav(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ajavw : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_ajavw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_akabe : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum CollisionArchiveEnum
		{
			Akabe = 0,
			AkabeD = 1,
			AkabeK = 2,
			NBOX = 3,
		}


		[WProperty("Invisible Wall", "Collision Archive", true, "Akabe: Flat. Blocks Link, bombs, and most normal objects.\nAkabeD: Flat. Blocks arrows, light, and most normal objects. Does not block Link.\nAkabeK: Flat. Blocks normal objects, but does not block Link, bombs, arrows, or light.\nNBOX: Cube. Only blocks Link, and only around the sides - the top and bottom can be passed through.", SourceScene.Room)]
		public CollisionArchiveEnum CollisionArchive
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				if (!Enum.IsDefined(typeof(CollisionArchiveEnum), value_as_int))
					value_as_int = 0;
				return (CollisionArchiveEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("CollisionArchive");
				UpdateModel();
			}
		}

		[WProperty("Invisible Wall", "Disable Spawn Switch", true, "The invisible wall will disappear once this switch is set (unless \"Always On\" is checked).\nIf this value is set to 255, the wall will instead disappear once the player owns any sword, instead of checking a switch.", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}
		public enum ScaleModeEnum
		{
			Akabe = 0,
			Akabe10 = 1,
			NBOX = 2,
			NBOX10 = 3,
		}


		[WProperty("Invisible Wall", "Scale Mode", true, "", SourceScene.Room)]
		public ScaleModeEnum ScaleMode
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				if (!Enum.IsDefined(typeof(ScaleModeEnum), value_as_int))
					value_as_int = 0;
				return (ScaleModeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("ScaleMode");
				UpdateModel();
			}
		}

		[WProperty("Invisible Wall", "Always On", true, "If checked, the invisible wall will always exist. Otherwise, it disappear once its \"Disable Spawn Switch\" is set.", SourceScene.Room)]
		public bool AlwaysOn
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001000) >> 12);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00001000 | (value_as_int << 12 & 0x00001000));
				OnPropertyChanged("AlwaysOn");
			}
		}

		// Constructor
		public obj_akabe(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisableSpawnSwitch = -1;
			if (Name == "Akabe") {
				CollisionArchive = CollisionArchiveEnum.Akabe;
				ScaleMode = ScaleModeEnum.Akabe;
			}
			if (Name == "Akabe10") {
				CollisionArchive = CollisionArchiveEnum.Akabe;
				ScaleMode = ScaleModeEnum.Akabe10;
			}
			if (Name == "NBOX") {
				CollisionArchive = CollisionArchiveEnum.NBOX;
				ScaleMode = ScaleModeEnum.NBOX;
			}
			if (Name == "NBOX10") {
				CollisionArchive = CollisionArchiveEnum.NBOX;
				ScaleMode = ScaleModeEnum.NBOX10;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_apzl : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unsolved = 0,
			Solved = 1,
		}


		[WProperty("Sliding Puzzle", "Type", true, "Determines how the sliding puzzle acts.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Type");
			}
		}

		// Constructor
		public obj_apzl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ashut : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Barred Iron Door", "Switch to Check", true, "The door will be open for as long as this switch is set, and close if the switch is unset.\nNote that it will not close on top of the player even if the switch is unset when the player is under it.", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		[WProperty("Barred Iron Door", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_ashut(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_auzu : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Whirlpool", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		[WProperty("Whirlpool", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("Whirlpool", "Unknown_3", true, "", SourceScene.Room)]
		public bool Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("Whirlpool", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_auzu(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisableSpawnSwitch = -1;
			Unknown_2 = -1;
			Unknown_4 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_aygr : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_aygr", "Has Ladder", true, "", SourceScene.Room)]
		public bool HasLadder
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("HasLadder");
				UpdateModel();
			}
		}

		// Constructor
		public obj_aygr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_balancelift : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_balancelift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_balancelift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrel : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_barrel", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x70000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x70000000 | (value_as_int << 28 & 0x70000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrel", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_barrel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrel2 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_barrel2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrel2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_barrel2", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000400) >> 10);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000400 | (value_as_int << 10 & 0x00000400));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_barrel2", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_barrel2", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x03000000 | (value_as_int << 24 & 0x03000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_barrel2", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x10000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x10000000 | (value_as_int << 28 & 0x10000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_barrel2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_5 = -1;
			Unknown_6 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrier : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_barrier", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrier", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_barrier(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_bemos : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Blue_Beamos = 0,
			Red_Beamos = 1,
			Laser_Barrier = 2,
		}


		[WProperty("Beamos / Laser Barrier", "Type", true, "Blue Beamos always fire at a specific spot.\nRed Beamos track the player with their laser.\nLaser Barriers fire a laser along a path to block the player.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Beamos", "Sight Range (Hundreds)", true, "This number multiplied by 100 and added to 500 is the range within it will notice the player and start firing a laser.", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("Laser Barrier", "Deactivation Switch", true, "It will stop firing a laser once this switch is set.", SourceScene.Room)]
		public int DeactivationSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DeactivationSwitch");
			}
		}

		[WProperty("Red Beamos", "Head Rotation Speed", true, "The speed the Red Beamos rotates its head at.", SourceScene.Room)]
		public int HeadRotationSpeed
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int > 127) {
					return value_as_int - 256;
				} else {
					return value_as_int;
				}
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("HeadRotationSpeed");
			}
		}
		public enum BehaviorTypeEnum
		{
			Normal = 0,
			Only_fires_if_Servant_present = 1,
			Lasers_are_not_solid = 2,
		}


		[WProperty("Laser Barrier", "Behavior Type", true, "\"Only fires if Servant present\" types won't start firing their laser unless a Servant of the Tower is in the room.\n\"Lasers are not solid\" types fire lasers that don't have solid collision - they still damage the player and knock them back, but the player can walk through the lasers with iframes.", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("Laser Barrier", "Laser Path", true, "The path for the laser to go along.\nIf this is not set, this will only be half of a laser barrier, and it won't follow any path.", SourceScene.Room)]
		public Path_v2 LaserPath
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("LaserPath");
			}
		}

		[WProperty("Beamos", "Dropped Item", true, "", SourceScene.Room)]
		public DroppedItemID DroppedItem
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x003F) >> 0);
				if (!Enum.IsDefined(typeof(DroppedItemID), value_as_int))
					value_as_int = 0;
				return (DroppedItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_ZRotation = (short)(m_ZRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("DroppedItem");
			}
		}

		[WProperty("Beamos", "Dropped Item Pickup Flag", true, "", SourceScene.Room)]
		public int DroppedItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x1FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x1FC0 | (value_as_int << 6 & 0x1FC0));
				OnPropertyChanged("DroppedItemPickupFlag");
			}
		}

		// Constructor
		public obj_bemos(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
			TypeSpecificCategories["Type"] = new Dictionary<object, string[]>();
			TypeSpecificCategories["Type"][TypeEnum.Blue_Beamos] = new string[] { "Beamos" };
			TypeSpecificCategories["Type"][TypeEnum.Red_Beamos] = new string[] { "Beamos", "Red Beamos" };
			TypeSpecificCategories["Type"][TypeEnum.Laser_Barrier] = new string[] { "Laser Barrier" };
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeHundreds = -1;
			DeactivationSwitch = -1;
			HeadRotationSpeed = -1;
			LaserPath = null;
			DroppedItem = DroppedItemID.No_item;
			DroppedItemPickupFlag = -1;
			if (Name == "Hmos1") {
				Type = TypeEnum.Blue_Beamos;
			}
			if (Name == "Hmos2") {
				Type = TypeEnum.Red_Beamos;
			}
			if (Name == "Hmos3") {
				Type = TypeEnum.Laser_Barrier;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_bscurtain : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_bscurtain", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_bscurtain(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_buoyflag : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_buoyflag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_buoyflag", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_buoyflag", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_buoyflag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_buoyrace : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_buoyrace", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_buoyrace", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_buoyrace(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_cafelmp : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_cafelmp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_canon : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Wall-Mounted Cannon", "Extra Scale", true, "Amount to add to this cannon's scale, in increments of 10%.\nFor example, setting this to 5 would make the cannon 1.5 times larger than normal.\n0 and 255 both do not add any extra scale.", SourceScene.Room)]
		public int ExtraScale
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ExtraScale");
				UpdateModel();
			}
		}

		[WProperty("Wall-Mounted Cannon", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("Wall-Mounted Cannon", "Visible Area Path", true, "This cannon will only be able to see Link when he is inside the area of this path.", SourceScene.Room)]
		public Path_v2 VisibleAreaPath
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("VisibleAreaPath");
			}
		}

		[WProperty("Wall-Mounted Cannon", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public obj_canon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			ExtraScale = -1;
			EnableSpawnSwitch = -1;
			VisibleAreaPath = null;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_coming : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_coming", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_coming", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000040) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000040 | (value_as_int << 6 & 0x00000040));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_coming", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000700) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000700 | (value_as_int << 8 & 0x00000700));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_coming", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_coming", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x03000000 | (value_as_int << 24 & 0x03000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_coming", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x30000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x30000000 | (value_as_int << 28 & 0x30000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_coming(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_5 = -1;
			Unknown_6 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_correct : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_5 = 5,
			Unknown_6 = 6,
			Unknown_7 = 7,
		}


		[WProperty("obj_correct", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("obj_correct", "Switch to Set", true, "The switch to set for as long as the desired actor is placed within range of this detector actor.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("obj_correct", "Event", true, "", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Event");
			}
		}

		// Constructor
		public obj_correct(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			Event = null;
			if (Name == "BLK_CR") {
				Type = TypeEnum.Unknown_0;
			}
			if (Name == "CrTrS3") {
				Type = TypeEnum.Unknown_1;
			}
			if (Name == "CrTrS4") {
				Type = TypeEnum.Unknown_2;
			}
			if (Name == "CrTrS5") {
				Type = TypeEnum.Unknown_3;
			}
			if (Name == "CrTrM1") {
				Type = TypeEnum.Unknown_4;
			}
			if (Name == "CrTrM2") {
				Type = TypeEnum.Unknown_5;
			}
			if (Name == "CrTrGr") {
				Type = TypeEnum.Unknown_6;
			}
			if (Name == "CrTrBl") {
				Type = TypeEnum.Unknown_7;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_demo_barrel : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_demo_barrel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_dmgroom : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_dmgroom(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_doguu : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_doguu", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_doguu(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_doguu_demo : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_doguu_demo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_doguu_demo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_dragonhead : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_dragonhead", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_dragonhead(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_drift : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_drift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_drift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eayogn : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_eayogn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ebomzo : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Bombable Rito Statue", "Bombed Switch", true, "Switch that determines whether the statue has been bombed.", SourceScene.Room)]
		public int BombedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BombedSwitch");
			}
		}

		// Constructor
		public obj_ebomzo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			BombedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eff : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_eff", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_eff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ekskz : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Octorok Wind Statue", "Destroyed Switch", true, "", SourceScene.Room)]
		public int DestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DestroyedSwitch");
			}
		}

		// Constructor
		public obj_ekskz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DestroyedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eskban : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Bomb Rock (Bomb Flower Only)", "Destroyed Switch", true, "The switch to set when the rock is destroyed.", SourceScene.Room)]
		public int DestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DestroyedSwitch");
			}
		}

		// Constructor
		public obj_eskban(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DestroyedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ferris : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_ferris", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ferris(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_figure : Actor
	{
		// Auto-Generated Properties from Templates
		public enum WhichFigurineEnum
		{
			Aryll = 0,
			Links_Grandma = 1,
			SueBelle = 2,
			Sturgeon = 3,
			Orca = 4,
			Abe = 5,
			Rose = 6,
			Mesa = 7,
			Joel = 8,
			Zill = 9,
			Jabun = 10,
			Wild_Pig = 11,
			Seagull = 12,
			Crab = 13,
			Tott = 14,
			Mila = 15,
			Milas_Father = 16,
			Maggie = 17,
			Maggies_Father = 18,
			BombMaster_Cannon = 19,
			The_Potion_Master_Doc_Bandam = 20,
			The_Pictographer_Lenzo = 21,
			The_Shop_Guru_Zunari = 22,
			The_Joyful_Teacher_Mrs_Marie = 23,
			Windfalls_Gang_of_Boys_The_Killer_Bees = 24,
			Potova_and_Joanna = 25,
			Anton = 26,
			Kreeb = 27,
			Kamo = 28,
			Gillian = 29,
			Linda = 30,
			Sam = 31,
			Gossack = 32,
			Garrickson = 33,
			Pompie_and_Vera = 34,
			Missy = 35,
			Minenco = 36,
			Gummy_the_Sailor = 37,
			Kane_the_Sailor = 38,
			Dampa_the_Sailor = 39,
			Candy_the_Sailor = 40,
			Tetra = 41,
			Gonzo = 42,
			Senza = 43,
			Nudge = 44,
			Zuko = 45,
			Niko = 46,
			Mako = 47,
			Tingle = 48,
			Ankle = 49,
			Knuckle = 50,
			David_Jr = 51,
			Fishman = 52,
			Traveling_Merchants = 53,
			Old_Man_Ho_Ho = 54,
			Beedle = 55,
			Salvatore = 56,
			Loot_the_Sailor = 57,
			Salvage_Corp = 58,
			Fairy = 59,
			Great_Fairy = 60,
			Queen_of_Fairies = 61,
			Princess_Zelda = 62,
			King_of_Hyrule = 63,
			Link_and_the_King_of_Red_Lions = 64,
			Medli = 65,
			Komali = 66,
			The_Rito_Chieftain = 67,
			Quill_the_Postman = 68,
			Skett_and_Akoot = 69,
			Kogoli = 70,
			Ilari = 71,
			Hoskit = 72,
			Namali = 73,
			Basht_and_Bisht = 74,
			Obli = 75,
			Willi = 76,
			Koboli = 77,
			Pashli = 78,
			Baito = 79,
			Valoo = 80,
			Zephos_and_Cyclos = 81,
			Laruto = 82,
			Makar = 83,
			Olivio = 84,
			Aldo = 85,
			Oakin = 86,
			Drona = 87,
			Irch = 88,
			Rown = 89,
			Hollo = 90,
			Elma = 91,
			Linder = 92,
			Deku_Tree = 93,
			Carlov_the_Sculptor = 94,
			Manny = 95,
			Fado = 96,
			Bokoblin = 97,
			Miniblin = 98,
			ChuChu = 99,
			Rat = 100,
			Keese_and_Fire_Keese = 101,
			Magtail = 102,
			Kargaroc = 103,
			Peahat = 104,
			Boko_Baba = 105,
			Morth = 106,
			Red_Bubble_and_Blue_Bubble = 107,
			Floor_Master = 108,
			Armos = 109,
			Armos_Knight = 110,
			Poe = 111,
			ReDead = 112,
			Octorok = 113,
			Seahat = 114,
			Gyorg = 115,
			Moblin = 116,
			Mothula = 117,
			Darknut = 118,
			Shield_Darknut = 119,
			Mighty_Darknut = 120,
			Phantom_Ganon = 121,
			Stalfos = 122,
			Wizzrobe = 123,
			Miniboss_Wizzrobe = 124,
			Big_Octo = 125,
			Gohma = 126,
			Kalle_Demos = 127,
			Gohdan_The_Great_Arbiter = 128,
			The_Monstrous_Helmaroc_King = 129,
			Jalhalla_Protector_of_the_Seal = 130,
			Molgera_Protector_of_the_Seal = 131,
			Puppet_Ganon = 132,
			Ganondorf = 133,
		}


		[WProperty("Figurine", "Which Figurine", true, "", SourceScene.Room)]
		public WhichFigurineEnum WhichFigurine
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(WhichFigurineEnum), value_as_int))
					value_as_int = 0;
				return (WhichFigurineEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("WhichFigurine");
				UpdateModel();
			}
		}

		// Constructor
		public obj_figure(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_firewall : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_firewall", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_firewall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_flame : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Medium_Jet = 0,
			Large_Jet = 1,
			Very_Large_Jet = 2,
			Small_Jet = 3,
		}


		[WProperty("Magma Jet", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x30000000) >> 28);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x30000000 | (value_as_int << 28 & 0x30000000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Magma Jet", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("Magma Jet", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001F00 | (value_as_int << 8 & 0x00001F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("Magma Jet", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00006000) >> 13);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00006000 | (value_as_int << 13 & 0x00006000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("Magma Jet", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("Magma Jet", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_flame(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "YXZ";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_6 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ftree : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_ftree", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ftree(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ganonbed : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_ganonbed(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gaship : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_gaship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gaship2 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_gaship2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnnbtltaki : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_gnnbtltaki", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_gnnbtltaki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnndemotakie : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_gnndemotakie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnndemotakis : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_gnndemotakis(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gong : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_gong(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gryw00 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Lake Outside Dragon Roost Cavern", "Activation Switch", true, "The switch that must be set for the lake to become active.", SourceScene.Room)]
		public int ActivationSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ActivationSwitch");
			}
		}

		// Constructor
		public obj_gryw00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			ActivationSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gtaki : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_gtaki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami2 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hami2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hami2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami3 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hami3", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hami3", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hami3", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hami3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami4 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hami4", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hami4(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hat : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hat", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hbrf1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hbrf1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hbrf1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hbrf1", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hbrf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hcbh : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hcbh", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hcbh", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001FC0 | (value_as_int << 6 & 0x00001FC0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hcbh", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x001FE000) >> 13);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x001FE000 | (value_as_int << 13 & 0x001FE000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hcbh(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hfuck1 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_hfuck1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hha : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hha", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hha", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_hha(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hlift : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hlift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hlift", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000010) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000010 | (value_as_int << 4 & 0x00000010));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hlift", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_hlift", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_hlift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hole : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Entrance Hole", "Exit", true, "", SourceScene.Room)]
		public ExitData Exit
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Exit");
			}
		}

		[WProperty("Entrance Hole", "Has Visible Hole", true, "", SourceScene.Room)]
		public bool HasVisibleHole
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("HasVisibleHole");
				UpdateModel();
			}
		}

		[WProperty("Entrance Hole", "Hole Scale", true, "If this is not 65535, this number divided by 6.5 is added to the scale of the hole.", SourceScene.Room)]
		public int HoleScale
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("HoleScale");
				UpdateModel();
			}
		}

		// Constructor
		public obj_hole(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Exit = null;
			HoleScale = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_homen : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Large_Stone_Head = 0,
			Small_Stone_Head = 1,
		}


		[WProperty("Stone Head", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Stone Head", "Dropped Item", true, "", SourceScene.Room)]
		public DroppedItemID DroppedItem
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0003F000) >> 12);
				if (!Enum.IsDefined(typeof(DroppedItemID), value_as_int))
					value_as_int = 0;
				return (DroppedItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0003F000 | (value_as_int << 12 & 0x0003F000));
				OnPropertyChanged("DroppedItem");
			}
		}

		[WProperty("Stone Head", "Item Pickup Flag", true, "", SourceScene.Room)]
		public int ItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000007F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000007F | (value_as_int << 0 & 0x0000007F));
				OnPropertyChanged("ItemPickupFlag");
			}
		}
		public enum EnemytoSpawnEnum
		{
			Blue_Bokoblin_with_Unlit_Torch = 0,
			Green_Bokoblin_with_Unlit_Torch = 1,
			Blue_Bokoblin_with_Machete = 2,
			Green_Bokoblin_with_with_Machete = 3,
			Blue_Bokoblin_with_Lit_Torch = 4,
			Green_Bokoblin_with_Lit_Torch = 5,
			Green_ChuChu = 6,
			Red_ChuChu = 7,
			Blue_ChuChu = 8,
			Dark_ChuChu = 9,
			Yellow_ChuChu = 10,
			No_Enemy = 15,
		}


		[WProperty("Stone Head", "Enemy to Spawn", true, "", SourceScene.Room)]
		public EnemytoSpawnEnum EnemytoSpawn
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x003C0000) >> 18);
				if (!Enum.IsDefined(typeof(EnemytoSpawnEnum), value_as_int))
					value_as_int = 15;
				return (EnemytoSpawnEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x003C0000 | (value_as_int << 18 & 0x003C0000));
				OnPropertyChanged("EnemytoSpawn");
			}
		}

		[WProperty("Stone Head", "Destroyed Switch", true, "", SourceScene.Room)]
		public int DestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DestroyedSwitch");
			}
		}

		// Constructor
		public obj_homen(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DroppedItem = DroppedItemID.No_item;
			ItemPickupFlag = -1;
			DestroyedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_homensmoke : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_homensmoke", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_homensmoke", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000002) >> 1);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000002 | (value_as_int << 1 & 0x00000002));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_homensmoke(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hsehi1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_hsehi1", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("obj_hsehi1", "Message", true, "", SourceScene.Room)]
		public int Message
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FFFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FFFF00 | (value_as_int << 8 & 0x00FFFF00));
				OnPropertyChanged("Message");
			}
		}

		// Constructor
		public obj_hsehi1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			Message = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_htetu1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_htetu1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_htetu1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ice : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Chunk of Ice", "Melted Switch", true, "Switch to set once this chunk of ice has been melted.", SourceScene.Room)]
		public int MeltedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("MeltedSwitch");
			}
		}

		// Constructor
		public obj_ice(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			MeltedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_iceisland : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_iceisland", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_iceisland(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ikada : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Raft = 0,
			Beedles_Shop_Ship = 1,
			Submarine = 2,
			Beedles_Special_Shop_Ship = 3,
			Salvage_Corp_Ship = 4,
		}


		[WProperty("Various Ships", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Rafts, Beedle, and Submarines", "Interior Room Number", true, "Which room of the destination stage to take the player into when they enter the ship.\n\nWhat the destination stage is depends on the Exit Index specified in the ship's DZB collision file.\nIf the Exit Index is 62, the destination stage will be 'Obshop' (Beedle's Shop Ship).\nIf the Exit Index is 59, the destination stage will be 'Abship' (Submarines).", SourceScene.Room)]
		public int InteriorRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000003F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000003F0 | (value_as_int << 4 & 0x000003F0));
				OnPropertyChanged("InteriorRoomNumber");
			}
		}

		[WProperty("Rafts, Beedle, and Submarines", "Interior Spawn ID", true, "Which spawn ID of the room in destination stage to spawn the player at when they enter the ship.\n\nWhat the destination stage is depends on the Exit Index specified in the ship's DZB collision file.\nIf the Exit Index is 62, the destination stage will be 'Obshop' (Beedle's Shop Ship).\nIf the Exit Index is 59, the destination stage will be 'Abship' (Submarines).", SourceScene.Room)]
		public int InteriorSpawnID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0003FC00) >> 10);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0003FC00 | (value_as_int << 10 & 0x0003FC00));
				OnPropertyChanged("InteriorSpawnID");
			}
		}

		[WProperty("Rafts, Beedle, and Submarines", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03FC0000) >> 18);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x03FC0000 | (value_as_int << 18 & 0x03FC0000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("Rafts, Beedle, and Submarines", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("Rafts, Beedle, and Submarines", "Path to Follow", true, "", SourceScene.Room)]
		public Path_v2 PathtoFollow
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_XRotation = (short)(m_XRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("PathtoFollow");
			}
		}

		[WProperty("Salvage Corp Ship", "Salvage Corp Path to Follow", true, "", SourceScene.Room)]
		public Path_v2 SalvageCorpPathtoFollow
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SalvageCorpPathtoFollow");
			}
		}

		// Constructor
		public obj_ikada(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
			TypeSpecificCategories["Type"] = new Dictionary<object, string[]>();
			TypeSpecificCategories["Type"][TypeEnum.Raft] = new string[] { "Rafts, Beedle, and Submarines" };
			TypeSpecificCategories["Type"][TypeEnum.Beedles_Shop_Ship] = new string[] { "Rafts, Beedle, and Submarines" };
			TypeSpecificCategories["Type"][TypeEnum.Submarine] = new string[] { "Rafts, Beedle, and Submarines" };
			TypeSpecificCategories["Type"][TypeEnum.Beedles_Special_Shop_Ship] = new string[] { "Rafts, Beedle, and Submarines" };
			TypeSpecificCategories["Type"][TypeEnum.Salvage_Corp_Ship] = new string[] { "Salvage Corp Ship" };
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			InteriorRoomNumber = -1;
			InteriorSpawnID = -1;
			Unknown_5 = -1;
			Unknown_6 = -1;
			PathtoFollow = null;
			SalvageCorpPathtoFollow = null;
			if (Name == "Ikada") {
				Type = TypeEnum.Raft;
			}
			if (Name == "ikada_h") {
				Type = TypeEnum.Beedles_Shop_Ship;
			}
			if (Name == "ikadaS") {
				Type = TypeEnum.Submarine;
			}
			if (Name == "ikada_u") {
				Type = TypeEnum.Beedles_Special_Shop_Ship;
			}
			if (Name == "Svsp") {
				Type = TypeEnum.Salvage_Corp_Ship;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Itnak : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_Itnak", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_Itnak", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_Itnak(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_jump : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_jump", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_jump(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_kanat : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_kanat", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_kanat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_kanoke : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Coffin", "Is Upright", true, "", SourceScene.Room)]
		public bool IsUpright
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("IsUpright");
				UpdateModel();
			}
		}

		[WProperty("Coffin", "Sight Range (Hundreds)", true, "This number multiplied by 100 is the range within it will notice Link and open up by itself. Can be set to 0 so it never opens up.", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003E) >> 1);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003E | (value_as_int << 1 & 0x0000003E));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("Coffin", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000040) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000040 | (value_as_int << 6 & 0x00000040));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("Coffin", "Opened Switch", true, "", SourceScene.Room)]
		public int OpenedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("OpenedSwitch");
			}
		}

		[WProperty("Coffin", "Unused Switch", true, "", SourceScene.Room)]
		public int UnusedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("UnusedSwitch");
			}
		}
		public int UnusedZRotation
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("UnusedZRotation");
			}
		}

		// Constructor
		public obj_kanoke(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeHundreds = -1;
			Unknown_3 = -1;
			OpenedSwitch = -1;
			UnusedSwitch = -1;
			UnusedZRotation = -1;
			if (Name == "MKanoke") {
				IsUpright = false;
			}
			if (Name == "MKanok2") {
				IsUpright = true;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ladder : Actor
	{
		// Auto-Generated Properties from Templates
		public enum LengthEnum
		{
			Short = 0,
			Medium = 1,
			Long = 2,
			Very_Long = 3,
			Very_Short = 4,
		}


		[WProperty("obj_ladder", "Length", true, "", SourceScene.Room)]
		public LengthEnum Length
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				if (!Enum.IsDefined(typeof(LengthEnum), value_as_int))
					value_as_int = 0;
				return (LengthEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Length");
				UpdateModel();
			}
		}

		[WProperty("obj_ladder", "Switch to Check", true, "When this switch is set, the ladder will fall down.", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		[WProperty("obj_ladder", "Fall Event", true, "", SourceScene.Stage)]
		public MapEvent FallEvent
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("FallEvent");
			}
		}

		// Constructor
		public obj_ladder(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			FallEvent = null;
			if (Name == "Mhsg6") {
				Length = LengthEnum.Short;
			}
			if (Name == "Mhsg9") {
				Length = LengthEnum.Medium;
			}
			if (Name == "Mhsg12") {
				Length = LengthEnum.Long;
			}
			if (Name == "Mhsg15") {
				Length = LengthEnum.Very_Long;
			}
			if (Name == "Mhsg4h") {
				Length = LengthEnum.Very_Short;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_leaves : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_leaves", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_leaves", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001FC0 | (value_as_int << 6 & 0x00001FC0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_leaves", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x001FE000) >> 13);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x001FE000 | (value_as_int << 13 & 0x001FE000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_leaves(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_light : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_light(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_lpalm : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_lpalm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_magmarock : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_magmarock", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_magmarock", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_magmarock(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_majyuu_door : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_majyuu_door", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_majyuu_door(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mkie : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_mkie", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mkie", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
				UpdateModel();
			}
		}

		[WProperty("obj_mkie", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001000 | (value_as_int << 12 & 0x00001000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_mkie", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00002000) >> 13);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00002000 | (value_as_int << 13 & 0x00002000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_mkie", "Destroyed Switch", true, "", SourceScene.Room)]
		public int DestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("DestroyedSwitch");
			}
		}

		// Constructor
		public obj_mkie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			DestroyedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mkiek : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Dissolving Wall", "Switch to Set", true, "The switch to set when this wall is dissolved by light.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("Dissolving Wall", "Do Not Play Jingle", true, "If checked, dissolving this wall does not play the 'Puzzle Solved' jingle it normally would.", SourceScene.Room)]
		public bool DoNotPlayJingle
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("DoNotPlayJingle");
			}
		}

		// Constructor
		public obj_mkiek(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mknjd : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_mknjd", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("obj_mknjd", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_mknjd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mmrr : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_mmrr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_monument : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_monument", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_monument", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_monument(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_movebox : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Breakable_Wooden_Crate = 0,
			Black_Box_A = 1,
			Black_Box_With_Statue_on_Top = 2,
			Big_Black_Box = 3,
			Unbreakable_Wooden_Crate_A = 4,
			Golden_Crate = 5,
			Metal_Box = 6,
			Metal_Box_With_Spring = 7,
			Unbreakable_Wooden_Crate_B = 8,
			Unbreakable_Wooden_Crate_C = 9,
			Mirror = 10,
			Black_Box_B = 11,
			Mossy_Black_Box = 12,
		}


		[WProperty("Movable Box", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Movable Box", "Disable Flag on Top", true, "", SourceScene.Room)]
		public bool DisableFlagonTop
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("DisableFlagonTop");
			}
		}

		[WProperty("Movable Box", "Unknown_7", true, "For the \"Black Box With Statue on Top\" type, this will be passed as parameter Unknown_1 to the statue entity (obj_mkie) spawned on top of the box.", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("Movable Box Item", "Dropped Item", true, "", SourceScene.Room)]
		public DroppedItemID DroppedItem
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				if (!Enum.IsDefined(typeof(DroppedItemID), value_as_int))
					value_as_int = 0;
				return (DroppedItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("DroppedItem");
			}
		}

		[WProperty("Movable Box Item", "Dropped Item Pickup Flag", true, "", SourceScene.Room)]
		public int DroppedItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("DroppedItemPickupFlag");
			}
		}

		[WProperty("Movable Box Stay Moved Options", "Do Not Stay Moved After Reload", true, "", SourceScene.Room)]
		public bool DoNotStayMovedAfterReload
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x40000000) >> 30);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x40000000 | (value_as_int << 30 & 0x40000000));
				OnPropertyChanged("DoNotStayMovedAfterReload");
			}
		}

		[WProperty("Movable Box Stay Moved Options", "Stay Moved to Path", true, "", SourceScene.Room)]
		public Path_v2 StayMovedtoPath
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("StayMovedtoPath");
			}
		}

		[WProperty("Movable Box Stay Moved Options", "Stay Moved Switch 1", true, "The switch to keep track of the box being moved to point 1 on its path.", SourceScene.Room)]
		public int StayMovedSwitch1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("StayMovedSwitch1");
			}
		}

		[WProperty("Movable Box Stay Moved Options", "Stay Moved Switch 2", true, "The switch to keep track of the box being moved to point 2 on its path.", SourceScene.Room)]
		public int StayMovedSwitch2
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("StayMovedSwitch2");
			}
		}

		// Constructor
		public obj_movebox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_7 = -1;
			DroppedItem = DroppedItemID.No_item;
			DroppedItemPickupFlag = -1;
			StayMovedtoPath = null;
			StayMovedSwitch1 = -1;
			StayMovedSwitch2 = -1;
			if (Name == "osiBLK0") {
				Type = TypeEnum.Black_Box_A;
			}
			if (Name == "osiBLK1") {
				Type = TypeEnum.Black_Box_With_Statue_on_Top;
			}
			if (Name == "Kkiba") {
				Type = TypeEnum.Breakable_Wooden_Crate;
			}
			if (Name == "Hseki2") {
				Type = TypeEnum.Unbreakable_Wooden_Crate_B;
			}
			if (Name == "Hseki7") {
				Type = TypeEnum.Unbreakable_Wooden_Crate_C;
			}
			if (Name == "Mmrr") {
				Type = TypeEnum.Mirror;
			}
			if (Name == "MkieBB") {
				Type = TypeEnum.Black_Box_B;
			}
			if (Name == "Ecube") {
				Type = TypeEnum.Mossy_Black_Box;
			}
			if (Name == "Hjump1") {
				Type = TypeEnum.Metal_Box_With_Spring;
			}
			if (Name == "Hbox1") {
				Type = TypeEnum.Metal_Box;
			}
			if (Name == "MpwrB") {
				Type = TypeEnum.Big_Black_Box;
			}
			if (Name == "DBLK0") {
				Type = TypeEnum.Black_Box_A;
				DoNotStayMovedAfterReload = true;
			}
			if (Name == "DBLK1") {
				Type = TypeEnum.Black_Box_With_Statue_on_Top;
				DoNotStayMovedAfterReload = true;
			}
			if (Name == "DKkiba") {
				Type = TypeEnum.Breakable_Wooden_Crate;
				DoNotStayMovedAfterReload = true;
			}
			if (Name == "Hbox2") {
				Type = TypeEnum.Golden_Crate;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_msdan", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}
		public enum StaircaseLengthEnum
		{
			_15_Stairs = 0,
			_31_Stairs = 1,
		}


		[WProperty("obj_msdan", "Staircase Length", true, "", SourceScene.Room)]
		public StaircaseLengthEnum StaircaseLength
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				if (!Enum.IsDefined(typeof(StaircaseLengthEnum), value_as_int))
					value_as_int = 0;
				return (StaircaseLengthEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("StaircaseLength");
			}
		}

		[WProperty("obj_msdan", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00040000) >> 18);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00040000 | (value_as_int << 18 & 0x00040000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_msdan", "Event", true, "", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Event");
			}
		}

		// Constructor
		public obj_msdan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			Unknown_3 = -1;
			Event = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan2 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_msdan2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_msdan2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan_sub : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Earth Temple Staircase Single Stair", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		[WProperty("Earth Temple Staircase Single Stair", "Which Stair Index", true, "", SourceScene.Room)]
		public int WhichStairIndex
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("WhichStairIndex");
			}
		}
		public enum StaircaseLengthEnum
		{
			_15_Stairs = 0,
			_31_Stairs = 1,
		}


		[WProperty("Earth Temple Staircase Single Stair", "Staircase Length", true, "", SourceScene.Room)]
		public StaircaseLengthEnum StaircaseLength
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				if (!Enum.IsDefined(typeof(StaircaseLengthEnum), value_as_int))
					value_as_int = 0;
				return (StaircaseLengthEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("StaircaseLength");
			}
		}

		// Constructor
		public obj_msdan_sub(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			WhichStairIndex = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan_sub2 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_msdan_sub2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_msdan_sub2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_msdan_sub2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mshokki : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Pitcher = 0,
			Plate = 1,
			Cup = 2,
		}


		[WProperty("Tableware Spawner", "Type", true, "The kind of tableware that will spawn.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Type");
			}
		}

		// Constructor
		public obj_mshokki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mtest : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Water_Splashes = 4,
			Unknown_5 = 5,
			Unknown_6 = 6,
			Unknown_7 = 7,
		}


		[WProperty("obj_mtest", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("obj_mtest", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoCheck");
			}
		}
		public enum ConditionTypeEnum
		{
			Appear_if_switch_is_set = 0,
			Appear_if_switch_is_not_set = 1,
			Always_appear = 2,
		}


		[WProperty("obj_mtest", "Condition Type", true, "", SourceScene.Room)]
		public ConditionTypeEnum ConditionType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				if (!Enum.IsDefined(typeof(ConditionTypeEnum), value_as_int))
					value_as_int = 2;
				return (ConditionTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("ConditionType");
			}
		}

		[WProperty("obj_mtest", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_mtest(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			Unknown_4 = -1;
			if (Name == "Mcube") {
				Type = TypeEnum.Unknown_0;
			}
			if (Name == "Mcyln") {
				Type = TypeEnum.Unknown_1;
			}
			if (Name == "Mcube10") {
				Type = TypeEnum.Unknown_2;
			}
			if (Name == "Mcyln10") {
				Type = TypeEnum.Unknown_3;
			}
			if (Name == "MwtrSB") {
				Type = TypeEnum.Water_Splashes;
			}
			if (Name == "MygnSB") {
				Type = TypeEnum.Unknown_5;
			}
			if (Name == "Owater") {
				Type = TypeEnum.Unknown_6;
			}
			if (Name == "Astop") {
				Type = TypeEnum.Unknown_7;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_nest : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_nest(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ohatch : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Nintendo Gallery Hatch", "Opened Switch", true, "", SourceScene.Room)]
		public int OpenedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("OpenedSwitch");
			}
		}

		// Constructor
		public obj_ohatch(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			OpenedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ojtree : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_ojtree(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ospbox : Actor
	{
		// Auto-Generated Properties from Templates
		public enum WhattoDropEnum
		{
			Item = 0,
			Pink_Pig = 1,
			Speckled_Pig = 2,
			Black_Pig = 3,
		}


		[WProperty("Pirate Ship Crate", "What to Drop", true, "", SourceScene.Room)]
		public WhattoDropEnum WhattoDrop
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000700) >> 8);
				if (!Enum.IsDefined(typeof(WhattoDropEnum), value_as_int))
					value_as_int = 0;
				return (WhattoDropEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000700 | (value_as_int << 8 & 0x00000700));
				OnPropertyChanged("WhattoDrop");
			}
		}

		[WProperty("Pirate Ship Crate", "Dropped Item ID", true, "", SourceScene.Room)]
		public DroppedItemID DroppedItemID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				if (!Enum.IsDefined(typeof(DroppedItemID), value_as_int))
					value_as_int = 0;
				return (DroppedItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("DroppedItemID");
			}
		}

		// Constructor
		public obj_ospbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DroppedItemID = DroppedItemID.No_item;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_otble : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_otble", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_otble(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_paper : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Normal_Papers = 0,
			Ornate_Papers = 1,
			Stone = 2,
		}


		[WProperty("obj_paper", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}
		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("MessageID");
			}
		}

		// Constructor
		public obj_paper(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			MessageID = -1;
			if (Name == "Paper") {
				Type = TypeEnum.Normal_Papers;
			}
			if (Name == "Ppos") {
				Type = TypeEnum.Ornate_Papers;
			}
			if (Name == "Piwa") {
				Type = TypeEnum.Stone;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pbco : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_pbco(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pbka : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_pbka(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pfall : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_pfall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pirateship : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Pirate Ship", "Unknown_1", true, "", SourceScene.Room)]
		public bool Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}
		public enum DoorTypeEnum
		{
			Normal = 0,
			Requires_password = 1,
		}


		[WProperty("Pirate Ship", "Door Type", true, "", SourceScene.Room)]
		public DoorTypeEnum DoorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(DoorTypeEnum), value_as_int))
					value_as_int = 0;
				return (DoorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("DoorType");
			}
		}

		[WProperty("Pirate Ship", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}
		public enum Unknown_4Enum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_5 = 255,
		}


		[WProperty("Pirate Ship", "Unknown_4", true, "", SourceScene.Room)]
		public Unknown_4Enum Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (!Enum.IsDefined(typeof(Unknown_4Enum), value_as_int))
					value_as_int = 255;
				return (Unknown_4Enum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_pirateship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_plant : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_plant(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_quake : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_quake", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_quake", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000700) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000700 | (value_as_int << 8 & 0x00000700));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_quake", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00003800) >> 11);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00003800 | (value_as_int << 11 & 0x00003800));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_quake(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rcloud : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_rcloud", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_rcloud(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rflw : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_rflw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rforce : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_rforce(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_roten : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_roten", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_roten(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_search : Actor
	{
		// Auto-Generated Properties from Templates
		public enum Unknown_1Enum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_255 = 255,
		}


		[WProperty("Searchlight", "Unknown_1", true, "", SourceScene.Room)]
		public Unknown_1Enum Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(Unknown_1Enum), value_as_int))
					value_as_int = 0;
				return (Unknown_1Enum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}
		public enum Unknown_2Enum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_5 = 5,
			Unknown_6 = 6,
		}


		[WProperty("Searchlight", "Unknown_2", true, "", SourceScene.Room)]
		public Unknown_2Enum Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(Unknown_2Enum), value_as_int))
					value_as_int = 0;
				return (Unknown_2Enum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("Searchlight", "Path to Search", true, "", SourceScene.Room)]
		public Path_v2 PathtoSearch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("PathtoSearch");
			}
		}

		[WProperty("Searchlight", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		[WProperty("Searchlight", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_search(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			PathtoSearch = null;
			SwitchtoCheck = -1;
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_shelf : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_shelf", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_shelf", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_shelf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_shmrgrd : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Spiked Hammer Button", "Switch to Set", true, "This switch will be set when the button is pressed.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_shmrgrd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_smplbg : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_smplbg", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_smplbg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_stair : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Falling Stair", "Disable Spawn Switch", true, "Once this switch is set, the stair will no longer appear.", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public obj_stair(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swflat : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Press_Once = 0,
			Hold_Down = 1,
			Hold_Down_and_Can_Be_Disabled = 2,
		}


		[WProperty("TotG Button", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("TotG Button", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("TotG Button", "Disabled Switch", true, "For 'Hold Down and Can Be Disabled' type buttons, they will stop automatically unpressing themselves once this switch is set by something else (even if they haven't been pressed once manually). No effect on other types.", SourceScene.Room)]
		public int DisabledSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("DisabledSwitch");
			}
		}

		// Constructor
		public obj_swflat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			DisabledSwitch = -1;
			if (Name == "Hfbot1A") {
				Type = TypeEnum.Press_Once;
			}
			if (Name == "Hfbot1B") {
				Type = TypeEnum.Hold_Down;
			}
			if (Name == "Hfbot1C") {
				Type = TypeEnum.Hold_Down_and_Can_Be_Disabled;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swhammer : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Hammer Button", "Switch to Unset", true, "This switch will be unset when the button is pressed.", SourceScene.Room)]
		public int SwitchtoUnset
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoUnset");
			}
		}

		[WProperty("Hammer Button", "Switch to Set", true, "This switch will be set when the button is pressed.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_swhammer(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoUnset = -1;
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swheavy : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
		}


		[WProperty("obj_swheavy", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07000000) >> 24);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x07000000 | (value_as_int << 24 & 0x07000000));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("obj_swheavy", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_swheavy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			if (Name == "Hhbot1") {
				Type = TypeEnum.Unknown_2;
			}
			if (Name == "Hhbot1N") {
				Type = TypeEnum.Unknown_3;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swlight : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Sun Statue Eye", "Switch to Set", true, "The switch to set when this eye has light shone on it.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("Sun Statue Eye", "Other Switch", true, "The switch that is set when the other eye this one is paired up with has light shone on it.", SourceScene.Room)]
		public int OtherSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("OtherSwitch");
			}
		}

		[WProperty("Sun Statue Eye", "Is Paired", true, "", SourceScene.Room)]
		public bool IsPaired
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("IsPaired");
			}
		}

		// Constructor
		public obj_swlight(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			OtherSwitch = -1;
			if (Name == "MsuSW") {
				IsPaired = false;
			}
			if (Name == "MsuSWB") {
				IsPaired = true;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swpush : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Press_Once = 0,
			Hold_Down = 1,
			Press_Once_Inverted = 2,
			Iron_Boots_Button_Base = 3,
		}


		[WProperty("Button", "Type", true, "'Press Once' buttons stay down once you've pressed them. They only unpress themselves if something else unsets their switch.\n'Hold Down' buttons must be held down by something or they will unpress themselves automatically.\n'Press Once Inverted' buttons start off pressed down, and only unpress themselves when something else sets their switch. When one is pressed, it unsets its switch instead of setting it.\n'Iron Boots Button Base' is unused and doesn't appear to work.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07000000) >> 24);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x07000000 | (value_as_int << 24 & 0x07000000));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Button", "Event to Start", true, "", SourceScene.Stage)]
		public MapEvent EventtoStart
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("EventtoStart");
			}
		}

		[WProperty("Button", "Switch to Set", true, "The switch for this button being pressed.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("Button", "Alt Model (No Effect)", true, "This param seems like it was intended to change the visual model of the button.\nHowever, all 4 types of button have the same model specified for their normal and alternative models, so this has no effect.", SourceScene.Room)]
		public bool AltModelNoEffect
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("AltModelNoEffect");
			}
		}

		[WProperty("Button", "Should Use Disabled Switch", true, "For 'Hold Down' type buttons, this must be checked for 'Disabled Switch' to work. No effect on other types.", SourceScene.Room)]
		public bool ShouldUseDisabledSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x40000000) >> 30);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x40000000 | (value_as_int << 30 & 0x40000000));
				OnPropertyChanged("ShouldUseDisabledSwitch");
			}
		}

		[WProperty("Button", "Disabled Switch", true, "For 'Hold Down' type buttons, they will stop automatically unpressing themselves once this switch is set by something else (though they still need to be pressed once manually). No effect on other types.", SourceScene.Room)]
		public int DisabledSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisabledSwitch");
			}
		}

		// Constructor
		public obj_swpush(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			EventtoStart = null;
			SwitchtoSet = -1;
			DisabledSwitch = -1;
			if (Name == "Kbota_A") {
				Type = TypeEnum.Press_Once;
			}
			if (Name == "Kbota_B") {
				Type = TypeEnum.Hold_Down;
			}
			if (Name == "KbotaC") {
				Type = TypeEnum.Press_Once_Inverted;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_table : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_table", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_table(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tapestry : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_tapestry", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tapestry", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tapestry(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tenmado : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Skylight", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		[WProperty("Skylight", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_tenmado(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tide : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_tide", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00070000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00070000 | (value_as_int << 16 & 0x00070000));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tide", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tide(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_timer : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Countdown Timer", "Time Limit (Half Seconds)", true, "This number multiplied by 15 frames is how long to wait before unsetting the switch.", SourceScene.Room)]
		public int TimeLimitHalfSeconds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("TimeLimitHalfSeconds");
			}
		}

		[WProperty("Countdown Timer", "Switch to Unset", true, "When something else sets this switch, this timer object starts a countdown. When the countdown reaches zero, it unsets this switch.", SourceScene.Room)]
		public int SwitchtoUnset
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchtoUnset");
			}
		}

		// Constructor
		public obj_timer(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			TimeLimitHalfSeconds = -1;
			SwitchtoUnset = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tntrap : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_tntrap", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("obj_tntrap", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("obj_tntrap", "Unknown_3", true, "", SourceScene.Room)]
		public bool Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_tntrap", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00060000) >> 17);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00060000 | (value_as_int << 17 & 0x00060000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_tntrap(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			EnableSpawnSwitch = -1;
			SwitchtoSet = -1;
			Unknown_4 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_toripost : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_toripost(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tousekiki : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_tousekiki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tower : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_tower(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_trap : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_trap", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_trap", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_trap(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tribox : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_tribox", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tribox", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tribox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_try : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_5 = 5,
			Unknown_6 = 6,
			Unknown_7 = 7,
			Unknown_8 = 8,
			Unknown_9 = 9,
			Unknown_10 = 10,
			Unknown_11 = 11,
			Unknown_12 = 12,
		}


		[WProperty("TotG Pillar Statue", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("TotG Pillar Statue", "Switch to Check", true, "Once something else sets this switch, this pillar will be considered set in place.", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoCheck");
			}
		}
		public enum PlacedorUnplacedEnum
		{
			Unplaced = 0,
			Placed = 1,
		}


		[WProperty("TotG Pillar Statue", "Placed or Unplaced", true, "", SourceScene.Room)]
		public PlacedorUnplacedEnum PlacedorUnplaced
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				if (!Enum.IsDefined(typeof(PlacedorUnplacedEnum), value_as_int))
					value_as_int = 0;
				return (PlacedorUnplacedEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("PlacedorUnplaced");
			}
		}

		// Constructor
		public obj_try(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			if (Name == "Hseki1") {
				Type = TypeEnum.Unknown_0;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki6") {
				Type = TypeEnum.Unknown_1;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki3") {
				Type = TypeEnum.Unknown_2;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki4") {
				Type = TypeEnum.Unknown_3;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki5") {
				Type = TypeEnum.Unknown_4;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hmon1") {
				Type = TypeEnum.Unknown_5;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hmon1d") {
				Type = TypeEnum.Unknown_5;
				PlacedorUnplaced = PlacedorUnplacedEnum.Placed;
			}
			if (Name == "Hmon2") {
				Type = TypeEnum.Unknown_6;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hmon2d") {
				Type = TypeEnum.Unknown_6;
				PlacedorUnplaced = PlacedorUnplacedEnum.Placed;
			}
			if (Name == "Hseki31") {
				Type = TypeEnum.Unknown_7;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki41") {
				Type = TypeEnum.Unknown_8;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki51") {
				Type = TypeEnum.Unknown_9;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki32") {
				Type = TypeEnum.Unknown_10;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki42") {
				Type = TypeEnum.Unknown_11;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
			if (Name == "Hseki52") {
				Type = TypeEnum.Unknown_12;
				PlacedorUnplaced = PlacedorUnplacedEnum.Unplaced;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_usovmc : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_usovmc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Vds : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_Vds", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		// Constructor
		public obj_Vds(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vfan : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Ganon's Tower Destructible Door", "Destroyed Switch", true, "", SourceScene.Room)]
		public int DestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DestroyedSwitch");
			}
		}

		// Constructor
		public obj_vfan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DestroyedSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vgnfd : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_vgnfd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmc : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Makar Seed-Planting Spot", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_vmc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmsdz : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_vmsdz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmsms : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_vmsms(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_volcano : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_volcano", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_volcano(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Vteng : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_Vteng(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vtil : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_vtil", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vtil(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vyasi : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_vyasi", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vyasi(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_warpt : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Locked_noncyclic_pot = 0,
			Unlocked_noncyclic_pot = 1,
			First_in_cycle = 2,
			Second_in_cycle = 3,
			Third_in_cycle = 4,
		}


		[WProperty("Warp Pot", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
			}
		}
		public enum UnlockedRegisterEnum
		{
			DRC_0xA207 = 0,
			FW_0xA107 = 1,
			Unused_0xA007 = 2,
			WT_0x9F07 = 3,
			ET_0xA307 = 4,
			Unused_0xA407 = 5,
		}


		[WProperty("Cyclic Warp Pot", "Unlocked Register", true, "", SourceScene.Room)]
		public UnlockedRegisterEnum UnlockedRegister
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				if (!Enum.IsDefined(typeof(UnlockedRegisterEnum), value_as_int))
					value_as_int = 0;
				return (UnlockedRegisterEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("UnlockedRegister");
			}
		}

		[WProperty("Cyclic Warp Pot", "Exit to First Pot in Cycle", true, "", SourceScene.Room)]
		public ExitData ExittoFirstPotinCycle
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ExittoFirstPotinCycle");
			}
		}

		[WProperty("Cyclic Warp Pot", "Exit to Second Pot in Cycle", true, "", SourceScene.Room)]
		public ExitData ExittoSecondPotinCycle
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("ExittoSecondPotinCycle");
			}
		}

		[WProperty("Cyclic Warp Pot", "Exit to Third Pot in Cycle", true, "", SourceScene.Room)]
		public ExitData ExittoThirdPotinCycle
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("ExittoThirdPotinCycle");
			}
		}

		[WProperty("Cyclic Warp Pot", "Top Unblocked Switch", true, "Only has an effect if this warp pot is locked.\nFor a normal warp pot blocked with a lid, set this to 255.\nFor a warp pot that has its top blocked by some other object like a boulder, set this to what the switch set by that other object when it's destroyed is.", SourceScene.Room)]
		public int TopUnblockedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("TopUnblockedSwitch");
			}
		}

		[WProperty("Cyclic Warp Pot", "Play Unlocked Sound Effect", true, "", SourceScene.Room)]
		public bool PlayUnlockedSoundEffect
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				if (value_as_int == 255) {
					return true;
				} else {
					return false;
				}
			}

			set
			{
				int value_as_int = value ? 255 : 0;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("PlayUnlockedSoundEffect");
			}
		}

		[WProperty("Cyclic Warp Pot", "Is Locked", true, "", SourceScene.Room)]
		public bool IsLocked
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFF00) >> 8);
				if (value_as_int == 255) {
					return true;
				} else {
					return false;
				}
			}

			set
			{
				int value_as_int = value ? 255 : 0;
				m_ZRotation = (short)(m_ZRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("IsLocked");
			}
		}

		[WProperty("Noncyclic Warp Pot", "Unused Exit to This Pot", true, "", SourceScene.Room)]
		public ExitData UnusedExittoThisPot
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000FF0) >> 4);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00000FF0 | (value_as_int << 4 & 0x00000FF0));
				OnPropertyChanged("UnusedExittoThisPot");
			}
		}

		[WProperty("Noncyclic Warp Pot", "Exit to Destination Pot", true, "", SourceScene.Room)]
		public ExitData ExittoDestinationPot
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("ExittoDestinationPot");
			}
		}

		[WProperty("Noncyclic Warp Pot", "This Unlocked Switch", true, "The warp pot will set this switch when it is unlocked.\nIf this is an 'Unlocked'-type warp pot, it sets this automatically when you enter the room.", SourceScene.Room)]
		public int ThisUnlockedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("ThisUnlockedSwitch");
			}
		}

		[WProperty("Noncyclic Warp Pot", "Destination Unlocked Switch", true, "The warp pot will not let the player go through it until this switch is set.", SourceScene.Room)]
		public int DestinationUnlockedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("DestinationUnlockedSwitch");
			}
		}

		// Constructor
		public obj_warpt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
			TypeSpecificCategories["Type"] = new Dictionary<object, string[]>();
			TypeSpecificCategories["Type"][TypeEnum.Locked_noncyclic_pot] = new string[] { "Noncyclic Warp Pot" };
			TypeSpecificCategories["Type"][TypeEnum.Unlocked_noncyclic_pot] = new string[] { "Noncyclic Warp Pot" };
			TypeSpecificCategories["Type"][TypeEnum.First_in_cycle] = new string[] { "Cyclic Warp Pot" };
			TypeSpecificCategories["Type"][TypeEnum.Second_in_cycle] = new string[] { "Cyclic Warp Pot" };
			TypeSpecificCategories["Type"][TypeEnum.Third_in_cycle] = new string[] { "Cyclic Warp Pot" };
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			ExittoFirstPotinCycle = null;
			ExittoSecondPotinCycle = null;
			ExittoThirdPotinCycle = null;
			TopUnblockedSwitch = -1;
			UnusedExittoThisPot = null;
			ExittoDestinationPot = null;
			ThisUnlockedSwitch = -1;
			DestinationUnlockedSwitch = -1;
			if (Name == "Warpt") {
				Type = TypeEnum.Locked_noncyclic_pot;
			}
			if (Name == "Warpnt") {
				Type = TypeEnum.Unlocked_noncyclic_pot;
			}
			if (Name == "Warpts1") {
				Type = TypeEnum.First_in_cycle;
			}
			if (Name == "Warpts2") {
				Type = TypeEnum.Second_in_cycle;
			}
			if (Name == "Warpts3") {
				Type = TypeEnum.Third_in_cycle;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_wood : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_wood(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_xfuta : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public obj_xfuta(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Yboil : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Boiling Water Bubbles", "Disabled Switch", true, "", SourceScene.Room)]
		public int DisabledSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("DisabledSwitch");
			}
		}

		// Constructor
		public obj_Yboil(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisabledSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Ygush00 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_Ygush00", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_Ygush00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_YLzou : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_YLzou", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_YLzou(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_zouK : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("obj_zouK", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_zouK(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class oq : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Freshwater_Octorok = 0,
			Saltwater_Octorok_that_shoots_at_a_certain_range = 1,
			Saltwater_Octorok_that_spawns_close_to_player_and_shoots_after_a_certain_delay = 2,
			Saltwater_Octorok_spawner = 3,
			Saltwater_Octorok_that_shoots_after_a_certain_delay = 4,
			Spawned_saltwater_Octorok = 5,
			Rock_shot_by_a_freshwater_Octorok = 6,
		}


		[WProperty("Octorok", "Type", true, "The 'Spawned saltwater Octorok' type does not appear when manually placed, it's just for the spawner to create.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}
		public enum ProjectileTypeEnum
		{
			Rocks = 0,
			Bombs = 1,
		}


		[WProperty("Freshwater Octorok", "Projectile Type", true, "This only affects what freshwater Octoroks shoot, not saltwater ones.", SourceScene.Room)]
		public ProjectileTypeEnum ProjectileType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(ProjectileTypeEnum), value_as_int))
					value_as_int = 0;
				return (ProjectileTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ProjectileType");
			}
		}

		[WProperty("Saltwater Octorok Spawner", "Sight Range (Thousands)", true, "For the 'Saltwater Octorok spawner' type, this number multiplied by 1000 is the range within it will notice the player and start spawning saltwater Octoroks.\nNo effect on other types besides the spawner.", SourceScene.Room)]
		public int SightRangeThousands
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SightRangeThousands");
			}
		}

		// Constructor
		public oq(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
			TypeSpecificCategories["Type"] = new Dictionary<object, string[]>();
			TypeSpecificCategories["Type"][TypeEnum.Freshwater_Octorok] = new string[] { "Freshwater Octorok" };
			TypeSpecificCategories["Type"][TypeEnum.Saltwater_Octorok_spawner] = new string[] { "Saltwater Octorok Spawner" };
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeThousands = -1;
			if (Name == "Oq") {
				Type = TypeEnum.Freshwater_Octorok;
			}
			if (Name == "Oqw") {
				Type = TypeEnum.Saltwater_Octorok_that_shoots_at_a_certain_range;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class oship : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
		}


		[WProperty("oship", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("oship", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("oship", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000F000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000F000 | (value_as_int << 12 & 0x0000F000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("oship", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("oship", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		[WProperty("oship", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("oship", "Is Golden", true, "", SourceScene.Room)]
		public bool IsGolden
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFF00) >> 8);
				if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 0 : 255;
				m_XRotation = (short)(m_XRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("IsGolden");
				UpdateModel();
			}
		}

		// Constructor
		public oship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_2 = -1;
			Unknown_3 = -1;
			Path = null;
			DisableSpawnonDeathSwitch = -1;
			EnableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pedestal : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("pedestal", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public pedestal(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ph : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Peahat = 0,
			Seahat = 1,
		}


		[WProperty("ph", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("ph", "Horizontal Sight Range (Hundreds)", true, "This number multiplied by 100 is the radius of the cylinder it can see Link within. 255 will default to a range of 1000 for Peahats or 12000 for Seahats.", SourceScene.Room)]
		public int HorizontalSightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("HorizontalSightRangeHundreds");
			}
		}

		[WProperty("ph", "Vertical Sight Range (Hundreds)", true, "This number multiplied by 100 is half the height of the cylinder it can see Link within. 255 will default to a range of 500 for Peahats or 6000 for Seahats.", SourceScene.Room)]
		public int VerticalSightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("VerticalSightRangeHundreds");
			}
		}

		// Constructor
		public ph(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			HorizontalSightRangeHundreds = -1;
			VerticalSightRangeHundreds = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pirate_flag : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public pirate_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pt : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Respawning = 0,
			Nonrespawning = 1,
		}


		[WProperty("Miniblin", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 1;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Miniblin", "Initial Miniblin Won't Spawn Onscreen?", true, "If this is checked, the first Miniblin won't spawn until the player's camera is turned away from its spawn point.\n(Miniblins after the first one always act like that regardless of whether this is checked or not.)", SourceScene.Room)]
		public bool InitialMiniblinWontSpawnOnscreen
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000010) >> 4);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000010 | (value_as_int << 4 & 0x00000010));
				OnPropertyChanged("InitialMiniblinWontSpawnOnscreen");
			}
		}
		public enum RespawnDelayEnum
		{
			_20_frames = 0,
			_40_frames = 1,
			_60_frames = 2,
			_80_frames = 3,
			_100_frames = 4,
			_120_frames = 5,
			_140_frames = 6,
			Use_initial_spawn_delay = 7,
		}


		[WProperty("Miniblin", "Respawn Delay", true, "Number of frames after you kill it before it can respawn.", SourceScene.Room)]
		public RespawnDelayEnum RespawnDelay
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000E0) >> 5);
				if (!Enum.IsDefined(typeof(RespawnDelayEnum), value_as_int))
					value_as_int = 0;
				return (RespawnDelayEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000E0 | (value_as_int << 5 & 0x000000E0));
				OnPropertyChanged("RespawnDelay");
			}
		}

		[WProperty("Miniblin", "Sight Range (Hundreds)", true, "", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("Miniblin", "Disable Respawn Switch", true, "If this is a valid switch and used with a respawning type Miniblin, this being set stops it from respawning.\nAlternatively, you can also use this with a non-respawning Miniblin, in which case it acts like a 'Deactivate on Death Switch' that it sets on death - but you should only set a temporary switch this way, as if you set a permanent switch the Miniblin will be permanently inactive the next time you enter the room but won't be considered dead.", SourceScene.Room)]
		public int DisableRespawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("DisableRespawnSwitch");
			}
		}

		[WProperty("Miniblin", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("Miniblin", "Initial Spawn Delay", true, "Number of frames after you enter the room before it can spawn the first Miniblin. If setting this to something other than 0, it is recommended to also check 'Initial Miniblin Won't Spawn Onscreen?'. If you don't, then the first Miniblin will be visible before it actually spawns, but simply be deactivated and invincible.", SourceScene.Room)]
		public int InitialSpawnDelay
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("InitialSpawnDelay");
			}
		}

		// Constructor
		public pt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeHundreds = -1;
			DisableRespawnSwitch = -1;
			EnableSpawnSwitch = -1;
			InitialSpawnDelay = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pw : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Wandering = 0,
			Invisible_until_seeing_Link = 1,
			Invisible_except_Lantern_until_seeing_Link = 2,
			Jalhalla_Poe_A = 3,
			Jalhalla_Poe_B = 4,
		}


		[WProperty("Poe", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Poe", "Hovers At Initial Height?", true, "If checked, this Poe will maintain its height in the air like normal. If unchecked, it will slowly float down to the floor.", SourceScene.Room)]
		public bool HoversAtInitialHeight
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("HoversAtInitialHeight");
			}
		}
		public enum ColorEnum
		{
			Blue = 0,
			Purple = 1,
			Orange = 2,
			Yellow = 3,
			Red = 4,
			Green = 5,
		}


		[WProperty("Poe", "Color", true, "", SourceScene.Room)]
		public ColorEnum Color
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FE00) >> 9);
				if (!Enum.IsDefined(typeof(ColorEnum), value_as_int))
					value_as_int = 0;
				return (ColorEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FE00 | (value_as_int << 9 & 0x0000FE00));
				OnPropertyChanged("Color");
				UpdateModel();
			}
		}

		[WProperty("Poe", "Sight Range (Tens)", true, "For the 'Invisible except Lantern until seeing Link' type, this number multiplied by 10 is the range it can see Link within and will materialize. No effect on other types.", SourceScene.Room)]
		public int SightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SightRangeTens");
			}
		}

		[WProperty("Poe", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public pw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeTens = -1;
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pz : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("pz", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public pz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class race_item : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("race_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("race_item", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00007F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00007F00 | (value_as_int << 8 & 0x00007F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("race_item", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00078000) >> 15);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00078000 | (value_as_int << 15 & 0x00078000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public race_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class rd : Actor
	{
		// Auto-Generated Properties from Templates
		public enum IdleAnimationEnum
		{
			Standing = 0,
			Sitting = 1,
		}


		[WProperty("ReDead", "Idle Animation", true, "", SourceScene.Room)]
		public IdleAnimationEnum IdleAnimation
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				if (!Enum.IsDefined(typeof(IdleAnimationEnum), value_as_int))
					value_as_int = 0;
				return (IdleAnimationEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("IdleAnimation");
				UpdateModel();
			}
		}

		[WProperty("ReDead", "Guarded Area Radius", true, "The ReDead has a base radius of 650 and this value is added to that.\nBecause the maximum value here is 127, this doesn't change the size of the area it guards very much.", SourceScene.Room)]
		public int GuardedAreaRadius
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FE) >> 1);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FE | (value_as_int << 1 & 0x000000FE));
				OnPropertyChanged("GuardedAreaRadius");
			}
		}

		[WProperty("ReDead", "Should Check Switch To Enable Spawn?", true, "If this is checked, the Enable Spawn Switch must be set for the ReDead to spawn.\nIf the Enable Spawn Switch is invalid, then unlike most enemies, this ReDead will never appear instead of always appearing.", SourceScene.Room)]
		public bool ShouldCheckSwitchToEnableSpawn
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0) {
					return true;
				} else {
					return false;
				}
			}

			set
			{
				int value_as_int = value ? 0 : 1;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ShouldCheckSwitchToEnableSpawn");
			}
		}

		[WProperty("ReDead", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public rd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			GuardedAreaRadius = -1;
			ShouldCheckSwitchToEnableSpawn = false;
			EnableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class rectangle : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public rectangle(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sail : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public sail(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class saku : Actor
	{
		// Auto-Generated Properties from Templates
		public enum HeightEnum
		{
			Single = 0,
			Double = 1,
		}


		[WProperty("Boarded Up Wall", "Height", true, "", SourceScene.Room)]
		public HeightEnum Height
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(HeightEnum), value_as_int))
					value_as_int = 1;
				return (HeightEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Height");
				UpdateModel();
			}
		}
		public enum StrengthEnum
		{
			Weak_Boarded_Up_Wall = 0,
			Sturdy_Boarded_Up_Wall = 1,
		}


		[WProperty("Boarded Up Wall", "Strength", true, "", SourceScene.Room)]
		public StrengthEnum Strength
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				if (!Enum.IsDefined(typeof(StrengthEnum), value_as_int))
					value_as_int = 0;
				return (StrengthEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Strength");
				UpdateModel();
			}
		}

		[WProperty("Boarded Up Wall", "Bottom Destroyed Switch", true, "", SourceScene.Room)]
		public int BottomDestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("BottomDestroyedSwitch");
			}
		}

		[WProperty("Boarded Up Wall", "Top Destroyed Switch", true, "", SourceScene.Room)]
		public int TopDestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("TopDestroyedSwitch");
			}
		}

		// Constructor
		public saku(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			BottomDestroyedSwitch = -1;
			TopDestroyedSwitch = -1;
			if (Name == "Ksaku") {
				Strength = StrengthEnum.Weak_Boarded_Up_Wall;
			}
			if (Name == "Dsaku") {
				Strength = StrengthEnum.Sturdy_Boarded_Up_Wall;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class salvage : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Needs_Chart = 0,
			Unused = 1,
			Checks_Switch = 2,
			Normal_Light_Ring = 3,
			Night_Only = 4,
			Octorok_Vase = 5,
			Full_Moon_Night_Only = 6,
		}


		[WProperty("Salvage Point", "Type", true, "'Needs Chart' are the important pillar of light salvage points that won't appear until you have the relevant Treasure Chart or Triforce Chart.\n'Checks Switch' only appear once a certain switch is set, such as Big Octo salvage points.\n'Normal Light Ring' are light rings that always appear.\n'Night Only' are light rings that only appear at night.\n'Octorok Vase' are invisible salvage points that will cause the player to fish up an old vase, and then spawn a Saltwater Octorok next to them.\n'Full Moon Night Only' are light rings that only appear at night when the full moon is out.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Salvage Point", "Item ID", true, "", SourceScene.Room)]
		public ItemID ItemID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000FF0) >> 4);
				if (!Enum.IsDefined(typeof(ItemID), value_as_int))
					value_as_int = 0;
				return (ItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000FF0 | (value_as_int << 4 & 0x00000FF0));
				OnPropertyChanged("ItemID");
			}
		}

		[WProperty("Salvage Point", "Unknown Salvaged Object Type", true, "", SourceScene.Room)]
		public int UnknownSalvagedObjectType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("UnknownSalvagedObjectType");
			}
		}

		[WProperty("Chart Salvage Point", "Chart", true, "Affects which chart reveals this salvage point.\nOnly works for 'Needs Chart' type salvage points.", SourceScene.Room)]
		public int Chart
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("Chart");
			}
		}

		[WProperty("Light Ring Salvage Point", "Salvage Flag", true, "Which salvage flag in this sector to use for this salvage point. Can be from 0-15.\nOr set this to 31 if you want the salvage point to reappear every time the player exits and re-enters the sector.\nOnly works for 'Checks Switch', 'Normal Light Ring', and 'Night Only' type salvage points.", SourceScene.Room)]
		public int SalvageFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("SalvageFlag");
			}
		}
		public enum SalvagedEventBitEnum
		{
			Event_bit_0x2080 = 0,
			Event_bit_0x2004 = 1,
			Event_bit_0x2002 = 2,
			Event_bit_0x2804 = 3,
			Event_bit_0x2802 = 4,
			Event_bit_0x2801 = 5,
			Event_bit_0x2980 = 6,
			Event_bit_0x2940 = 7,
			Event_bit_0x3B01 = 8,
			Event_bit_0x3C80 = 9,
			Event_bit_0x3C40 = 10,
			Event_bit_0x3C20 = 11,
			Event_bit_0x3C10 = 12,
			Event_bit_0x3C08 = 13,
			Event_bit_0x3C04 = 14,
			Event_bit_0x3C02 = 15,
		}


		[WProperty("Full Moon Salvage Point", "Salvaged Event Bit", true, "This event bit will be set when the player salvages it, and the salvage point will not appear as long as it's set.\nAll sixteen of these are cleared once per ingame week, on Friday.\nOnly works for 'Full Moon Night Only' type salvage points.", SourceScene.Room)]
		public SalvagedEventBitEnum SalvagedEventBit
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				if (!Enum.IsDefined(typeof(SalvagedEventBitEnum), value_as_int))
					value_as_int = 0;
				return (SalvagedEventBitEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("SalvagedEventBit");
			}
		}

		[WProperty("Chart Salvage Point", "Duplicate Placement ID", true, "When placing a salvage point that needs a chart to see, you should actually place 4 in the same sector in different placements, with the only difference being that this ID should be 0, 1, 2, or 3, one for each.\nWhen the player starts a new save file, the game will randomly pick one of these different placements from 0-2, and only that placement of chart salvages will appear on that save file.\nIn Second Quest, only the ones with placement ID 3 will appear.\nOnly works for 'Needs Chart' type salvage points.", SourceScene.Room)]
		public int DuplicatePlacementID
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x0003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x0003 | (value_as_int << 0 & 0x0003));
				OnPropertyChanged("DuplicatePlacementID");
			}
		}

		[WProperty("Switch Salvage Point", "Switch to Check", true, "The salvage point will not appear until this switch is set.\nOnly works for 'Checks Switch' type salvage points.", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		// Constructor
		public salvage(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
			TypeSpecificCategories["Type"] = new Dictionary<object, string[]>();
			TypeSpecificCategories["Type"][TypeEnum.Needs_Chart] = new string[] { "Chart Salvage Point" };
			TypeSpecificCategories["Type"][TypeEnum.Checks_Switch] = new string[] { "Switch Salvage Point", "Light Ring Salvage Point" };
			TypeSpecificCategories["Type"][TypeEnum.Normal_Light_Ring] = new string[] { "Light Ring Salvage Point" };
			TypeSpecificCategories["Type"][TypeEnum.Night_Only] = new string[] { "Light Ring Salvage Point" };
			TypeSpecificCategories["Type"][TypeEnum.Full_Moon_Night_Only] = new string[] { "Full Moon Salvage Point" };
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			ItemID = ItemID.No_item;
			UnknownSalvagedObjectType = -1;
			Chart = -1;
			SalvageFlag = -1;
			DuplicatePlacementID = -1;
			SwitchtoCheck = -1;
			if (Name == "Salvage") {
				Type = TypeEnum.Needs_Chart;
			}
			if (Name == "SwSlvg") {
				Type = TypeEnum.Checks_Switch;
			}
			if (Name == "Salvag2") {
				Type = TypeEnum.Normal_Light_Ring;
			}
			if (Name == "SalvagN") {
				Type = TypeEnum.Night_Only;
			}
			if (Name == "SalvagE") {
				Type = TypeEnum.Octorok_Vase;
			}
			if (Name == "SalvFM") {
				Type = TypeEnum.Full_Moon_Night_Only;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class salvage_tbox : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("salvage_tbox", "Item ID", true, "", SourceScene.Room)]
		public ItemID ItemID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(ItemID), value_as_int))
					value_as_int = 0;
				return (ItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ItemID");
			}
		}

		[WProperty("salvage_tbox", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public salvage_tbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			ItemID = ItemID.No_item;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sbox : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public sbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class scene_change : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public scene_change(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sea : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public sea(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class seatag : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public seatag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class Sfairy : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("sfairy", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public Sfairy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shand : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("shand", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public shand(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ship : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("ship", "Boundary Path", true, "This path in the Stage.arc sets the boundaries within which you are allowed to sail.\nThere should be four paths in total, connected via the \"Next Path\" field of the paths.\nThe ship will start out limited to the first path, then once hardcoded story conditions are met it will go onto the second, then third, and then the fourth path is the final one.", SourceScene.Room)]
		public Path_v2 BoundaryPath
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<Path_v2> list = stage.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<Path_v2> list = stage.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BoundaryPath");
			}
		}

		[WProperty("ship", "Unknown_2", true, "", SourceScene.Room)]
		public bool Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 1) {
					return true;
				} else {
					return false;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			BoundaryPath = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shop_item : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("shop_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("shop_item", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public shop_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shutter : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Shutter", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}
		public enum ModelEnum
		{
			Large_Shutter = 0,
			Small_Shutter = 1,
		}


		[WProperty("Shutter", "Model", true, "", SourceScene.Room)]
		public ModelEnum Model
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				if (!Enum.IsDefined(typeof(ModelEnum), value_as_int))
					value_as_int = 0;
				return (ModelEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Model");
				UpdateModel();
			}
		}

		// Constructor
		public shutter(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
			if (Name == "Htobi1") {
				Model = ModelEnum.Large_Shutter;
			}
			if (Name == "Htobi2") {
				Model = ModelEnum.Small_Shutter;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shutter2 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Grating Door", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		// Constructor
		public shutter2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sie_flag : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public sie_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sitem : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("sitem", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
				UpdateModel();
			}
		}

		[WProperty("sitem", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("sitem", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("sitem", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public sitem(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sk : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("sk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sk", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public sk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sk2 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("sk2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sk2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("sk2", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public sk2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class spc_item : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("spc_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public spc_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class spotbox : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("spotbox", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public spotbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ss : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Blocks_Chest = 0,
			Blocks_Door = 1,
		}


		[WProperty("Eye-Vine Door/Chest Blocker", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Eye-Vine Door/Chest Blocker", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("Eye-Vine Door/Chest Blocker", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public ss(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_2 = -1;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ssk : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
		}


		[WProperty("Spiked Tentacle Blockade", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Spiked Tentacle Blockade", "Sight Range (Tens)", true, "", SourceScene.Room)]
		public int SightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeTens");
			}
		}

		[WProperty("Spiked Tentacle Blockade", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public ssk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeTens = -1;
			DisableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sss : Actor
	{
		// Auto-Generated Properties from Templates
		public enum SFXTypeEnum
		{
			SFX_58F7 = 0,
			SFX_58F8 = 1,
		}


		[WProperty("Dexivine", "SFX Type", true, "The SFX to play when it comes out of the ground. There's no noticeable difference between the two, so this is a useless parameter.", SourceScene.Room)]
		public SFXTypeEnum SFXType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(SFXTypeEnum), value_as_int))
					value_as_int = 0;
				return (SFXTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SFXType");
			}
		}

		[WProperty("Dexivine", "Sight Range (Tens)", true, "This number multiplied by 10 is used as a range within it notices Link and comes out of the ground. 255 will default to a range of 1000.", SourceScene.Room)]
		public int SightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeTens");
			}
		}

		[WProperty("Dexivine", "Enable Spawn Switch", true, "If this is not 0 or 255, the Dexivine will hide underground until this switch is set.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public sss(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SightRangeTens = -1;
			EnableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class st : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Normal = 0,
			Underground = 1,
			Lying_in_coffin = 2,
			Standing_in_coffin = 3,
			Upper_body = 14,
		}


		[WProperty("Stalfos", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Stalfos", "Ambush Sight Range (Tens)", true, "If the Stalfos is underground or in a coffin, this is the range within it will notice the player.", SourceScene.Room)]
		public int AmbushSightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("AmbushSightRangeTens");
			}
		}
		public int Unused
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unused");
			}
		}

		[WProperty("Stalfos", "Ambush Switch", true, "If this is a valid switch and the Stalfos is underground or in a coffin, it will only come out when this switch is set, overriding the normal behave of coming out when the player comes near it.", SourceScene.Room)]
		public int AmbushSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("AmbushSwitch");
			}
		}

		[WProperty("Stalfos", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public st(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			AmbushSightRangeTens = -1;
			Unused = -1;
			AmbushSwitch = -1;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class steam_tag : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("steam_tag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000003FC) >> 2);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000003FC | (value_as_int << 2 & 0x000003FC));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public steam_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class stone : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Small_Rock = 0,
			Small_Black_Rock = 1,
			Boulder = 2,
			Head_Boulder = 3,
			Small_Boulder = 4,
		}


		[WProperty("stone", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07000000) >> 24);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x07000000 | (value_as_int << 24 & 0x07000000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("stone", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("stone", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("stone", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("stone", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("stone", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x70000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x70000000 | (value_as_int << 28 & 0x70000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public stone(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_6 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class stone2 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Boulder = 2,
			Head_Boulder = 3,
			Small_Boulder = 4,
		}


		[WProperty("Boulder", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07000000) >> 24);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x07000000 | (value_as_int << 24 & 0x07000000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Boulder", "Dropped Item", true, "", SourceScene.Room)]
		public DroppedItemID DroppedItem
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				if (!Enum.IsDefined(typeof(DroppedItemID), value_as_int))
					value_as_int = 0;
				return (DroppedItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("DroppedItem");
			}
		}

		[WProperty("Boulder", "Destroyed Switch", true, "", SourceScene.Room)]
		public int DestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("DestroyedSwitch");
			}
		}

		[WProperty("Boulder", "Dropped Item Pickup Flag", true, "", SourceScene.Room)]
		public int DroppedItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("DroppedItemPickupFlag");
			}
		}

		[WProperty("Boulder", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x70000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x70000000 | (value_as_int << 28 & 0x70000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("Boulder", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("Boulder", "Destroyed Event", true, "", SourceScene.Stage)]
		public MapEvent DestroyedEvent
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DestroyedEvent");
			}
		}

		// Constructor
		public stone2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "YXZ";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DroppedItem = DroppedItemID.No_item;
			DestroyedSwitch = -1;
			DroppedItemPickupFlag = -1;
			Unknown_5 = -1;
			Unknown_6 = -1;
			DestroyedEvent = null;
			if (Name == "Ebrock") {
				Type = TypeEnum.Boulder;
			}
			if (Name == "Ekao") {
				Type = TypeEnum.Head_Boulder;
			}
			if (Name == "Ebrock2") {
				Type = TypeEnum.Small_Boulder;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swattack : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("swattack", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swattack", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swattack(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swc00 : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Set_and_Unset = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Only_Set = 3,
		}


		[WProperty("Switch Setter Trigger Region", "Type", true, "'Set and Unset' will set its 'Switch to Set' when the player enters the region, and unset it when the player leaves the region.\n'Only Set' will set it, but never unset it.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00030000) >> 16);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00030000 | (value_as_int << 16 & 0x00030000));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Switch Setter Trigger Region", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("Switch Setter Trigger Region", "Prerequisite Switch", true, "If this is not set to 255, then this switch must be set before this trigger region becomes active.", SourceScene.Room)]
		public int PrerequisiteSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("PrerequisiteSwitch");
			}
		}

		// Constructor
		public swc00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			PrerequisiteSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swhit0 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
		}


		[WProperty("Hittable Crystal", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 4;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Hittable Crystal", "Switch to Set", true, "Switch to set when hit.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("Hittable Crystal", "Event", true, "The event to start when hit? (Only for type 'Unknown 3'.)", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Event");
			}
		}

		[WProperty("Hittable Crystal", "Time Limit (Half Seconds)", true, "This number times 15 frames is how long the player has to hit all the crystals after the first crystal is hit.", SourceScene.Room)]
		public int TimeLimitHalfSeconds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("TimeLimitHalfSeconds");
			}
		}

		[WProperty("Hittable Crystal", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("Hittable Crystal", "Switch to Check", true, "Once this switch is set, the crystal will consider the puzzle finished and no longer be on a timer.", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		// Constructor
		public swhit0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			Event = null;
			TimeLimitHalfSeconds = -1;
			Unknown_5 = -1;
			SwitchtoCheck = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class switem : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum WhatTriggersItEnum
		{
			Sword_or_Enemy_Weapon = 0,
			Bombs = 1,
			Boomerang = 2,
			Skull_Hammer = 3,
			Any_Arrows = 4,
			Hookshot = 5,
			Never_Triggers = 6,
			Anything = 255,
		}


		[WProperty("Hidden Item Pickup", "What Triggers It", true, "", SourceScene.Room)]
		public WhatTriggersItEnum WhatTriggersIt
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(WhatTriggersItEnum), value_as_int))
					value_as_int = 0;
				return (WhatTriggersItEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("WhatTriggersIt");
			}
		}

		[WProperty("Hidden Item Pickup", "Spawned Item", true, "", SourceScene.Room)]
		public DroppedItemID SpawnedItem
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00003F00) >> 8);
				if (!Enum.IsDefined(typeof(DroppedItemID), value_as_int))
					value_as_int = 0;
				return (DroppedItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00003F00 | (value_as_int << 8 & 0x00003F00));
				OnPropertyChanged("SpawnedItem");
				UpdateModel();
			}
		}

		[WProperty("Hidden Item Pickup", "Item Pickup Flag", true, "", SourceScene.Room)]
		public int ItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x001FC000) >> 14);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x001FC000 | (value_as_int << 14 & 0x001FC000));
				OnPropertyChanged("ItemPickupFlag");
			}
		}

		// Constructor
		public switem(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SpawnedItem = DroppedItemID.No_item;
			ItemPickupFlag = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swpropeller : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("swpropeller", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swpropeller", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swpropeller(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swtact : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("Wind Waker Switch", "Switch to Set", true, "The switch to set when the proper Wind Waker song has been played.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}
		public enum WindWakerSongTriggerEnum
		{
			Winds_Requiem = 0,
			Ballad_of_Gales = 1,
			Song_of_Passing = 2,
			Command_Melody = 3,
			Earth_Gods_Lyric = 4,
			Wind_Gods_Aria = 5,
		}


		[WProperty("Wind Waker Switch", "Wind Waker Song Trigger", true, "The song to play on the Wind Waker to trigger the switch.", SourceScene.Room)]
		public WindWakerSongTriggerEnum WindWakerSongTrigger
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(WindWakerSongTriggerEnum), value_as_int))
					value_as_int = 0;
				return (WindWakerSongTriggerEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("WindWakerSongTrigger");
			}
		}

		[WProperty("Wind Waker Switch", "Show Wind Emblem Model", true, "Determines if the wind crest is shown where the trigger is. The emblem model scales with the object.", SourceScene.Room)]
		public bool ShowWindEmblemModel
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("ShowWindEmblemModel");
				UpdateModel();
			}
		}

		// Constructor
		public swtact(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			if (Name == "SWtact") {
				ShowWindEmblemModel = false;
			}
			if (Name == "SWtactB") {
				ShowWindEmblemModel = true;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swtdoor : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("swtdoor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swtdoor", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swtdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class syan : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public syan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_attention : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
		}


		[WProperty("tag_attention", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("tag_attention", "Switch to Check", true, "", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		// Constructor
		public tag_attention(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoCheck = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ba1 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public tag_ba1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_etc : TriggerRegion
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_etc", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_etc", "Event", true, "", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Event");
			}
		}

		// Constructor
		public tag_etc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Event = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_event : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_1 = 0,
			Unknown_2 = 1,
			Unknown_3 = 2,
			Unknown_4 = 3,
			Unknown_5 = 4,
			Unknown_6 = 5,
			Unknown_7 = 6,
			Unknown_8 = 7,
			Unknown_9 = 8,
			Unknown_10 = 9,
			Unknown_11 = 10,
			Unknown_12 = 11,
			Unknown_13 = 12,
			Unknown_14 = 13,
			Normal = 255,
		}


		[WProperty("tag_event", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("tag_event", "Switch to Set", true, "Switch that this trigger region sets when it triggers the event.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("tag_event", "Enable Spawn Switch", true, "Switch that must be set before this trigger region will become active.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("tag_event", "Event", true, "The event to start when entering this region.", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Event");
			}
		}

		[WProperty("tag_event", "Enable Spawn Event Bit", true, "Event bit that must be set before this trigger region will become active.", SourceScene.Room)]
		public int EnableSpawnEventBit
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("EnableSpawnEventBit");
			}
		}

		// Constructor
		public tag_event(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			EnableSpawnSwitch = -1;
			Event = null;
			EnableSpawnEventBit = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_evsw : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Set_and_Unset = 0,
			Only_Set = 1,
		}


		[WProperty("Event Bit Switch Setter", "Type", true, "'Set and Unset' will set the switch if the event bit is set, and unset it if it's not.\n'Only Set' will set the switch if the event bit is set, but will never unset it.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03000000) >> 24);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x03000000 | (value_as_int << 24 & 0x03000000));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Event Bit Switch Setter", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("Event Bit Switch Setter", "Event Bit to Check", true, "", SourceScene.Room)]
		public int EventBittoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FFFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FFFF00 | (value_as_int << 8 & 0x00FFFF00));
				OnPropertyChanged("EventBittoCheck");
			}
		}

		// Constructor
		public tag_evsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			EventBittoCheck = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ghostship : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_ghostship", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_ghostship", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public tag_ghostship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_hint : TriggerRegion
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_hint", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_hint", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_hint", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("tag_hint", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("tag_hint", "Event", true, "", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Event");
			}
		}
		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_hint", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tag_hint(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			SwitchtoSet = -1;
			EnableSpawnSwitch = -1;
			Event = null;
			MessageID = -1;
			Unknown_7 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_island : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_5 = 5,
			Unknown_6 = 6,
			Unknown_7 = 7,
		}


		[WProperty("tag_island", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("tag_island", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("tag_island", "Event", true, "", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Event");
			}
		}

		// Constructor
		public tag_island(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			SwitchtoSet = -1;
			Event = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kb_item : TriggerRegion
	{
		// Auto-Generated Properties from Templates

		[WProperty("Pig Item Dig Region", "Item", true, "", SourceScene.Room)]
		public ItemID Item
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(ItemID), value_as_int))
					value_as_int = 0;
				return (ItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Item");
			}
		}

		[WProperty("Pig Item Dig Region", "Item Pickup Flag", true, "", SourceScene.Room)]
		public int ItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ItemPickupFlag");
			}
		}

		[WProperty("Pig Item Dig Region", "Should Set Switch", true, "", SourceScene.Room)]
		public bool ShouldSetSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 0 : 255;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("ShouldSetSwitch");
			}
		}

		[WProperty("Pig Item Dig Region", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public tag_kb_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Item = ItemID.No_item;
			ItemPickupFlag = -1;
			SwitchtoSet = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kf1 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_kf1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_kf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kk1 : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public tag_kk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_light : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Invisible_Light_Region = 0,
			Light_Beam = 1,
			Light_Detector = 2,
		}


		[WProperty("Light Region/Detector", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("tag_light", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_light", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000003FC) >> 2);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000003FC | (value_as_int << 2 & 0x000003FC));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_light", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00003C00) >> 10);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00003C00 | (value_as_int << 10 & 0x00003C00));
				OnPropertyChanged("Unknown_4");
				UpdateModel();
			}
		}

		[WProperty("tag_light", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000C000) >> 14);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000C000 | (value_as_int << 14 & 0x0000C000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("Light Region", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("Light Detector", "Switch to Set", true, "The switch to set when light is shone on this detector.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("tag_light", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tag_light(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "YXZ";
			TypeSpecificCategories["Type"] = new Dictionary<object, string[]>();
			TypeSpecificCategories["Type"][TypeEnum.Invisible_Light_Region] = new string[] { "Light Region" };
			TypeSpecificCategories["Type"][TypeEnum.Light_Beam] = new string[] {  };
			TypeSpecificCategories["Type"][TypeEnum.Light_Detector] = new string[] { "Light Detector" };
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_5 = -1;
			EnableSpawnSwitch = -1;
			SwitchtoSet = -1;
			Unknown_7 = -1;
			if (Name == "LTag0") {
				Type = TypeEnum.Invisible_Light_Region;
			}
			if (Name == "LTag1") {
				Type = TypeEnum.Light_Beam;
			}
			if (Name == "LTagR0") {
				Type = TypeEnum.Light_Detector;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_md_cb : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_md_cb", "First Switch to Check", true, "", SourceScene.Room)]
		public int FirstSwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("FirstSwitchtoCheck");
			}
		}

		[WProperty("tag_md_cb", "Num Switches to Check", true, "", SourceScene.Room)]
		public int NumSwitchestoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("NumSwitchestoCheck");
			}
		}

		[WProperty("tag_md_cb", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public tag_md_cb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			MessageID = -1;
			FirstSwitchtoCheck = -1;
			NumSwitchestoCheck = -1;
			DisableSpawnSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_mk : TriggerRegion
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_mk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_mk", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_mk", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_mk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_msg : TriggerRegion
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
		}


		[WProperty("tag_msg", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000040) >> 6);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000040 | (value_as_int << 6 & 0x00000040));
				OnPropertyChanged("Type");
			}
		}
		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_msg", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("tag_msg", "Enable Spawn Event Bit", true, "", SourceScene.Room)]
		public int EnableSpawnEventBit
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("EnableSpawnEventBit");
			}
		}

		[WProperty("tag_msg", "Switch to Set", true, "", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("tag_msg", "Event", true, "", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Event");
			}
		}

		// Constructor
		public tag_msg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			MessageID = -1;
			EnableSpawnSwitch = -1;
			EnableSpawnEventBit = -1;
			SwitchtoSet = -1;
			Event = null;
			if (Name == "TagMsg") {
				Type = TypeEnum.Unknown_0;
			}
			if (Name == "TagMsg2") {
				Type = TypeEnum.Unknown_1;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_photo : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_photo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_photo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ret : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_ret", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_ret(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_so : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_so", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_so", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_so", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_so(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_volcano : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_volcano", "Disable Spawn Treasure Chest Open Flag", true, "Will become permanently disabled once a treasure chest sets this open flag.", SourceScene.Room)]
		public int DisableSpawnTreasureChestOpenFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("DisableSpawnTreasureChestOpenFlag");
			}
		}
		public enum TypeEnum
		{
			Outside_cave = 0,
			Inside_Fire_Mountain = 1,
			Inside_Ice_Ring = 2,
		}


		[WProperty("tag_volcano", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 2;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("tag_volcano", "Switch to Set", true, "This switch will be set when the timer starts and unset when the timer ends.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("tag_volcano", "Timer Duration (Tens of Seconds)", true, "This number times 10 seconds is how long the timer will last.", SourceScene.Room)]
		public int TimerDurationTensofSeconds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("TimerDurationTensofSeconds");
			}
		}

		// Constructor
		public tag_volcano(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisableSpawnTreasureChestOpenFlag = -1;
			SwitchtoSet = -1;
			TimerDurationTensofSeconds = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_waterlevel : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tag_waterlevel", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_waterlevel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tama : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tama", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tama(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tbox : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Normal = 0,
			Spawn_when_a_switch_is_set = 1,
			Spawn_when_all_enemies_dead = 2,
			Visible_but_unopenable_until_a_switch_is_set = 3,
			Transparent_until_a_switch_is_set = 4,
			Apply_gravity = 5,
			Spawn_on_Triforce_emblem_when_a_switch_is_set = 6,
			Uses_Stage_Save_Info_1_open_flag = 7,
			Uses_Stage_Save_Info_1_open_flag_and_spawns_when_a_switch_is_set = 8,
		}


		[WProperty("Treasure Chest", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000007F) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000007F | (value_as_int << 0 & 0x0000007F));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("Treasure Chest Flags", "Chest Open Flag", true, "", SourceScene.Room)]
		public int ChestOpenFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F80) >> 7);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F80 | (value_as_int << 7 & 0x00000F80));
				OnPropertyChanged("ChestOpenFlag");
			}
		}

		[WProperty("Treasure Chest Flags", "Appear Condition Switch", true, "For the various behavior types that wait for a switch to be set, this is that switch.\nFor the \"Spawn when all enemies dead\" behavior type, the chest will instead set this switch when it appears, and use the switch to remember that it should spawn in on future room loads.", SourceScene.Room)]
		public int AppearConditionSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("AppearConditionSwitch");
			}
		}
		public enum AppearanceTypeEnum
		{
			Light_wood = 0,
			Dark_wood = 1,
			Metal = 2,
			Big_Key = 3,
		}


		[WProperty("Treasure Chest", "Appearance Type", true, "", SourceScene.Room)]
		public AppearanceTypeEnum AppearanceType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				if (!Enum.IsDefined(typeof(AppearanceTypeEnum), value_as_int))
					value_as_int = 0;
				return (AppearanceTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("AppearanceType");
				UpdateModel();
			}
		}

		[WProperty("Treasure Chest", "Room Number", true, "", SourceScene.Room)]
		public int RoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_XRotation = (short)(m_XRotation & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("RoomNumber");
			}
		}

		[WProperty("Treasure Chest Flags", "Open Switch", true, "", SourceScene.Room)]
		public int OpenSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("OpenSwitch");
			}
		}

		[WProperty("Treasure Chest", "Item", true, "", SourceScene.Room)]
		public ItemID Item
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0xFF00) >> 8);
				if (!Enum.IsDefined(typeof(ItemID), value_as_int))
					value_as_int = 0;
				return (ItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_ZRotation = (short)(m_ZRotation & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Item");
			}
		}

		// Constructor
		public tbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			ChestOpenFlag = -1;
			AppearConditionSwitch = -1;
			RoomNumber = -1;
			OpenSwitch = -1;
			Item = ItemID.No_item;
			if (Name == "takara") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Dark_wood;
			}
			if (Name == "takara2") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Light_wood;
			}
			if (Name == "takara3") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Metal;
			}
			if (Name == "takara4") {
				BehaviorType = BehaviorTypeEnum.Normal;
				AppearanceType = AppearanceTypeEnum.Big_Key;
			}
			if (Name == "takara5") {
				BehaviorType = BehaviorTypeEnum.Spawn_when_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Dark_wood;
			}
			if (Name == "takara6") {
				BehaviorType = BehaviorTypeEnum.Spawn_when_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Metal;
			}
			if (Name == "takara7") {
				BehaviorType = BehaviorTypeEnum.Spawn_when_all_enemies_dead;
				AppearanceType = AppearanceTypeEnum.Dark_wood;
			}
			if (Name == "takara8") {
				BehaviorType = BehaviorTypeEnum.Spawn_when_all_enemies_dead;
				AppearanceType = AppearanceTypeEnum.Metal;
			}
			if (Name == "takaraK") {
				BehaviorType = BehaviorTypeEnum.Visible_but_unopenable_until_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Dark_wood;
			}
			if (Name == "takaraI") {
				BehaviorType = BehaviorTypeEnum.Apply_gravity;
				AppearanceType = AppearanceTypeEnum.Dark_wood;
			}
			if (Name == "takaraM") {
				BehaviorType = BehaviorTypeEnum.Transparent_until_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Light_wood;
			}
			if (Name == "tkrASw") {
				BehaviorType = BehaviorTypeEnum.Spawn_when_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Light_wood;
			}
			if (Name == "tkrAGc") {
				BehaviorType = BehaviorTypeEnum.Spawn_when_all_enemies_dead;
				AppearanceType = AppearanceTypeEnum.Light_wood;
			}
			if (Name == "tkrAKd") {
				BehaviorType = BehaviorTypeEnum.Visible_but_unopenable_until_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Light_wood;
			}
			if (Name == "tkrAIk") {
				BehaviorType = BehaviorTypeEnum.Apply_gravity;
				AppearanceType = AppearanceTypeEnum.Light_wood;
			}
			if (Name == "tkrBMs") {
				BehaviorType = BehaviorTypeEnum.Transparent_until_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Dark_wood;
			}
			if (Name == "tkrCTf") {
				BehaviorType = BehaviorTypeEnum.Spawn_on_Triforce_emblem_when_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Metal;
			}
			if (Name == "tkrAOc") {
				BehaviorType = BehaviorTypeEnum.Uses_Stage_Save_Info_1_open_flag;
				AppearanceType = AppearanceTypeEnum.Light_wood;
			}
			if (Name == "tkrAOs") {
				BehaviorType = BehaviorTypeEnum.Uses_Stage_Save_Info_1_open_flag_and_spawns_when_a_switch_is_set;
				AppearanceType = AppearanceTypeEnum.Light_wood;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class title : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public title(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tn : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Wandering = 0,
			Guards_an_area = 4,
			Miniboss = 13,
			Drops_down_during_event = 14,
			Frozen_in_time = 15,
		}


		[WProperty("tn", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("BehaviorType");
			}
		}
		public enum ColorEnum
		{
			Silver_and_blue = 0,
			Silver_and_red = 1,
			Gold_and_black = 2,
			White_and_silver = 3,
			Black_and_brown = 4,
			Red_and_gold = 5,
		}


		[WProperty("tn", "Color", true, "", SourceScene.Room)]
		public ColorEnum Color
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				if (!Enum.IsDefined(typeof(ColorEnum), value_as_int))
					value_as_int = 5;
				return (ColorEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Color");
				UpdateModel();
			}
		}

		[WProperty("tn", "Guarded Area Radius (Tens)", true, "", SourceScene.Room)]
		public int GuardedAreaRadiusTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("GuardedAreaRadiusTens");
			}
		}
		public enum FrozeninTimePoseEnum
		{
			Walking_pose = 0,
			Attacking_pose = 1,
		}


		[WProperty("tn", "Frozen in Time Pose", true, "", SourceScene.Room)]
		public FrozeninTimePoseEnum FrozeninTimePose
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (!Enum.IsDefined(typeof(FrozeninTimePoseEnum), value_as_int))
					value_as_int = 0;
				return (FrozeninTimePoseEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("FrozeninTimePose");
				UpdateModel();
			}
		}

		[WProperty("tn", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("tn", "Enable Spawn Switch", true, "If this switch is valid, the Darknut will not appear until it is set.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}
		public enum ExtraEquipmentEnum
		{
			Normal = 0,
			Helmet = 1,
			Shield = 2,
			Helmet_and_shield = 3,
			Shield_and_cape = 4,
			Helmet_shield_and_cape = 5,
		}


		[WProperty("tn", "Extra Equipment", true, "", SourceScene.Room)]
		public ExtraEquipmentEnum ExtraEquipment
		{ 
			get
			{
				int value_as_int = (int)((m_XRotation & 0x00E0) >> 5);
				if (!Enum.IsDefined(typeof(ExtraEquipmentEnum), value_as_int))
					value_as_int = 5;
				return (ExtraEquipmentEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_XRotation = (short)(m_XRotation & ~0x00E0 | (value_as_int << 5 & 0x00E0));
				OnPropertyChanged("ExtraEquipment");
				UpdateModel();
			}
		}

		[WProperty("tn", "Disable Spawn on Death Switch", true, "The Darknut will set this switch when it dies and will not spawn while this is set.", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public tn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = false;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			GuardedAreaRadiusTens = -1;
			Path = null;
			EnableSpawnSwitch = -1;
			DisableSpawnonDeathSwitch = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class toge : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("toge", "Disabled Switch", true, "", SourceScene.Room)]
		public int DisabledSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DisabledSwitch");
			}
		}

		[WProperty("toge", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public toge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisabledSwitch = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tori_flag : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public tori_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tornado : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("tornado", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tornado(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tpota : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public tpota(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tsubo : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Small_pot = 0,
			Large_pot = 1,
			Water_pot = 2,
			Barrel = 3,
			Stool = 4,
			Skull = 5,
			Bucket = 6,
			Nut = 7,
			Golden_crate = 8,
			TotG_Pillar_Statue_A = 9,
			TotG_Pillar_Statue_B = 10,
			TotG_Pillar_Statue_C = 11,
			TotG_Pillar_Statue_D = 12,
			Seed = 13,
			Fancy_pot = 14,
			Wooden_crate = 15,
		}


		[WProperty("Pots", "Type", true, "Which model and behavior the pot should use.\nNote: The two crate types float along water currents, but the other types do not.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}
		public enum BehaviorTypeEnum
		{
			Spawns_When_Switch_is_Set = 0,
			Has_one_Boko_Stick = 1,
			Has_two_Boko_Sticks = 2,
			Has_three_Boko_Sticks = 3,
			Unknown_4 = 4,
			Inactive_Until_Switch_is_Set = 5,
			Unknown_6 = 6,
			Unknown_7 = 7,
			Unknown_8 = 8,
			Unknown_9 = 9,
			Unknown_10 = 10,
			Unknown_11 = 11,
			Unknown_12 = 12,
			Unknown_13 = 13,
			Unknown_14 = 14,
			Unknown_15 = 15,
			Unknown_16 = 16,
			Unknown_17 = 17,
			Unknown_18 = 18,
			Unknown_19 = 19,
			Unknown_20 = 20,
			Unknown_21 = 21,
			Unknown_22 = 22,
			Unknown_23 = 23,
			Unknown_24 = 24,
			Unknown_25 = 25,
			Unknown_26 = 26,
			Unknown_27 = 27,
			Unknown_28 = 28,
			Unknown_29 = 29,
			Unknown_30 = 30,
			Unknown_31 = 31,
			Unknown_32 = 32,
			Unknown_33 = 33,
			Unknown_34 = 34,
			Unknown_35 = 35,
			Unknown_36 = 36,
			Unknown_37 = 37,
			Unknown_38 = 38,
			Unknown_39 = 39,
			Unknown_40 = 40,
			Unknown_41 = 41,
			Unknown_42 = 42,
			Unknown_43 = 43,
			Unknown_44 = 44,
			Unknown_45 = 45,
			Unknown_46 = 46,
			Unknown_47 = 47,
			Unknown_48 = 48,
			Unknown_49 = 49,
			Unknown_50 = 50,
			Unknown_51 = 51,
			Unknown_52 = 52,
			Unknown_53 = 53,
			Unknown_54 = 54,
			Unknown_55 = 55,
			Unknown_56 = 56,
			Unknown_57 = 57,
			Unknown_58 = 58,
			Unknown_59 = 59,
			Unknown_60 = 60,
			Unknown_61 = 61,
			Unknown_62 = 62,
			Normal = 63,
		}


		[WProperty("Pots", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00003F00) >> 8);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00003F00 | (value_as_int << 8 & 0x00003F00));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("Pots", "Dropped Item", true, "", SourceScene.Room)]
		public DroppedItemID DroppedItem
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				if (!Enum.IsDefined(typeof(DroppedItemID), value_as_int))
					value_as_int = 0;
				return (DroppedItemID)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("DroppedItem");
			}
		}

		[WProperty("Pots", "Item Pickup Flag", true, "", SourceScene.Room)]
		public int ItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("ItemPickupFlag");
			}
		}
		public enum Unknown_3Enum
		{
			Unknown_0 = 0,
			Invisible = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
		}


		[WProperty("Pots", "Unknown_3", true, "", SourceScene.Room)]
		public Unknown_3Enum Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000C000) >> 14);
				if (!Enum.IsDefined(typeof(Unknown_3Enum), value_as_int))
					value_as_int = 0;
				return (Unknown_3Enum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000C000 | (value_as_int << 14 & 0x0000C000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("Pots", "Invincible When Off Camera", true, "If nonzero, and the pot is not in view of the camera, the pot will not check if it's being damaged every frame, making it invincible.\nIf zero, the pot will still be destroyable even when offscreen - this is recommended for pots with enemies hidden in them.", SourceScene.Room)]
		public int InvincibleWhenOffCamera
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x70000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x70000000 | (value_as_int << 28 & 0x70000000));
				OnPropertyChanged("InvincibleWhenOffCamera");
			}
		}

		[WProperty("Pots", "Do Not Ground On Spawn", true, "Normally, pots will teleport themselves to the nearest ground when they are spawned.\nIf this is checked, the pot will instead float where it was placed.\nFor Nuts, this also causes it to not start to rot away automatically on spawn.", SourceScene.Room)]
		public bool DoNotGroundOnSpawn
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 255) {
					return false;
				} else {
					return true;
				}
			}

			set
			{
				int value_as_int = value ? 1 : 0;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("DoNotGroundOnSpawn");
			}
		}

		[WProperty("Pots", "Enable Spawn/Activation Switch", true, "If the pot's behavior is set to 'Spawns When Switch is Set' and this switch is valid, the pot will not appear until this switch is set.\nIf the pot's behavior is set to 'Inactive Until Switch is Set' and this switch is valid, the pot will be visible, but cannot be broken, and picking it up will be strange and buggy, until this switch is set.\nNo effect on other behaviors.", SourceScene.Room)]
		public int EnableSpawnActivationSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("EnableSpawnActivationSwitch");
			}
		}

		// Constructor
		public tsubo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			BehaviorType = BehaviorTypeEnum.Normal;
			DroppedItem = DroppedItemID.No_item;
			ItemPickupFlag = -1;
			InvincibleWhenOffCamera = -1;
			EnableSpawnActivationSwitch = -1;
			if (Name == "kotubo") {
				Type = TypeEnum.Small_pot;
			}
			if (Name == "ootubo1") {
				Type = TypeEnum.Large_pot;
			}
			if (Name == "Kmtub") {
				Type = TypeEnum.Water_pot;
			}
			if (Name == "Ktaru") {
				Type = TypeEnum.Barrel;
			}
			if (Name == "Ostool") {
				Type = TypeEnum.Stool;
			}
			if (Name == "Odokuro") {
				Type = TypeEnum.Skull;
			}
			if (Name == "Okioke") {
				Type = TypeEnum.Bucket;
			}
			if (Name == "Kmi02") {
				Type = TypeEnum.Seed;
			}
			if (Name == "Ptubo") {
				Type = TypeEnum.Fancy_pot;
			}
			if (Name == "KkibaB") {
				Type = TypeEnum.Wooden_crate;
			}
			if (Name == "Kmi00") {
				Type = TypeEnum.Nut;
			}
			if (Name == "Hbox2S") {
				Type = TypeEnum.Golden_crate;
			}
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wall : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("wall", "Disable Spawn on Destroyed Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDestroyedSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("DisableSpawnonDestroyedSwitch");
			}
		}

		[WProperty("wall", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
				UpdateModel();
			}
		}

		// Constructor
		public wall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisableSpawnonDestroyedSwitch = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpdm20 : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("warpdm20", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpdm20(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpf : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("warpf", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpfout : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public warpfout(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpgn : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("warpgn", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("warpgn", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public warpgn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warphr : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("warphr", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warphr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpls : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Pink_Warp = 0,
			White_Warp = 1,
		}


		[WProperty("Light Beam Warp", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				if (!Enum.IsDefined(typeof(TypeEnum), value_as_int))
					value_as_int = 0;
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Light Beam Warp", "Exit", true, "", SourceScene.Room)]
		public ExitData Exit
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Exit");
			}
		}

		[WProperty("Light Beam Warp", "Activation Switch", true, "The warp will not appear and be active until this switch is set.", SourceScene.Room)]
		public int ActivationSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ActivationSwitch");
			}
		}

		[WProperty("Light Beam Warp", "Activated Event", true, "The event to start when activated.", SourceScene.Stage)]
		public MapEvent ActivatedEvent
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("ActivatedEvent");
			}
		}

		// Constructor
		public warpls(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Exit = null;
			ActivationSwitch = -1;
			ActivatedEvent = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpmj : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("warpmj", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpmj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class waterfall : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("waterfall", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("waterfall", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public waterfall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wbird : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public wbird(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class windmill : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("windmill", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public windmill(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wind_tag : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("wind_tag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("wind_tag", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("wind_tag", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x001F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x001F0000 | (value_as_int << 16 & 0x001F0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("wind_tag", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00600000) >> 21);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00600000 | (value_as_int << 21 & 0x00600000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("wind_tag", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00800000) >> 23);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00800000 | (value_as_int << 23 & 0x00800000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("wind_tag", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		[WProperty("wind_tag", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x000F | (value_as_int << 0 & 0x000F));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("wind_tag", "Unknown_8", true, "", SourceScene.Room)]
		public int Unknown_8
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_ZRotation = (short)(m_ZRotation & ~0x00F0 | (value_as_int << 4 & 0x00F0));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public wind_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
			Unknown_3 = -1;
			Unknown_4 = -1;
			Unknown_5 = -1;
			DisableSpawnSwitch = -1;
			Unknown_7 = -1;
			Unknown_8 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wz : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Shoots_Fireballs = 0,
			Spawns_Enemies_and_Shoots_Fireballs = 1,
			Miniboss = 2,
			Shoots_Fireballs_Alt_Color = 3,
			Fireball = 10,
			Spawner_Orb_1 = 12,
			Spawner_Orb_2 = 13,
		}


		[WProperty("wz", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (!Enum.IsDefined(typeof(BehaviorTypeEnum), value_as_int))
					value_as_int = 0;
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
				UpdateModel();
			}
		}

		[WProperty("wz", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		[WProperty("wz", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("wz", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Path");
			}
		}
		public enum EnemySummonTableEnum
		{
			Many_Keese_and_Magtails = 0,
			Many_Keese_and_Red_Bubbles = 1,
			Blue_Bubbles = 2,
			Many_Morths = 3,
			Many_Green_ChuChus = 4,
			Red_and_Blue_Bubbles_and_Poes = 5,
			Stalfos_and_ReDeads = 6,
			Moblins_and_Darknuts = 7,
			Peahats_Keese_and_Kargarocs = 8,
			Keese_and_Magtails = 9,
			Keese_and_Red_Bubbles = 10,
			Morths = 11,
			Green_ChuChus = 12,
			Bokoblins_and_Moblins = 13,
			Kargarocs_Keese_Green_and_Red_ChuChus_and_Morths = 14,
		}


		[WProperty("wz", "Enemy Summon Table", true, "", SourceScene.Room)]
		public EnemySummonTableEnum EnemySummonTable
		{ 
			get
			{
				int value_as_int = (int)((m_ZRotation & 0x00FF) >> 0);
				if (!Enum.IsDefined(typeof(EnemySummonTableEnum), value_as_int))
					value_as_int = 0;
				return (EnemySummonTableEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_ZRotation = (short)(m_ZRotation & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("EnemySummonTable");
			}
		}

		// Constructor
		public wz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = false;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			DisableSpawnonDeathSwitch = -1;
			EnableSpawnSwitch = -1;
			Path = null;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ygcwp : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("ygcwp", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public ygcwp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ykgr : Actor
	{
		// Auto-Generated Properties from Templates

		[WProperty("ykgr", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ykgr", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ykgr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}

		override public void PopulateDefaultProperties()
		{
			base.PopulateDefaultProperties();
			Unknown_1 = -1;
			Unknown_2 = -1;
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class yougan : Actor
	{
		// Auto-Generated Properties from Templates

		// Constructor
		public yougan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			Transform.UsesXRotation = true;
			Transform.UsesYRotation = true;
			Transform.UsesZRotation = true;
			Transform.RotationOrder = "ZYX";
		}
	}


} // namespace WindEditor
