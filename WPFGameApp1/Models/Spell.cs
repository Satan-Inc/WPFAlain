﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models
{
    class Spell
    {
        #region PROPERTIES
        private string _name;
		private string _description;
		private string _aspect;
		private int _damage;
		private int _mana;
		private int _focus;
		private int _range;
		private int _radius;
		private int _duration;

		public int Duration
		{
			get { return _duration; }
			set { _duration = value; }
		}

		public int Radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public int Range
		{
			get { return _range; }
			set { _range = value; }
		}

		public int Focus
		{
			get { return _focus; }
			set { _focus = value; }
		}

		public int Mana
		{
			get { return _mana; }
			set { _mana = value; }
		}

		public int Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		public string Aspect
		{
			get { return _aspect; }
			set { _aspect = value; }
		}

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
        #endregion

        #region CONSTRUCTORS
		public Spell(string name, string description, string aspect, int damage, int mana, int focus, int range, int radius, int duration)
		{
			_name = name;
			_description = description;
			_aspect = aspect;
			_damage = damage;
			_mana = mana;
			_focus = focus;
			_range = range;
			_radius = radius;
			_duration = duration;
		}

        #endregion

    }
}
